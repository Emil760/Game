using SurvivalGT.Items;
using System.Collections.Generic;

namespace SurvivalGT.Models
{
    public class Loot
    {
        private Item item;
        private int count;

        public Loot(Item item, int count)
        {
            this.item = item;
            this.count = count;
        }

        public int Count { get => count; set => count = value; }
        public Item Item { get => item; set => item = value; }

        public virtual void Take(Inventory inventory)
        {
            try
            {
                var temp = inventory.AllLoots[this.Item.Tag];
                temp.Count += Count;
            }
            catch (KeyNotFoundException)
            {
                inventory.AllLoots.Add(this.Item.Tag, this);
                inventory.Filter.Invoke(this);
            }
        }

        public virtual Loot Drop(Inventory inventory)
        {
            inventory.AllLoots.Remove(Item.Tag);
            inventory.Loots.Remove(this);
            return this;
        }

        public virtual Loot Drop(Inventory inventory, int count)
        {
            if (Count == count) return Drop(inventory);
            else
            {
                Count -= count;
                return new Loot(Item, count);
            }
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
                LootSpoil temp = inventory.AllLoots[this.Item.Tag] as LootSpoil;
                temp.Count += this.Count;
                foreach (var time in this.Times)
                    temp.Times.AddLast(time);
            }
            catch (KeyNotFoundException)
            {
                inventory.AllLoots.Add(this.Item.Tag, this);
                inventory.Filter.Invoke(this);
            }
        }

        public override Loot Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override Loot Drop(Inventory inventory, int count)
        {
            if (this.Count == count) return base.Drop(inventory);
            else
            {
                LinkedList<int> times = new LinkedList<int>();
                var it = this.Times.First;
                for (int i = 0; i < count; i++)
                {
                    times.AddFirst(it.Value);
                    it = it.Next;
                    this.Times.RemoveFirst();
                }
                return new LootSpoil(this.Item, count, times);
            }
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
                LootBreak temp = inventory.AllLoots[this.Item.Tag] as LootBreak;
                temp.Count += this.Count;
                foreach (var dur in this.Durabilities)
                    temp.Durabilities.AddLast(dur);
            }
            catch (KeyNotFoundException)
            {
                inventory.AllLoots.Add(this.Item.Tag, this);
                inventory.Filter.Invoke(this);
            }
        }

        public override Loot Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override Loot Drop(Inventory inventory, int count)
        {
            if (this.Count == count) return base.Drop(inventory);
            else
            {
                LinkedList<int> times = new LinkedList<int>();
                var it = this.Durabilities.First;
                for (int i = 0; i < count; i++)
                {
                    times.AddFirst(it.Value);
                    it = it.Next;
                    this.Durabilities.RemoveFirst();
                }
                return new LootBreak(this.Item, count, times);
            }
        }
    }
}
