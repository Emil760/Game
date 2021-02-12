using SurvivalGT.Models;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    public class EquipViewModel : ItemViewModel
    {
        public EquipViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
        }

        public ICommand EquipCommand { get; }
        public Player Player { get; }

        private void Equip(object param)
        {
            System.Console.WriteLine("equip");
        }
    }
}
