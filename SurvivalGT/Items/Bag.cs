using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Bag : Item, IBreakable, IRepairable, IEquipable
    {
        protected int capacity;
        protected int current_durability;
        protected int durability;
        private Loot[] repair_loots;
        private bool is_equip;

        public Bag()
        {

        }

        public Bag(ItemTag tag, string name, float weight, string image, int durability, int capacity, Loot[] repair_loots)
            : base(tag, ItemType.Utility, name, weight, image)
        {
            this.durability = durability;
            this.capacity = capacity;
            this.repair_loots = repair_loots;
            this.is_equip = false;
        }

        public int Сapacity { get => capacity; }

        public int CurrentDurability { get => current_durability; set => current_durability = value; }

        public int Durability { get => durability; }

        public Loot[] RepairLoots { get => repair_loots; }

        public Goods[] RepairGoods => throw new System.NotImplementedException();

        public bool IsEquip { get => is_equip; set => is_equip = value; }

        public void Equip()
        {
            throw new System.NotImplementedException();
        }

        public void Repair()
        {
            throw new System.NotImplementedException();
        }

        public void Unequip()
        {
            throw new System.NotImplementedException();
        }

        public void WearOut()
        {
            throw new System.NotImplementedException();
        }

        //public override object Clone()
        //{
        //    return new Bag(tag, name, weight, path, durability, capacity, repair_loots) { current_durability = this.current_durability };
        //}
    }

    class Transport : Bag
    {
        private short speed;
        private short fuel_consume;

        public Transport(ItemTag tag, string name, float weight, string path, int durability, int capacity, short fuel_consume, short speed, Loot[] repair_loots)
            : base(tag, name, weight, path, durability, capacity, repair_loots)
        {
            this.speed = speed;
            this.fuel_consume = fuel_consume;
        }

        public short Speed { get => speed; }

        public short FuelConsume { get => fuel_consume; }

        //public override object Clone()
        //{
        //    return new System.NotImplementedException();
        //}

    }
}
