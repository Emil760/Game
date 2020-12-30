using SurvivalGT.InfoUC;
using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace SurvivalGT.viewmodels
{
    class InventoryViewModel : ObserableObject
    {
        private Player player;
        private UserControl info_uc;

        private Loot selected_loot;
        private int max_count;
        private int drop_count;

        public InventoryViewModel()
        {
            Player = Player.Instance;

            ItemChangedCommand = new Command(ItemChanged);
            OrderChangedCommand = new Command(OrderChanged);
            DropCommand = new Command(Drop);

            AllFilterCommand = new Command(AllFilter);
            FoodFilterCommand = new Command(FoodFilter);
            MedecineFilterCommand = new Command(MedecineFilter);
            ComponentsFilterCommand = new Command(ComponentsFilter);
            EquipmentFilterCommand = new Command(EquipmentFilter);
            WeaponFilterCommand = new Command(WeaponFilter);

            Loots = new ObservableCollection<Loot>();
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Acid), 10));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.BeefCan), 5));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Ak47), 1));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Berdish), 1));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.SteelAxe), 1));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Bryocarm), 1));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Vodka), 1));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Grenade), 5));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.ActivatedCarbon), 20));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.HealingSalve), 3));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Lighter), 2));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.RiceCutlet), 5));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Flashlight), 1));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Coal), 100));
            Loots.Add(new Loot(ItemFactory.GetItem(ItemTag.Scrap), 1100));
        }

        public ICommand ItemChangedCommand { get; }
        public ICommand OrderChangedCommand { get; }
        public ICommand DropCommand { get; }

        public ICommand AllFilterCommand { get; }
        public ICommand FoodFilterCommand { get; }
        public ICommand MedecineFilterCommand { get; }
        public ICommand ComponentsFilterCommand { get; }
        public ICommand EquipmentFilterCommand { get; }
        public ICommand WeaponFilterCommand { get; }

        public Player Player { get => player; private set => Set(ref player, value); }
        public UserControl InfoUC { get => info_uc; set => Set(ref info_uc, value); }

        public ObservableCollection<Loot> Loots { get; set; }
        public Loot SelectedLoot { get => selected_loot; set => Set(ref selected_loot, value); }
        public int MaxCount { get => max_count; set => Set(ref max_count, value); }
        public int DropCount { get => drop_count; set => Set(ref drop_count, value); }

        private void ItemChanged(object param)
        {
            if (SelectedLoot.Item is Tool) InfoUC = new BreakableUC(SelectedLoot);
            else InfoUC = new ItemUC(SelectedLoot);
        }

        private void OrderChanged(object param)
        {

        }

        private void Drop(object param)
        {

        }

        private void AllFilter(object param)
        {

        }

        private void FoodFilter(object param)
        {

        }

        private void MedecineFilter(object param)
        {

        }

        private void ComponentsFilter(object param)
        {

        }

        private void EquipmentFilter(object param)
        {

        }

        private void WeaponFilter(object param)
        {

        }
    }
}
