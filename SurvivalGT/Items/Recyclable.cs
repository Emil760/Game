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

        public LootRandom[] Outputs { get => outputs; set => outputs = value; }

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
        private Loot[] inputs;

        public RecycleableComplex(ItemTag tag, ItemType type, string name, float weight, string path, Loot[] inputs, LootRandom[] outputs)
            : base(tag, type, name, weight, path, outputs)
        {
            this.inputs = inputs;
        }

        public Loot[] Inputs { get => inputs; set => inputs = value; }
    }
}
