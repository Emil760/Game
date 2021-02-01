using SurvivalGT.Items;
using SurvivalGT.Models;
using System.Collections.Generic;

namespace SurvivalGT.Temp
{
    public interface ILoot
    {
        void Take(Inventory inventory);

        Loot Drop(Inventory inventory);

        Loot Drop(Inventory inventory, int count);

        bool Check(int count, int? time = null);

        void Use(Inventory inventory, int count);
    }

    public class Loot : ILoot
    {
        protected Item item;
        protected int count;

        public Loot(Item item, int count)
        {
            this.item = item;
            this.count = count;
        }

        public Item Item { get; }
        public int Count { get; }

        public virtual bool Check(int count, int? time = null)
        {
            throw new System.NotImplementedException();
        }

        public virtual Loot Drop(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public virtual Loot Drop(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Take(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Use(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }
    }

    public class LootBreak : Loot
    {
        private LinkedList<int> breaks;

        public LootBreak(Item item, int count, LinkedList<int> breaks) : base(item, count)
        {
            this.breaks = breaks;
            this.breaks.AddLast((item as IBreakable).CurrentDurability);
        }

        public LinkedList<int> Breaks { get; }

        public override void Take(Inventory inventory)
        {
            base.Take(inventory);
        }

        public override Loot Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override Loot Drop(Inventory inventory, int count)
        {
            return base.Drop(inventory, count);
        }

        public override bool Check(int count, int? time = null)
        {
            return base.Check(count, time);
        }

        public override void Use(Inventory inventory, int count)
        {
            base.Use(inventory, count);
        }
    }

    public class LootSpoil : Loot
    {
        private LinkedList<int> spoils;

        public LootSpoil(Item item, int count, LinkedList<int> spoils) : base(item, count)
        {

        }

        public LinkedList<int> Spoils { get; }

        public override void Take(Inventory inventory)
        {
            base.Take(inventory);
        }

        public override Loot Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override Loot Drop(Inventory inventory, int count)
        {
            return base.Drop(inventory, count);
        }

        public override bool Check(int count, int? time = null)
        {
            return base.Check(count, time);
        }

        public override void Use(Inventory inventory, int count)
        {
            base.Use(inventory, count);
        }
    }

    class LootOption : ILoot
    {
        private LootBreak loot;
        private LinkedList<LootBreak> options;

        public LootOption(Item item, int count)
        {
            loot = new LootBreak(item, count, new LinkedList<int>());
            options = null;
        }

        public void Take(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public Loot Drop(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public Loot Drop(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }

        public bool Check(int count, int? time = null)
        {
            throw new System.NotImplementedException();
        }

        public void Use(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }
    }
}
