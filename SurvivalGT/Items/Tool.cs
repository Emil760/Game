using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Tool : Item, IBreakable
    {
        private int durability;
        private int current_durability;

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
            throw new System.NotImplementedException();
        }
    }

    class OptionTool : Tool
    {
        ItemTag option;

        public OptionTool(ItemTag tag, string name, float weight, string path, int durability, ItemTag option)
            : base(tag, name, weight, path, durability)
        {
            this.option = option;
        }
    }

    class OldTool : OptionTool
    {
        public OldTool(ItemTag tag, string name, float weight, string path, int durability, ItemTag option)
            : base(tag, name, weight, path, durability, option)
        {

        }
    }

    class Primus : OptionTool, IRepairable, IEmptyable
    {
        private Goods[] repair_goods;
        private bool is_empty;
        private string normal_path;
        private string empty_path;

        public Primus(ItemTag tag, string name, float weight, string path, string empty_path, short durability, Goods[] repair_goods, ItemTag option)
            : base(tag, name, weight, path, durability, option)
        {
            this.repair_goods = repair_goods;
            this.path = empty_path;
            this.normal_path = path;
            this.empty_path = empty_path;
            is_empty = true;
        }

        public Goods[] RepairGoods { get => repair_goods; }

        public bool IsEmpty { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string NormalPath => throw new System.NotImplementedException();

        public string EmptyPath => throw new System.NotImplementedException();

        public void Repair()
        {
            throw new System.NotImplementedException();
        }
    }

    class Fishrod : Tool, IRepairable
    {
        private Goods[] repair_goods;
        private static Loot[] baits;

        static Fishrod()
        {
            baits = new Loot[5];
        }

        public Fishrod(ItemTag tag, string name, float weight, string path, int durability, Goods[] repair_goods)
           : base(tag, name, weight, path, durability)
        {
            this.repair_goods = repair_goods;
        }

        public Goods[] RepairGoods => throw new System.NotImplementedException();

        public static Loot[] Baits { get => baits; set => baits = value; }

        public void Repair()
        {
            throw new System.NotImplementedException();
        }
    }

    class Light : Tool, IRepairable
    {
        private short search;
        private Goods[] repair_goods;

        public Light(ItemTag tag, string name, float weight, string path, short search, short durability, Goods[] repair_goods)
           : base(tag, name, weight, path, durability)
        {
            this.search = search;
            this.repair_goods = repair_goods;
        }

        public Goods[] RepairGoods { get => repair_goods; }

        public short Search { get => search; private set => search = value; }

        public void Repair()
        {
            throw new System.NotImplementedException();
        }
    }

    class Lighter : Tool
    {
        public Lighter(ItemTag tag, string name, float weight, string path, short durability)
             : base(tag, name, weight, path, durability)
        {

        }
    }
}