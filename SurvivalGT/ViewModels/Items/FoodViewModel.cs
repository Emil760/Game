using SurvivalGT.Models;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class FoodViewModel
    {
        public FoodViewModel(ILoot loot)
        {
            Player = Player.Instance;
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
        }

        public ICommand ConsumeCommand { get; }

        public Player Player { get; }
        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }

        public void Consume(object param)
        {

        }
    }
}
