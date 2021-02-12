using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class TransportViewModel : ItemViewModel
    {
        public TransportViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            EquipViewModel = new EquipViewModel(loot, is_info);
            RepairViewModel = new RepairViewModel(loot, is_info);
        }

        public EquipViewModel EquipViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
