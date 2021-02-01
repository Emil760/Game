using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class GasMaskViewModel
    {
        public GasMaskViewModel(Loot loot)
        {
            Loot = loot;
            MaskViewModel = new MaskViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public Loot Loot { get; }
        public MaskViewModel MaskViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
