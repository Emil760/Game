using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class WeaponViewModel
    {
        public WeaponViewModel(Loot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
        }

        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
    }
}
