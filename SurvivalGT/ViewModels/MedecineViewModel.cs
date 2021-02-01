using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class MedecineViewModel
    {
        public MedecineViewModel(Loot loot)
        {
            ConsumeCommand = new Command(Consume);

            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
        }

        public ICommand ConsumeCommand { get; }

        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }

        private void Consume(object sender)
        {

        }
    }
}
