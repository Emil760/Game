using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.Views;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class FishingrodViewModel : ItemViewModel
    {
        public FishingrodViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            CatchFishCommand = new Command(CatchFish);

            RepairViewModel = new RepairViewModel(loot, is_info);
        }

        public ICommand CatchFishCommand { get; }

        public RepairViewModel RepairViewModel { get; }

        public void CatchFish(object param)
        {
            BaitWindow window = new BaitWindow();
            window.DataContext = new BaitViewModel(Loot.Item as Fishingrod);
            window.ShowDialog();
        }

    }
}
