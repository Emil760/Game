using SurvivalGT.Models;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class FoodViewModel
    {
        public FoodViewModel(Loot loot)
        {
            Player = Player.Instance;
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
        }

        public ICommand ConsumeCommand { get; }

        public Player Player { get; }
        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }

        public void Consume(object param)
        {

        }
    }
}
