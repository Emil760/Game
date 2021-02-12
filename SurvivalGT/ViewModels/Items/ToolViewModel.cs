using SurvivalGT.Models;
using SurvivalGT.Utility;

namespace SurvivalGT.ViewModels.Items
{
    class ToolViewModel : ObserableObject
    {
        private ILoot loot;

        public ToolViewModel(ILoot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
        }

        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public ILoot Loot { get => loot; set => Set(ref loot, value); }
    }
}
