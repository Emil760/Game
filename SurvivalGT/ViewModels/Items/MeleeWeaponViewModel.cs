using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class MeleeWeaponViewModel
    {
        public MeleeWeaponViewModel(ILoot loot)
        {
            Loot = loot;
            WeaponViewModel = new WeaponViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
        }

        public ILoot Loot { get; }
        public WeaponViewModel WeaponViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
    }
}
