using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class LighterViewModel
    {
        public LighterViewModel(ILoot loot)
        {
            Player = Player.Instance;
            MakeFireCommand = new Command(MakeFire);
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);

            //CraftItem = new CraftMaterial(ItemFactory.GetItem(ItemTag.Wood), 10, Player.Inventory.GetMaterial(ItemTag.Wood));
        }

        public ICommand MakeFireCommand { get; }

        public Player Player { get; }
        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        //public CraftItem CraftItem { get; }

        private void MakeFire(object param)
        {

        }
    }
}
