using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    public class ItemViewModel
    {
        public ItemViewModel(Loot loot)
        {
            Loot = loot;
        }

        public Loot Loot { get; }
    }
}
