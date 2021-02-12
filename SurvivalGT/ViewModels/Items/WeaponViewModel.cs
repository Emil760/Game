using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class WeaponViewModel
    {
        public WeaponViewModel(ILoot lootb, bool is_info)
        {
            ItemViewModel = new ItemViewModel(loot, is_info);
        }

        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
    }
}
