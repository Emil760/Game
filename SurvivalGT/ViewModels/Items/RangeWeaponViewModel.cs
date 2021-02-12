using SurvivalGT.Items;
using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class RangeWeaponViewModel : ItemViewModel
    {
        public RangeWeaponViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Loot = loot;
            Player = Player.Instance;
            WeaponViewModel = new WeaponViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);

            ItemTag tag = (loot.Item as RangeWeapon).Ammo;
            Ammo = new LootItem(ItemFactory.GetItem(tag), Player.Inventory.GetCount(tag));
        }

        public Player Player { get; }
        public ILoot Loot { get; }
        public WeaponViewModel WeaponViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
        public ILoot Ammo { get; }
    }
}
