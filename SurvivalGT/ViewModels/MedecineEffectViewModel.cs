using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class MedecineEffectViewModel
    {
        public MedecineEffectViewModel(Loot loot)
        {
            Loot = loot;
            ConsumeCommand = new Command(Consume);
            ItemViewModel = new ItemViewModel(loot);
        }

        public ICommand ConsumeCommand { get; }

        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }

        public void Consume(object param)
        {

        }
    }
}
