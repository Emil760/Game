using SurvivalGT.Models;
using SurvivalGT.Utility;

namespace SurvivalGT.ViewModels
{
    class ToolViewModel : ObserableObject
    {
        private Loot loot;

        public ToolViewModel(Loot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
        }

        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public Loot Loot { get => loot; set => Set(ref loot, value); }
    }
}
