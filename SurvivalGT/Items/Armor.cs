using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Armor : Item, IBreakable, IRepairable
    {
        private short armor_points;
        private int current_durability;
        private int durability;

        public Armor(ItemTag tag, string name, float weight, string image, int durability, short armor_points, Loot[] repair_loots)
            : base(tag, ItemType.Utility, name, weight, image)
        {
            CurrentDurability = durability;
            this.armor_points = armor_points;
        }

        public short ArmorPoint { get => armor_points; }

        public int CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public int Durability { get => durability; }

        public Goods[] RepairGoods => throw new System.NotImplementedException();

        public void Repair()
        {
            throw new System.NotImplementedException();
        }

        public void WearOut()
        {
            throw new System.NotImplementedException();
        }

        //public override object Clone()
        //{
        //    return new Armor(tag, name, weight, path, durability, armor_points, repair_loots);
        //}
    }
}
