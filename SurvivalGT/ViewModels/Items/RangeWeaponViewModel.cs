using SurvivalGT.Items;
using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class RangeWeaponViewModel : ItemViewModel
    {
        public RangeWeaponViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
            RepairViewModel = new RepairViewModel(loot, is_info);

            ItemTag tag = (loot.Item as RangeWeapon).Ammo;
            Ammo = new LootItem(ItemFactory.GetItem(tag), Player.Inventory.GetCount(tag));
        }

        public Player Player { get; }
        public RepairViewModel RepairViewModel { get; }
        public ILoot Ammo { get; }
    }
}
