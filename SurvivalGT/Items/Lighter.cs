using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Lighter : Tool
    {
        public Lighter(ItemTag tag, string name, float weight, string path, int durability)
            : base(tag, name, weight, path, durability)
        {

        }

        public Item MakeFire(ILoot loot)
        {
            return ItemFactory.GetItem(ItemTag.Fire);
        }
    }
}
