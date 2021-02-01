using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    public class RepairViewModel : ObserableObject
    {
        private Loot loot;
        private ObservableCollection<CraftItem> repair_crafts;
        private CraftMaterial[] lootCraftMaterials;
        private CraftOption[] lootCraftOptions;

        public RepairViewModel(Loot loot)
        {
            RepairCommand = new Command(Repair);

            Player = Player.Instance;
            RepairCrafts = new ObservableCollection<CraftItem>();
            Loot = loot;
            GetRepairs();
        }

        public ICommand RepairCommand { get; }
        public Loot Loot { get => loot; set => Set(ref loot, value); }
        public Player Player { get; }
        public ObservableCollection<CraftItem> RepairCrafts { get => repair_crafts; set => Set(ref repair_crafts, value); }

        public void Repair(object param)
        {
            for (int i = 0; i < lootCraftMaterials.Length; i++)
            {
                System.Console.WriteLine(lootCraftMaterials[i].Loot.Item.Name + "\t" + lootCraftMaterials[i].Loot.Count);
            }

            IRepairable repairable = (IRepairable)loot.Item;
            repairable.Repair(Player.Inventory, lootCraftMaterials, lootCraftOptions);
            //((IRepairable)loot.Item).Repair(Player.Inventory);
            //for (int i = 0; i < repair_crafts.Count; i++)
            //{
            //    if (repair_crafts[i] is LootCraftOption)
            //    {
            //        LootCraftOption option = (LootCraftOption)repair_crafts[i];
            //        if (((IBreakable)option.Loots.First.Value.Item).CurrentDurability == 0)
            //            option.Loots.RemoveFirst();
            //    }
            //}
        }

        private void GetRepairs()
        {
            IRepairable repairable = (IRepairable)loot.Item;
            lootCraftMaterials = new CraftMaterial[repairable.RepairMaterials.Length];
            lootCraftOptions = new CraftOption[repairable.RepairOptions.Length];

            for (int i = 0; i < repairable.RepairMaterials.Length; i++)
            {
                lootCraftMaterials[i] = new CraftMaterial(ItemFactory.GetItem(repairable.RepairMaterials[i].Tag), repairable.RepairMaterials[i].Count, Player.Inventory.GetMaterial(repairable.RepairMaterials[i].Tag));
                RepairCrafts.Add(lootCraftMaterials[i]);
            }
            for (int i = 0; i < repairable.RepairOptions.Length; i++)
            {
                lootCraftOptions[i] = new CraftOption(ItemFactory.GetItem(repairable.RepairOptions[i]), Player.Inventory.GetOption(repairable.RepairOptions[i]));
                RepairCrafts.Add(lootCraftOptions[i]);
            }
        }
    }

}
