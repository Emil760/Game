﻿namespace SurvivalGT.Items
{

    class Book : Item
    {
        short level;
        short stamina;

        public Book(ItemTag tag, string name, float weight, string path, short level, short stamina) :
            base(tag, ItemType.Utility, name, weight, path)
        {
            this.level = level;
            this.stamina = stamina;
        }

        public short Level { get => level; }
        public short Stamina { get => stamina; }

        //public override object Clone()
        //{
        //    return new Book(tag, name, weight, path, level, stamina);
        //}
    }
}
