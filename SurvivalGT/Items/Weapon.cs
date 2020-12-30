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
            : base(tag, ItemType.Weapon, name, weight, path)
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
        private int durability;
        private int current_durability;

        public MealWeapon(ItemTag tag, string name, float weight, string path, short act_point, short min_damage, short max_damage, int durability)
            : base(tag, name, weight, path, act_point, min_damage, max_damage)
        {
            this.durability = durability;
            this.current_durability = durability;
        }

        public int CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public int Durability { get => durability; }

        public void WearOut()
        {
            throw new System.NotImplementedException();
        }

        //public override object Clone()
        //{
        //    return new System.NotImplementedException();
        //}
    }

    class RangeWeapon : Weapon, IBreakable, IRepairable
    {
        private ItemTag ammo;
        private int current_durability;
        private int durability;
        private Loot[] repair_loots;

        public RangeWeapon(ItemTag tag, string name, float weight, string path, short act_point, short min_damage, short max_damage, ItemTag ammo, int durability, Loot[] repair_loots)
        : base(tag, name, weight, path, act_point, min_damage, max_damage)
        {
            this.ammo = ammo;
            this.durability = durability;
            CurrentDurability = durability;
            this.repair_loots = repair_loots;
        }

        public ItemTag Ammo { get => ammo; set => ammo = value; }

        public int CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public int Durability { get => durability; }

        public Loot[] RepairLoots { get => repair_loots; }

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
