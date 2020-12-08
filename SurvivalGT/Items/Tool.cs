namespace SurvivalGT.Items
{
    class Tool : Item, IBreakable
    {
        private short durability;
        private short current_durability;

        public Tool(ItemTag tag, string name, float weight, string path, short durability)
            : base(tag, name, weight, path)
        {
            this.durability = durability;
            CurrentDurability = durability;
        }

        public short Durability => durability;

        public short CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        //public override object Clone()
        //{
        //    return new Tool(tag, name, weight, path, durability);
        //}
    }

    //class Fire : Tool
    //{

    //}

    //class LightSource : Tool
    //{
    //    private short search;

    //    public LightSource(ItemTag tag, string name, float weight, string path, short search, short durability)
    //        : base(tag, name, weight, path, durability)
    //    {
    //        Search = search;
    //    }

    //    public short Search { get => search; private set => search = value; }
    //}

    //class Fishrod : Tool
    //{ 
    
    //}

}
