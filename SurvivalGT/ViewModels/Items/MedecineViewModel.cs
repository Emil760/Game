using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class MedecineViewModel
    {
        public MedecineViewModel(ILoot loot)
        {
            ConsumeCommand = new Command(Consume);

            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
        }

        public ICommand ConsumeCommand { get; }

        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }

        private void Consume(object sender)
        {

        }
    }
}
