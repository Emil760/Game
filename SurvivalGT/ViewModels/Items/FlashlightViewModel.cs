using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class FlashlightViewModel : ItemViewModel
    {
        public FlashlightViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
            LightViewModel = new LightViewModel(loot, is_info);
            RepairViewModel = new RepairViewModel(Loot, is_info);
        }

        public Player Player { get; }
        public LightViewModel LightViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
