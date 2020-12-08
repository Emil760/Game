using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Bag : Item, IBreakable, IRepairable
    {
        protected int capacity;
        protected short current_durability;
        protected short durability;
        private Loot[] repair_loots;

        public Bag()
        {

        }

        public Bag(ItemTag tag, string name, float weight, string image, short durability, int capacity, Loot[] repair_loots)
            : base(tag, name, weight, image)
        {
            this.durability = durability;
            this.capacity = capacity;
            this.repair_loots = repair_loots;
        }

        public int Сapacity { get => capacity; }

        public short CurrentDurability { get => current_durability; set => current_durability = value; }

        public short Durability { get => durability; }

        public Loot[] RepairLoots { get => repair_loots; }

        //public override object Clone()
        //{
        //    return new Bag(tag, name, weight, path, durability, capacity, repair_loots) { current_durability = this.current_durability };
        //}
    }

    class Transport : Bag
    {
        private short speed;
        private short fuel_consume;

        public Transport(ItemTag tag, string name, float weight, string image_path, short durability, int capacity, short fuel_consume, short speed, Loot[] repair_loots)
            : base(tag, name, weight, image_path, durability, capacity, repair_loots)
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
