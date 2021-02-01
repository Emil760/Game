using SurvivalGT.Models;
using SurvivalGT.Utility;

namespace SurvivalGT.ViewModels
{
    public class BreakableViewModel : ObserableObject
    {
        public BreakableViewModel(Loot loot)
        {
            Loot = loot;
        }

        public Loot Loot { get; }
    }
}
