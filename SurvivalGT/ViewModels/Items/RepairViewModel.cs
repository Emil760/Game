using SurvivalGT.Interfacies;
using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    public class RepairViewModel : ObserableObject
    {
        private ILoot loot;
        private IRepairable repairable;
        private ObservableCollection<CraftItem> repairs;

        public RepairViewModel(ILoot loot)
        {
            RepairCommand = new Command(Repair);

            Player = Player.Instance;
            Loot = loot;
            repairable = loot.Item as IRepairable;

            Repairs = new ObservableCollection<CraftItem>();
            GetRepairs();
        }

        public ICommand RepairCommand { get; }
        public ILoot Loot { get => loot; set => Set(ref loot, value); }
        public Player Player { get; }
        public ObservableCollection<CraftItem> Repairs { get => repairs; set => repairs = value; }

        public void Repair(object param)
        {
            CraftItem[] crafts = new CraftItem[Repairs.Count];
            Repairs.CopyTo(crafts, 0);
            repairable.Repair(Player.Inventory, crafts);
            for (int i = 0; i < crafts.Length; i++)
                if (crafts[i].Loot is LootOption) ((LootOption)crafts[i].Loot).CheckOptionsCount();
        }

        private void GetRepairs()
        {
            foreach (var repair in repairable.RepairGoods)
            {
                ILoot loot = Player.Inventory[repair.Tag];
                if (loot == null) loot = ItemFactory.GetItem(repair.Tag).GetLoot(0);
                Repairs.Add(new CraftItem(loot, repair.Count));
            }
        }
    }

}
