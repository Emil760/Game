﻿namespace SurvivalGT.Items
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
            throw new System.NotImplementedException();
        }

        public void Equip()
        {
            throw new System.NotImplementedException();
        }

        public void Unequip()
        {
            throw new System.NotImplementedException();
        }
    }

    class GasMask : Mask, IRepairable, IEmptyable, IRespoilable
    {
        private Goods[] goods;
        private bool is_empty;
        private string normal_path;
        private string empty_path;
        private int full_time;

        public GasMask(ItemTag tag, string name, float weight, string path, string empty_path, short rad, Goods[] goods, int time)
            : base(tag, name, weight, empty_path, rad, time)
        {
            normal_path = path;
            this.empty_path = empty_path;
            is_empty = true;
            full_time = time;
            this.goods = goods;
        }

        public Goods[] RepairGoods { get => goods; }

        public bool IsEmpty { get => is_empty; set => is_empty = value; }

        public string NormalPath { get => normal_path; }

        public string EmptyPath { get => empty_path; }

        public int FullTime { get => full_time; private set => full_time = value; }

        public void Repair()
        {
            throw new System.NotImplementedException();
        }

        public override void Spoil()
        {
            base.Spoil();
        }
    }

}
