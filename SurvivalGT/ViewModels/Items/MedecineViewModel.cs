using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class MedecineViewModel    : ItemViewModel
    {
        public MedecineViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            ConsumeCommand = new Command(Consume);
        }

        public ICommand ConsumeCommand { get; }

        private void Consume(object sender)
        {

        }
    }
}
