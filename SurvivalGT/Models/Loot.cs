using System;
using SurvivalGT.Items;
using System.Collections.Generic;
using SurvivalGT.Utility;

namespace SurvivalGT.Models
{
    public class Loot : ObserableObject
    {
        protected Item item;
        protected int count;

        public Loot(Item item, int count)
        {
            this.item = item;
            this.count = count;
        }

        public int Count { get => count; set => Set(ref count, value); }
        public Item Item { get => item; set => item = value; }

        public virtual void Take(Inventory inventory)
        {
            try
            {
                var temp = inventory.AllLoots[this.Item.Tag];
                temp.Count += count;
            }
            catch (KeyNotFoundException)
            {
                inventory.AllLoots.Add(item.Tag, this);
                inventory.Filter.Invoke(this);
            }
        }

        public virtual Loot Drop(Inventory inventory)
        {
            inventory.AllLoots.Remove(item.Tag);
            inventory.Loots.Remove(this);
            return this;
        }

        public virtual Loot Drop(Inventory inventory, int count)
        {
            if (this.count == count) return Drop(inventory);
            else
            {
                Count -= count;
                return new Loot(item, count);
            }
        }

        public virtual bool Check(int count, int? time = null)
        {
            if (this.count >= count) return true;
            else return false;
        }

        public virtual void Use(int count, Inventory inventory)
        {
            if (this.count == count) inventory.AllLoots.Remove(item.Tag);
            Count -= count;
        }
    }

    public class LootBreak : Loot
    {
        private LinkedList<int> durabilities;

        public LootBreak(Item item, int count, LinkedList<int> durabilities) : base(item, count)
        {
            this.durabilities = durabilities;
        }

        public LinkedList<int> Durabilities { get => durabilities; set => durabilities = value; }

        public override void Take(Inventory inventory)
        {
            try
            {
                LootBreak temp = inventory.AllLoots[item.Tag] as LootBreak;
                temp.Count += count;
                foreach (var dur in durabilities)
                    temp.Durabilities.AddLast(dur);
            }
            catch (KeyNotFoundException)
            {
                inventory.AllLoots.Add(item.Tag, this);
                inventory.Filter.Invoke(this);
            }
        }

        public override Loot Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override Loot Drop(Inventory inventory, int count)
        {
            if (this.count == count) return base.Drop(inventory);
            else
            {
                LinkedList<int> breaks = new LinkedList<int>();
                var it = durabilities.First;
                for (int i = 0; i < count; i++)
                {
                    breaks.AddFirst(it.Value);
                    it = it.Next;
                    Durabilities.RemoveFirst();
                }
                return new LootBreak(this.Item, count, breaks);
            }
        }

        public override bool Check(int count, int? time = null)
        {
            return base.Check(count);
        }

        public override void Use(int count, Inventory inventory)
        {
            for (int i = 0; i < count; i++)
            {
                if (durabilities.First.Value - 1 == 0)
                {
                    durabilities.RemoveFirst();
                    ((IBreakable)item).CurrentDurability = durabilities.First.Value;
                    Count--;
                }
                else durabilities.First.Value--;
            }
            if (durabilities.Count == 0) inventory.AllLoots.Remove(item.Tag);
        }
    }

    public class LootSpoil : Loot
    {
        private LinkedList<int> times;

        public LootSpoil(Item item, int count, LinkedList<int> times) : base(item, count)
        {
            this.times = times;
        }

        public LinkedList<int> Times { get => times; set => times = value; }

        public override void Take(Inventory inventory)
        {
            try
            {
                LootSpoil temp = inventory.AllLoots[item.Tag] as LootSpoil;
                temp.Count += count;
                foreach (var time in times)
                    temp.Times.AddLast(time);
            }
            catch (KeyNotFoundException)
            {
                inventory.AllLoots.Add(item.Tag, this);
                inventory.Filter.Invoke(this);
            }
        }

        public override Loot Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override Loot Drop(Inventory inventory, int count)
        {
            if (this.count == count) return base.Drop(inventory);
            else
            {
                LinkedList<int> times = new LinkedList<int>();
                var it = times.First;
                for (int i = 0; i < count; i++)
                {
                    times.AddFirst(it.Value);
                    it = it.Next;
                    this.times.RemoveFirst();
                }
                return new LootSpoil(item, count, times);
            }
        }

        public override bool Check(int count, int? time)
        {
            if (times.Count <= count) return false;
            if (times.First.Value < time.Value) return false;
            else return true;
        }

        public override void Use(int count, Inventory inventory)
        {
            base.Use(count, inventory);
            for (int i = 0; i < count; i++)
            {
                times.RemoveFirst();
            }
            ((ISpoilable)item).Time = times.First.Value;
        }
    }

    abstract public class CraftItem : ObserableObject
    {
        private Item item;

        public CraftItem(Item item)
        {
            this.item = item;
        }

        public Item Item { get => item; set => item = value; }
    }

    public class CraftMaterial : CraftItem
    {
        private int count;
        private Loot loot;

        public CraftMaterial(Item item, int count, Loot loot) : base(item)
        {
            this.count = count;
            this.loot = loot;
        }

        public Loot Loot { get => loot; set => loot = value; }
        public int Count { get => count; set => count = value; }
    }

    public class CraftOption : CraftItem
    {
        private LinkedList<Loot> loots;
        private int count;

        public CraftOption(Item item, LinkedList<Loot> loots) : base(item)
        {
            this.loots = loots;
            foreach (var loot in loots)
                Count += loot.Count;
        }

        public LinkedList<Loot> Loots { get => loots; set => loots = value; }
        public int Count { get => count; set => Set(ref count, value); }
    }

    public class LootRandom
    {
        private ItemTag tag;
        private int min;
        private int max;

        public LootRandom(ItemTag tag, int min, int max)
        {
            this.tag = tag;
            this.min = min;
            this.max = max;
        }

        public ItemTag Tag { get => tag; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }

        public Loot GetLoot()
        {
            Random random = new Random();
            return new Loot(ItemFactory.GetItem(tag), random.Next(min, max));
        }
    }

    public class LootMulty
    {
        static KeyValuePair<ItemTag, Item[]> craftitems;

        static LootMulty()
        {

        }
    }
}
