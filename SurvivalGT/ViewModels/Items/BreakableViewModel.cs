using SurvivalGT.Models;
using SurvivalGT.Utility;

namespace SurvivalGT.ViewModels.Items
{
    public class BreakableViewModel : ObserableObject
    {
        public BreakableViewModel(ILoot loot)
        {
            Loot = loot;
        }

        public ILoot Loot { get; }
    }
}
