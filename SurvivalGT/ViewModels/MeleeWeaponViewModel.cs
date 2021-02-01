using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class MeleeWeaponViewModel
    {
        public MeleeWeaponViewModel(Loot loot)
        {
            Loot = loot;
            WeaponViewModel = new WeaponViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
        }

        public Loot Loot { get; }
        public WeaponViewModel WeaponViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
    }
}
