using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class LighterViewModel
    {
        public LighterViewModel(Loot loot)
        {
            Player = Player.Instance;
            MakeFireCommand = new Command(MakeFire);
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);

            CraftItem = new CraftMaterial(ItemFactory.GetItem(ItemTag.Wood), 10, Player.Inventory.GetMaterial(ItemTag.Wood));
        }

        public ICommand MakeFireCommand { get; }

        public Player Player { get; }
        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public CraftItem CraftItem { get; }

        private void MakeFire(object param)
        {

        }
    }
}
