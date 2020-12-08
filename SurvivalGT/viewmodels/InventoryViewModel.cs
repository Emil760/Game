using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.InfoUC;

namespace SurvivalGT.viewmodels
{
    class InventoryViewModel : ObserableObject
    {
        private Player player;
        private UserControl info_uc;

        public InventoryViewModel()
        {
            ItemChangedCommand = new Command(ItemChanged);

            Player = Player.Instance;
            player.Inventory.Take(new Loot(ItemFactory.GetItem(ItemTag.Bone), 10));
            player.Inventory.Take(new Loot(ItemFactory.GetItem(ItemTag.Bone), 10));
            player.Inventory.Take(new Loot(ItemFactory.GetItem(ItemTag.Akumulator), 5));
            LinkedList<int> ts1 = new LinkedList<int>();
            ts1.AddLast(123);
            player.Inventory.Take(new LootBreak(ItemFactory.GetItem(ItemTag.Axe), 1, ts1));
            LinkedList<int> ts2 = new LinkedList<int>();
            ts2.AddLast(56);
            player.Inventory.Take(new LootBreak(ItemFactory.GetItem(ItemTag.Ak47), 1, ts2));
        }

        public ICommand ItemChangedCommand { get; }

        public Player Player { get => player; private set => Set(ref player, value); }
        public UserControl InfoUC { get => info_uc; set => Set(ref info_uc, value); }

        public void ItemChanged(object param)
        {
            if (player.Inventory.SelectedLoot.Item is IRepairable)
            {
                CraftItem[] crafts = new CraftItem[(player.Inventory.SelectedLoot as IRepairable).RepairLoots.Length];
                for (int i = 0; i < crafts.Length; i++)
                    crafts[i] = new CraftItem((player.Inventory.SelectedLoot as IRepairable).RepairLoots[i].Count, player.Inventory.SelectedLoot);

                if (player.Inventory.SelectedLoot.Item is RangeWeapon) InfoUC = new WeaponUC(crafts);
            }
            else if (player.Inventory.SelectedLoot.Item is ISpoilable)
            {

            }
            else
            {
                if (player.Inventory.SelectedLoot.Item is Tool) InfoUC = new ToolUC();
                else if (player.Inventory.SelectedLoot.Item is Item) InfoUC = new ComponentUC();
            }

            InfoUC.DataContext = player.Inventory.SelectedLoot;
        }
    }
}
