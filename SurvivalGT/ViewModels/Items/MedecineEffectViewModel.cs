using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class MedecineEffectViewModel : ItemViewModel
    {
        public MedecineEffectViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            ConsumeCommand = new Command(Consume);
        }

        public ICommand ConsumeCommand { get; }

        public void Consume(object param)
        {

        }
    }
}
