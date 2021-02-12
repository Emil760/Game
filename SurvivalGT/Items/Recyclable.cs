using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Recycleable : Item
    {
        protected LootRandom[] outputs;
        protected int time;

        public Recycleable(ItemTag tag, ItemType type, string name, float weight, string path, int time, LootRandom[] outputs)
            : base(tag, type, name, weight, path)
        {
            this.time = time;
            this.outputs = outputs;
        }

        public LootRandom[] Outputs { get => outputs; }
        public int Time { get => time; }

        public virtual ILoot[] Recycle(Inventory inventory)
        {
            return null;
        }

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
        private ItemTag[] inputs;

        public RecycleableComplex(ItemTag tag, ItemType type, string name, float weight, string path, int time, ItemTag[] inputs, LootRandom[] outputs)
            : base(tag, type, name, weight, path, time, outputs)
        {
            this.inputs = inputs;
        }

        public ItemTag[] Inputs { get => inputs; }

        public override ILoot[] Recycle(Inventory inventory)
        {
            return null;
        }
    }
}
