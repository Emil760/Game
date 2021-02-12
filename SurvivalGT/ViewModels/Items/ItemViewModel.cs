using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    public class ItemViewModel
    {
        public ItemViewModel(ILoot loot)
        {
            Loot = loot;
        }

        public ILoot Loot { get; }
    }
}
