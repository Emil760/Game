using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class BagViewModel : ItemViewModel
    {
        public BagViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            RepairViewModel = new RepairViewModel(loot, is_info);
            EquipViewModel = new EquipViewModel(Loot, is_info);
        }

        public RepairViewModel RepairViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
