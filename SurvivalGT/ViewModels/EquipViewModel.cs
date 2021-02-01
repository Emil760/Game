using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    public class EquipViewModel : ObserableObject
    {
        public EquipViewModel(Loot loot)
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
