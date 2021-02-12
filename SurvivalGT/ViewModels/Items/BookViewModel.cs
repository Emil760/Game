using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class BookViewModel : ItemViewModel
    {
        public BookViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
            ReadCommand = new Command(Read);
        }

        public ICommand ReadCommand { get; }

        public Player Player { get; }

        private void Read(object param)
        {

        }
    }
}
