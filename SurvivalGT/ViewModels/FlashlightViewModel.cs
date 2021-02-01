using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class FlashlightViewModel
    {
        public FlashlightViewModel(Loot loot)
        {
            Player = Player.Instance;
            Loot = loot;
            LightViewModel = new LightViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public Player Player { get; }
        public Loot Loot { get; }
        public LightViewModel LightViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
