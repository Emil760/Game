using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Armor : Item, IBreakable, IRepairable
    {
        private short armor_points;
        private int current_durability;
        private int durability;
        private Goods[] repair_materials;
        private ItemTag[] repair_options;
        private int repair_time;

        public Armor(ItemTag tag, string name, float weight, string image, int durability, short armor_points, Goods[] repair_materials, ItemTag[] repair_options, int repair_time)
            : base(tag, ItemType.Utility, name, weight, image)
        {
            this.durability = durability;
            this.current_durability = durability;
            this.armor_points = armor_points;
            this.repair_materials = repair_materials;
            this.repair_options = repair_options;
            this.repair_time = repair_time;
        }

        public short ArmorPoint { get => armor_points; }

        public int CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public int Durability { get => durability; }

        public Goods[] RepairMaterials { get => repair_materials; }

        public ItemTag[] RepairOptions { get => repair_options; }

        public int RepairTime { get => repair_time; }

        public void Repair(Inventory inventory, CraftMaterial[] materials_craft, CraftOption[] options_craft)
        {
            //if (current_durability == durability) return;
            System.Console.WriteLine("enter");

            for (int i = 0; i < repair_materials.Length; i++)
            {
                if (!materials_craft[i].Loot.Check(materials_craft[i].Count)) return;
            }
            for (int i = 0; i < repair_options.Length; i++)
            {
                if (!options_craft[i].Loots.First.Value.Check(1)) return;
            }

            for (int i = 0; i < repair_materials.Length; i++)
            {
                materials_craft[i].Loot.Use(materials_craft[i].Count, inventory);
            }
            for (int i = 0; i < repair_options.Length; i++)
            {
                options_craft[i].Loots.First.Value.Use(1, inventory);
            }
            
            //if (durability - current_durability < 20) CurrentDurability += durability - current_durability;
            //else CurrentDurability += 20;
            System.Console.WriteLine(current_durability);
        }

        public void WearOut()
        {

        }

        //public override object Clone()
        //{
        //    return new Armor(tag, name, weight, path, durability, armor_points, repair_loots);
        //}
    }
}
