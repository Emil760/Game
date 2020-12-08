using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Armor : Item, IBreakable, IRepairable
    {
        private short armor_points;
        private short current_durability;
        private short durability;
        private Loot[] repair_loots;

        private Armor(ItemTag tag, string name, float weight, string image, short durability, short armor_points, Loot[] repair_loots)
            : base(tag, name, weight, image)
        {
            CurrentDurability = durability;
            this.armor_points = armor_points;
            this.repair_loots = repair_loots;
        }

        public short ArmorPoint { get => armor_points; }

        public short CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public short Durability { get => durability; }

        public Loot[] RepairLoots { get => repair_loots; }

        //public override object Clone()
        //{
        //    return new Armor(tag, name, weight, path, durability, armor_points, repair_loots);
        //}
    }
}
