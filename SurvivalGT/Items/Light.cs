using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    public class Light : Item, IEquipable, ISpoilable
    {
        private int time;
        private bool is_equip;
        private short search_bonus;


        public Light(ItemTag tag, string name, float weight, string path, short search_bonus, int time)
            : base(tag, ItemType.Utility, name, weight, path)
        {
            this.time = time;
            this.is_equip = false;
            this.search_bonus = search_bonus;
        }

        public short SearchBonus { get => search_bonus; }
        public bool IsEquip { get => is_equip; set => is_equip = value; }
        public int Time { get => time; set => time = value; }

        public void Equip()
        {

        }

        public void Spoil()
        {

        }

        public void Unequip()
        {

        }
    }

    public class Flashlight : Light, IRepairable
    {
        private Goods[] repair_materials;
        private ItemTag[] repair_options;
        private int repair_time;

        public Flashlight(ItemTag tag, string name, float weight, string path, short search_bonus, int time, Goods[] repair_materials, ItemTag[] repair_options, int repair_time)
            : base(tag, name, weight, path, search_bonus, time)
        {
            this.repair_materials = repair_materials;
            this.repair_options = repair_options;
            this.repair_time = repair_time;
        }


        public Goods[] RepairMaterials { get => repair_materials; }

        public ItemTag[] RepairOptions { get => repair_options; }

        public int RepairTime { get => repair_time; }

        //
        public void Repair(Inventory inventory, CraftMaterial[] materials_craft, CraftOption[] options_craft)
        {

        }
    }
}
