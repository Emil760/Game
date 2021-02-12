using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class LightViewModel
    {
        public LightViewModel(ILoot loot)
        {
            Player = Player.Instance;
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
        }

        public Player Player { get; }
        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
