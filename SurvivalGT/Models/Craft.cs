using SurvivalGT.Items;

namespace SurvivalGT.Models
{
    class Craft
    {
        static Craft[] crafts;
        Loot output;
        ItemTag[] inputs;
        ItemTag[] tools;

        static Craft()
        {
            crafts = new Craft[200];
        }

        public Craft(Loot output, ItemTag[] inputs, ItemTag[] tools)
        {
            Output = output;
            Inputs = inputs;
            Tools = tools;
        }

        public Loot Output { get => output; private set => output = value; }
        public ItemTag[] Inputs { get => inputs; private set => inputs = value; }
        public ItemTag[] Tools { get => tools; private set => tools = value; }

        public Loot Make(Loot[] loots)
        {
            return output;
        }
    }
}
