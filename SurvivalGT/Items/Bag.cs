using SurvivalGT.Interfacies;
using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Bag : Item, IBreakable, IRepairable, IEquipable
    {
        protected int capacity;
        protected int current_durability;
        protected int durability;
        private bool is_equip;
        private Goods[] repair_materials;
        private int repair_time;

        public Bag()
        {

        }

        public Bag(ItemTag tag, string name, float weight, string image, int durability, int capacity, Goods[] repair_materials, int repair_time)
            : base(tag, ItemType.Utility, name, weight, image)
        {
            this.durability = durability;
            this.current_durability = durability;
            this.capacity = capacity;
            this.is_equip = false;
            this.repair_materials = repair_materials;
            this.repair_time = repair_time;
        }

        public int Capacity { get => capacity; }

        public int CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public int Durability { get => durability; }

        public bool IsEquip { get => is_equip; set => is_equip = value; }

        public Goods[] RepairGoods { get => repair_materials; }

        public int RepairTime { get => repair_time; }

        public void Equip()
        {

        }

        public void Repair(Inventory inventory, CraftItem[] crafts)
        {
            //if (current_durability == durability) return;

            //for (int i = 0; i < repair_materials.Length; i++)
            //{
            //    if (!materials_craft[i].Loot.Check(materials_craft[i].Count)) return;
            //}
            //for (int i = 0; i < repair_options.Length; i++)
            //{
            //    if (!options_craft[i].Loots.First.Value.Check(options_craft[i].Count)) return;
            //}

            //for (int i = 0; i < repair_materials.Length; i++)
            //{
            //    materials_craft[i].Loot.Use(materials_craft[i].Count, inventory);
            //}
            //for (int i = 0; i < repair_options.Length; i++)
            //{
            //    options_craft[i].Loots.First.Value.Use(1, inventory);
            //}

            //if (durability - current_durability < 20) CurrentDurability += durability - current_durability;
            //else CurrentDurability += 20;
        }

        public void Unequip()
        {

        }

        public void WearOut()
        {

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

        public Transport(ItemTag tag, string name, float weight, string path, int durability, int capacity, short fuel_consume, short speed, Goods[] repair_materials, int repair_time)
            : base(tag, name, weight, path, durability, capacity, repair_materials, repair_time)
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
