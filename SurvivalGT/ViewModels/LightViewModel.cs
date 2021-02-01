using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class LightViewModel
    {
        public LightViewModel(Loot loot)
        {
            Player = Player.Instance;
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
        }

        public Player Player { get; }
        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
