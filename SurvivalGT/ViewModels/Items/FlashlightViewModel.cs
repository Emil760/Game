using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class FlashlightViewModel : LightViewModel
    {
        public FlashlightViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
            RepairViewModel = new RepairViewModel(loot, is_info);
        }

        public Player Player { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
