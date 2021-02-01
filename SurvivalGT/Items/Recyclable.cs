using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Recycleable : Item
    {
        private LootRandom[] outputs;

        public Recycleable(ItemTag tag, ItemType type, string name, float weight, string path, LootRandom[] outputs)
            : base(tag, type, name, weight, path)
        {
            this.outputs = outputs;
        }

        public LootRandom[] Outputs { get => outputs; }

        //public Loot[] Recycle()
        //{
        //    Loot[] loots = new Loot[outputs.Length];
        //    for (int i = 0; i < outputs.Length; i++)
        //        loots[i] = outputs[i].GetLoot();
        //    return loots;
        //}
    }

    class RecycleableComplex : Recycleable
    {
        private ItemTag tool;

        public RecycleableComplex(ItemTag tag, ItemType type, string name, float weight, string path, ItemTag tool, LootRandom[] outputs)
            : base(tag, type, name, weight, path, outputs)
        {
            this.tool = tool;
        }

        public ItemTag Tool { get; }
    }
}
