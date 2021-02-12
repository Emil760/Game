using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class WeaponViewModel
    {
        public WeaponViewModel(ILoot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
        }

        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
    }
}
