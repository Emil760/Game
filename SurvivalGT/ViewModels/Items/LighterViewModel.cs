using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class LighterViewModel : ItemViewModel
    {
        public LighterViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
            MakeFireCommand = new Command(MakeFire);

            //CraftItem = new CraftMaterial(ItemFactory.GetItem(ItemTag.Wood), 10, Player.Inventory.GetMaterial(ItemTag.Wood));
        }

        public ICommand MakeFireCommand { get; }

        public Player Player { get; }
        //public CraftItem CraftItem { get; }

        private void MakeFire(object param)
        {

        }
    }
}
