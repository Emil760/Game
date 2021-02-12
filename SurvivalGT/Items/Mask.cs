using SurvivalGT.Interfacies;
using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Mask : Item, ISpoilable, IEquipable
    {
        private short rad;
        private int time;
        private bool is_equip;

        public Mask(ItemTag tag, string name, float weight, string path, short rad, int time)
            : base(tag, ItemType.Utility, name, weight, path)
        {
            this.rad = rad;
            this.time = time;
            is_equip = false;
        }

        public short Radiathion { get => rad; }
        public int Time { get => time; set => time = value; }
        public bool IsEquip { get => is_equip; set => is_equip = value; }

        public virtual void Spoil()
        {

        }

        public void Equip()
        {

        }

        public void Unequip()
        {

        }
    }

    class GasMask : Mask, IRepairable, IEmptyable, IRespoilable
    {
        private bool is_empty;
        private string normal_path;
        private string empty_path;
        private int full_time;
        private Goods[] repair_materials;
        private int repair_time;

        public GasMask(ItemTag tag, string name, float weight, string path, string empty_path, short rad, int time, Goods[] repair_materials, int repair_time)
            : base(tag, name, weight, empty_path, rad, time)
        {
            this.normal_path = path;
            this.empty_path = empty_path;
            this.is_empty = true;
            this.full_time = time;
            this.repair_materials = repair_materials;
            this.repair_time = repair_time;
        }

        public bool IsEmpty { get => is_empty; set => is_empty = value; }

        public string NormalPath { get => normal_path; }

        public string EmptyPath { get => empty_path; }

        public int FullTime { get => full_time; private set => full_time = value; }

        public Goods[] RepairGoods { get => repair_materials; }

        public int RepairTime { get => repair_time; }

        public void Repair(Inventory inventory, CraftItem[] crafts)
        {

        }

        public override void Spoil()
        {

        }
    }

}
