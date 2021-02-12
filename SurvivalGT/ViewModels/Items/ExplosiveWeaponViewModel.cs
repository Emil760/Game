using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class ExplosiveWeaponViewModel
    {
        public ExplosiveWeaponViewModel(ILoot loot)
        {
            Loot = loot;
            WeaponViewModel = new WeaponViewModel(loot);
        }

        public ILoot Loot { get; }
        public WeaponViewModel WeaponViewModel { get; }
    }
}
