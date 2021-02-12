using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class FlashlightViewModel
    {
        public FlashlightViewModel(ILoot loot)
        {
            Player = Player.Instance;
            Loot = loot;
            LightViewModel = new LightViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public Player Player { get; }
        public ILoot Loot { get; }
        public LightViewModel LightViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
