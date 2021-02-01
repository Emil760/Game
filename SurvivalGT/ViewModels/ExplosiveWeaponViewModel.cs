using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class ExplosiveWeaponViewModel
    {
        public ExplosiveWeaponViewModel(Loot loot)
        {
            Loot = loot;
            WeaponViewModel = new WeaponViewModel(loot);
        }

        public Loot Loot { get; }
        public WeaponViewModel WeaponViewModel { get; }
    }
}
