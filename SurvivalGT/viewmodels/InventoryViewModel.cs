using SurvivalGT.InfoUC;
using SurvivalGT.Interfacies;
using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.ViewModels.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class InventoryViewModel : ObserableObject
    {
        private UserControl info_uc;
        private ILoot selected_loot;
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

            LinkedList<int> vs = new LinkedList<int>();
            vs.AddLast(5040);
            LinkedList<int> vs1 = new LinkedList<int>();
            vs1.AddLast(100);

            Loots = new ObservableCollection<ILoot>();
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Acid), 10));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.BeefCan), 5, vs));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.Ak47), 1, vs1));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.Berdish), 1, vs1));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.SteelAxe), 1, vs1));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Bryocarm), 1));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.Vodka), 1, vs1));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Grenade), 5));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.ActivatedCarbon), 20));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.HealingSalve), 3));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.Lighter), 2, vs1));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.RiceCutlet), 5, vs));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.Flashlight), 1, vs1));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Scrap), 1100));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.FreshMeat), 5, vs));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.FreshSnake), 2, vs));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.MotorwayArmor), 1, vs1));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.Needle), 2, vs1));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.SteelNeedle), 1, vs1));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Tire), 10));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.String), 1000));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Wire), 15));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.FishingRod), 1, vs1));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.Suitcase), 1, vs));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Book), 3));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.Torch), 2, vs));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.HandmadeRespirator), 1, vs1));
            Loots.Add(new LootSpoil(ItemFactory.GetItem(ItemTag.Gasmask3), 1, vs1));
            Loots.Add(new LootBreak(ItemFactory.GetItem(ItemTag.Zaz), 1, vs));
            //Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.BrockenZaz), 1));
            Loots.Add(new LootItem(ItemFactory.GetItem(ItemTag.Cloth), 4));

            foreach (var item in Loots)
            {
                Player.Inventory.AllLoots.Add(item.Item.Tag, item);
                if (item.Item is IBreakable)
                {
                    IBreakable breakable = item.Item as IBreakable;
                    breakable.CurrentDurability = 15;
                }
            }
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

        public Player Player { get; }
        public UserControl InfoUC { get => info_uc; set => Set(ref info_uc, value); }

        public ObservableCollection<ILoot> Loots { get; set; }
        public ILoot SelectedLoot { get => selected_loot; set => Set(ref selected_loot, value); }

        public int MaxCount { get => max_count; set => Set(ref max_count, value); }
        public int DropCount { get => drop_count; set => Set(ref drop_count, value); }

        private void ItemChanged(object param)
        {
            string item = SelectedLoot.Item.GetType().Name;
            if (item.Contains("Tool"))
            {
                InfoUC = new ToolUC();
                InfoUC.DataContext = new ToolViewModel(SelectedLoot);
            }
            else
            {
                Type type = Type.GetType($"SurvivalGT.InfoUC.{item}UC", false, false);
                InfoUC = (UserControl)Activator.CreateInstance(type);
                type = Type.GetType("SurvivalGT.ViewModels.Items." + item + "ViewModel");
                InfoUC.DataContext = Activator.CreateInstance(type, SelectedLoot);
            }
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
