using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.Views;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class FishingrodViewModel
    {
        public FishingrodViewModel(Loot loot)
        {
            CatchFishCommand = new Command(CatchFish);

            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);    
        }

        public ICommand CatchFishCommand { get; }

        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public RepairViewModel RepairViewModel { get; }

        public void CatchFish(object param)
        {
            BaitWindow window = new BaitWindow();
            window.DataContext = new BaitViewModel(Loot.Item as Fishingrod);
            window.ShowDialog();
        }

    }
}
