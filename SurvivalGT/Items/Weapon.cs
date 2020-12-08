using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    abstract class Weapon : Item
    {
        protected short min_damage;
        protected short max_damage;
        protected short act_point;

        public Weapon()
        {

        }

        public Weapon(ItemTag tag, string name, float weight, string path, short act_point, short min_damage, short max_damage)
            : base(tag, name, weight, path)
        {
            this.act_point = act_point;
            this.min_damage = min_damage;
            this.max_damage = max_damage;
        }

        public short MinDamage { get => min_damage; }

        public short MaxDamage { get => max_damage; }

        public short ActPoint { get => act_point; }
    }

    class MealWeapon : Weapon, IBreakable
    {
        private short durability;
        private short current_durability;

        public MealWeapon(ItemTag tag, string name, float weight, string path, short act_point, short durability, short min_damage, short max_damage)
            : base(tag, name, weight, path, act_point, min_damage, max_damage)
        {
            CurrentDurability = durability;
            this.current_durability = durability;
        }

        public short CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public short Durability { get => durability; }

        //public override object Clone()
        //{
        //    return new System.NotImplementedException();
        //}
    }

    class RangeWeapon : Weapon, IBreakable, IRepairable
    {
        private short current_durability;
        private short durability;
        private Loot[] repair_loots;

        public RangeWeapon(ItemTag tag, string name, float weight, string path, short act_point, short min_damage, short max_damage, short durability, Loot[] repair_loots)
        : base(tag, name, weight, path, act_point, min_damage, max_damage)
        {
            this.durability = durability;
            CurrentDurability = durability;
            this.repair_loots = repair_loots;
        }

        public short CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public short Durability { get => durability; }

        public Loot[] RepairLoots { get => repair_loots; }

        //public override object Clone()
        //{
        //    return new System.NotImplementedException();
        //}
    }

    class ExplosiveWeapon : Weapon
    {
        public ExplosiveWeapon(ItemTag tag, string name, float weight, string path, short act_point, short min_damage, short max_damage)
            : base(tag, name, weight, path, act_point, min_damage, max_damage)
        {

        }

        public override object Clone()
        {
            return new System.NotImplementedException();
        }
    }
}
