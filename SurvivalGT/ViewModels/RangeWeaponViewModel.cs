using SurvivalGT.Items;
using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class RangeWeaponViewModel
    {
        public RangeWeaponViewModel(Loot loot)
        {
            Loot = loot;
            Player = Player.Instance;
            WeaponViewModel = new WeaponViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);

            ItemTag tag = (loot.Item as RangeWeapon).Ammo;
            Loot ammo = Player.Inventory.GetMaterial(tag);
            if (ammo == null) Ammo = new Loot(ItemFactory.GetItem(tag), 0);
            else Ammo = ammo;
        }

        public Player Player { get; }
        public Loot Loot { get; }
        public WeaponViewModel WeaponViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
        public Loot Ammo { get; }
    }
}
