namespace SurvivalGT.Items
{
    class Tool : Item, IBreakable
    {
        protected int durability;
        protected int current_durability;

        public Tool(ItemTag tag, string name, float weight, string path)
            : base(tag, ItemType.Tool, name, weight, path)
        {

        }

        public Tool(ItemTag tag, string name, float weight, string path, int durability)
            : base(tag, ItemType.Tool, name, weight, path)
        {
            this.durability = durability;
            this.current_durability = durability;
        }

        public int Durability { get => durability; }

        public int CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public void WearOut()
        {

        }
    }

    class OptionTool : Tool
    {
        ItemTag option;

        public OptionTool(ItemTag tag, string name, float weight, string path, ItemTag option)
            : base(tag, name, weight, path)
        {
            this.option = option;
        }

        public OptionTool(ItemTag tag, string name, float weight, string path, int durability, ItemTag option)
            : base(tag, name, weight, path, durability)
        {
            this.option = option;
        }

        public ItemTag Option { get => option; }
    }

    class OldTool : OptionTool
    {
        private static int min_durability;
        private static int max_durability;

        //change max min
        static OldTool()
        {
            min_durability = 15;
            max_durability = 50;
        }

        public OldTool(ItemTag tag, string name, float weight, string path, ItemTag option)
            : base(tag, name, weight, path, option)
        {

        }
    }

}