using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class GasMaskViewModel
    {
        public GasMaskViewModel(ILoot loot)
        {
            Loot = loot;
            MaskViewModel = new MaskViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public ILoot Loot { get; }
        public MaskViewModel MaskViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
