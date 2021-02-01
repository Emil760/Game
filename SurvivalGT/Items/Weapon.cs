using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    abstract class Weapon : Item
    {
        protected short min_damage;
        protected short max_damage;
        protected short action_points;

        public Weapon()
        {

        }

        public Weapon(ItemTag tag, string name, float weight, string path, short action_points, short min_damage, short max_damage)
            : base(tag, ItemType.Weapon, name, weight, path)
        {
            this.action_points = action_points;
            this.min_damage = min_damage;
            this.max_damage = max_damage;
        }

        public short MinDamage { get => min_damage; set => min_damage = value; }

        public short MaxDamage { get => max_damage; set => max_damage = value; }

        public short ActionPoints { get => action_points; }
    }

    class MeleeWeapon : Weapon, IBreakable
    {
        private int durability;
        private int current_durability;

        public MeleeWeapon(ItemTag tag, string name, float weight, string path, short act_point, short min_damage, short max_damage, int durability)
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
        private short range;
        private int current_durability;
        private int durability;
        private Goods[] repair_materials;
        private ItemTag[] repair_options;
        private int repair_time;


        public RangeWeapon(ItemTag tag, string name, float weight, string path, short action_points, short min_damage, short max_damage, ItemTag ammo, short range, int durability, Goods[] repair_materials, ItemTag[] repair_options, int repair_time)
        : base(tag, name, weight, path, action_points, min_damage, max_damage)
        {
            this.ammo = ammo;
            this.range = range;
            this.durability = durability;
            CurrentDurability = durability;
            this.repair_materials = repair_materials;
            this.repair_options = repair_options;
            this.repair_time = repair_time;
        }

        public ItemTag Ammo { get => ammo; set => ammo = value; }

        public short Range { get => range; }

        public int CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public int Durability { get => durability; }

        public Goods[] RepairMaterials { get => repair_materials; }

        public ItemTag[] RepairOptions { get => repair_options; }

        public int RepairTime { get => repair_time; }

        public void Repair(Inventory inventory, CraftMaterial[] materials_craft, CraftOption[] options_craft)
        {
            if (current_durability == durability) return;

            for (int i = 0; i < repair_materials.Length; i++)
            {
                if (!materials_craft[i].Loot.Check(materials_craft[i].Count)) return;
            }
            for (int i = 0; i < repair_options.Length; i++)
            {
                if (!options_craft[i].Loots.First.Value.Check(options_craft[i].Count)) return;
            }

            for (int i = 0; i < repair_materials.Length; i++)
            {
                materials_craft[i].Loot.Use(materials_craft[i].Count, inventory);
            }
            for (int i = 0; i < repair_options.Length; i++)
            {
                options_craft[i].Loots.First.Value.Use(1, inventory);
            }

            if (durability - current_durability < 20) CurrentDurability += durability - current_durability;
            else CurrentDurability += 20;
        }

        public void WearOut()
        {

        }
    }

    class ExplosiveWeapon : Weapon
    {
        public ExplosiveWeapon(ItemTag tag, string name, float weight, string path, short action_points, short min_damage, short max_damage)
            : base(tag, name, weight, path, action_points, min_damage, max_damage)
        {

        }

        public override object Clone()
        {
            return new System.NotImplementedException();
        }
    }
}
