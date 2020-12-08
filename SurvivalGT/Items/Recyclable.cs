using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Recyclable : Item
    {
        private Loot[] input;
        private Loot[] output;

        public Recyclable(ItemTag tag, string name, int weight, string path, Loot[] output, Loot[] input)
            : base(tag, name, weight, path)
        {
            Output = output;
            Input = input;
        }

        public Loot[] Output { get => output; set => Set(ref output, value); }
        public Loot[] Input { get => input; set => Set(ref input, value); }
    }

    //class Recycleable : Item
    //{
    //    private ItemTag[] outputs;
    //    private ItemTag[] tools;

    //    public Recycleable(ItemTag tag, string name, int weight, string path, ItemTag[] outputs, ItemTag[] tools)
    //        : base(tag, name, weight, path)
    //    {
    //        Outputs = outputs;
    //        Tools = tools;
    //    }

    //    public ItemTag[] Outputs { get => outputs; set => outputs = value; }
    //    public ItemTag[] Tools { get => tools; set => tools = value; }
    //}
}
