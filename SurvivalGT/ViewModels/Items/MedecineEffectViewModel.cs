using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class MedecineEffectViewModel
    {
        public MedecineEffectViewModel(ILoot loot)
        {
            Loot = loot;
            ConsumeCommand = new Command(Consume);
            ItemViewModel = new ItemViewModel(loot);
        }

        public ICommand ConsumeCommand { get; }

        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }

        public void Consume(object param)
        {

        }
    }
}
