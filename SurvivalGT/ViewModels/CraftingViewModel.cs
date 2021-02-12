using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Timers;
using System.Windows;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class CraftViewModel : ObserableObject
    {
        private Crafter crafter;
        private ObservableCollection<CraftItem> inputs;
        private ObservableCollection<Craft> crafts;
        private Visibility craft_visibility;
        private int craft_time;

        public CraftViewModel()
        {
            Player = Player.Instance;
            Crafter = new Crafter();

            CraftTime = 154;

            crafts = new ObservableCollection<Craft>();
            foreach (var item in crafter.Crafts)
                crafts.Add(item);

            CraftChangedCommand = new Command(CraftChanged);

            ActivateCraftCommand = new Command(ActivateCraft);

            //
            Inputs = new ObservableCollection<CraftItem>();
        }

        public Player Player { get; }
        public Crafter Crafter { get => crafter; private set => Set(ref crafter, value); }
        public ObservableCollection<Craft> Crafts { get => crafts; set => Set(ref crafts, value); }
        public ObservableCollection<CraftItem> Inputs { get => inputs; set => Set(ref inputs, value); }
        public Visibility CraftVisibility { get => craft_visibility; set => Set(ref craft_visibility, value); }
        public int CraftTime { get => craft_time; set => Set(ref craft_time, value); }

        public ICommand CraftCommand { get; }
        public ICommand CraftChangedCommand { get; }
        public ICommand CraftCountChangedCommand { get; }
        public ICommand ActivateCraftCommand { get; }

        public ICommand FoodCraftCommand { get; }
        public ICommand MedecineCraftCommand { get; }
        public ICommand WeapondCraftCommand { get; }
        public ICommand ArmorCraftCommand { get; }
        public ICommand TransportCraftCommand { get; }
        public ICommand ToolCraftCommand { get; }
        public ICommand ComponetsCraftCommand { get; }

        public void CraftChanged(object param)
        {
            Inputs.Clear();
            foreach (var item in crafter.SelectedCraft.Inputs)
            {
                ILoot loot = crafter.Player.Inventory[item.Item.Tag];
                if (loot == null) loot = ItemFactory.GetItem(item.Item.Tag).GetLoot();
                Inputs.Add(new CraftItem(loot, item.Count));
            }
            crafter.CraftChanged(Inputs);
        }

        public void CraftCountChaged(object param)
        {
            var it = inputs.GetEnumerator();
            foreach (var item in crafter.SelectedCraft.Inputs)
            {
                it.Current.Count = item.Count * crafter.CraftCount;
                it.MoveNext();
            }
        }

        public void ActivateCraft(object param)
        {
            System.Console.WriteLine("aaa");
            //System.Console.WriteLine(crafter.SelectedCraft.Outputs[0].Item.Name);
        }
    }

    class Crafter : ObserableObject
    {
        private static LinkedList<Craft> crafts;
        private Timer timer;
        private int craft_count;
        private int max_count;
        private int progress_count;
        private Craft selected_craft;

        static Crafter()
        {
            crafts = new LinkedList<Craft>();

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Wood).GetLoot(2), ItemFactory.GetItem(ItemTag.Nail).GetLoot(5) },
                new ILoot[] { ItemFactory.GetItem(ItemTag.Club).GetLoot(1) }, ItemType.Weapon, 1, 2, 50, false, true));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Cloth).GetLoot(15), ItemFactory.GetItem(ItemTag.String).GetLoot(30), ItemFactory.GetItem(ItemTag.PreparedSkin).GetLoot(10), ItemFactory.GetItem(ItemTag.Tire).GetLoot(5), ItemFactory.GetItem(ItemTag.Needle).GetLoot(1) },
                new ILoot[] { ItemFactory.GetItem(ItemTag.MotorwayArmor).GetLoot(1) }, ItemType.Armor, 1, 3, 50, false, true));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Water).GetLoot(2), ItemFactory.GetItem(ItemTag.Coal).GetLoot(5) },
                new ILoot[] { ItemFactory.GetItem(ItemTag.ActivatedCarbon).GetLoot(5) }, ItemType.Medecine, 2, 4, 50));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.FreshMeat).GetLoot(1) },
                new ILoot[] { ItemFactory.GetItem(ItemTag.FriedMeat).GetLoot(1) }, ItemType.Food, 2, 5, 50));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Wood).GetLoot(1), ItemFactory.GetItem(ItemTag.Cloth).GetLoot(3), ItemFactory.GetItem(ItemTag.Gas).GetLoot(500) },
                new ILoot[] { ItemFactory.GetItem(ItemTag.Torch).GetLoot(1) }, ItemType.Tool, 3, 1, 50));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Wood).GetLoot(1), ItemFactory.GetItem(ItemTag.Cloth).GetLoot(3), ItemFactory.GetItem(ItemTag.Gas).GetLoot(500) },
               new ILoot[] { ItemFactory.GetItem(ItemTag.Torch).GetLoot(1) }, ItemType.Tool, 2, 1, 50));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Wood).GetLoot(1), ItemFactory.GetItem(ItemTag.Cloth).GetLoot(3), ItemFactory.GetItem(ItemTag.Gas).GetLoot(500) },
               new ILoot[] { ItemFactory.GetItem(ItemTag.Torch).GetLoot(1) }, ItemType.Tool, 1, 3, 50));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Wood).GetLoot(1), ItemFactory.GetItem(ItemTag.Cloth).GetLoot(3), ItemFactory.GetItem(ItemTag.Gas).GetLoot(500) },
               new ILoot[] { ItemFactory.GetItem(ItemTag.Torch).GetLoot(1) }, ItemType.Tool, 3, 2, 50));

            crafts.AddLast(new Craft(new ILoot[] { ItemFactory.GetItem(ItemTag.Wood).GetLoot(1), ItemFactory.GetItem(ItemTag.Cloth).GetLoot(3), ItemFactory.GetItem(ItemTag.Gas).GetLoot(500) },
               new ILoot[] { ItemFactory.GetItem(ItemTag.Torch).GetLoot(1) }, ItemType.Tool, 5, 2, 50));
        }

        public Crafter()
        {
            Player = Player.Instance;
        }

        public Player Player { get; }
        public int CraftCount { get => CraftCount; set => Set(ref craft_count, value); }
        public int MaxCount { get => max_count; set => Set(ref max_count, value); }
        public int ProgressCount { get => progress_count; set => Set(ref progress_count, value); }
        public Craft SelectedCraft { get => selected_craft; set => Set(ref selected_craft, value); }
        public LinkedList<Craft> Crafts { get => crafts; }

        public int Check()
        {
            int num = 0;
            max_count = Player.Inventory[selected_craft.Inputs[0].Item.Tag].Count / selected_craft.Inputs[0].Count;
            for (int i = 1; i < selected_craft.Inputs.Length; i++)
            {
                num = Player.Inventory[selected_craft.Inputs[i].Item.Tag].Check(num, selected_craft.Inputs[i].Count, selected_craft.Time);
                if (max_count > num) max_count = num;
            }
            return num;
        }

        public int Check(IEnumerable<CraftItem> inputs)
        {
            int num = 0, temp = 0;
            var it = inputs.GetEnumerator();
            num = it.Current.Loot.Check(it.Current.Count, it.Current.Loot.Count, selected_craft.Time);
            while (it.MoveNext())
            {
                temp = it.Current.Loot.Check(it.Current.Count, it.Current.Loot.Count, selected_craft.Time);
                if (temp < num) num = temp;
            }
            return num;
        }

        public void CraftChanged()
        {
            //CraftCount = 0;
            MaxCount = Check();
        }

        public void CraftChanged(IEnumerable<CraftItem> inputs)
        {
            //CraftCount = 0;
            //MaxCount = Check(inputs);
        }

    }
}
