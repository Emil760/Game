using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class GasMaskViewModel : MaskViewModel
    {
        public GasMaskViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            RepairViewModel = new RepairViewModel(loot, is_info);
        }

        public RepairViewModel RepairViewModel { get; }
    }
}
