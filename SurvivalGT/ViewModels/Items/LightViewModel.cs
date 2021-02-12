using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class LightViewModel : ItemViewModel
    {
        public LightViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
            EquipViewModel = new EquipViewModel(loot, is_info);
        }

        public Player Player { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
