using SurvivalGT.Items;
using SurvivalGT.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SurvivalGT.Models
{
    public class Inventory : ObserableObject
    {
        public delegate void FilterType(Loot loot);
        public delegate int SortType(ObservableCollection<Loot> array, int start, int end);

        private Dictionary<ItemTag, Loot> all_loots;
        private ObservableCollection<Loot> loots;
        private Loot selected_loot;

        private FilterType filter;
        private SortType sort;

        public Inventory()
        {
            AllLoots = new Dictionary<ItemTag, Loot>();
            Loots = new ObservableCollection<Loot>();
            Filter = FilterAll;
            Sort = SortByCount;
        }

        public Loot this[ItemTag index]
        {
            get
            {
                try
                {
                    return all_loots[index];
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
            }
        }

        public Dictionary<ItemTag, Loot> AllLoots { get => all_loots; set => all_loots = value; }
        public ObservableCollection<Loot> Loots { get => loots; set => Set(ref loots, value); }
        public Loot SelectedLoot { get => selected_loot; set => Set(ref selected_loot, value); }
        public FilterType Filter { get => filter; set => filter = value; }
        public SortType Sort { get => sort; set => sort = value; }

        public Inventory DropAll()
        {
            throw new NotImplementedException();
        }

        public void Take(Loot loot)
        {
            loot.Take(this);
        }

        public Loot Drop()
        {
            throw new System.NotImplementedException();
        }

        public void TakeCount(int count, Loot loot)
        {

        }

        public Loot DropCount(int count)
        {
            throw new NotImplementedException();
        }

        public LinkedList<Loot> GetOption(ItemTag tag)
        {
            LinkedList<Loot> options = new LinkedList<Loot>();
            foreach (var loot in all_loots)
            {
                if (loot.Value.Item is OptionTool)
                    if (((OptionTool)loot.Value.Item).Option == tag)
                        options.AddLast(loot.Value);
            }
            return options;
        }

        public Loot GetMaterial(ItemTag tag)
        {
            try
            {
                return all_loots[tag];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public bool Check(ItemTag tag, int use_count = 1)
        {
            try
            {
                if (all_loots[tag].Count < use_count) return false;
                else return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //throws exceptions if nothing is found (always check)
        public void Use(ItemTag tag, int use_count)
        {
            all_loots[tag].Use(use_count, this);
        }

        // поменять
        public void FilterAll(Loot loot1)
        {
            loots.Clear();
            foreach (var loot in AllLoots)
                loots.Add(loot.Value);
            SortLoot();
        }

        public void FilterFood(Loot loot)
        {
            if (loot.Item is Item || loot.Item is Item)
            {
                loots.Add(loot);
                SortLoot();
            }
        }

        public void FilterMedecine(Loot loot)
        {
            if (loot.Item is Medecine)
            {
                loots.Add(loot);
                SortLoot();
            }

        }

        public void FilterComponent(Loot loot)
        {
            if (loot.Item.GetType() == typeof(Item))
            {
                loots.Add(loot);
                SortLoot();
            }
        }

        public void FilterUtility(Loot loot)
        {
            if (loot.Item is GasMask || loot.Item is Bag || loot.Item is Tool || loot.Item is Armor)
            {
                loots.Add(loot);
                SortLoot();
            }
        }

        public void FilterWeapon(Loot loot)
        {
            if (loot.Item is Weapon)
            {
                loots.Add(loot);
                SortLoot();
            }
        }

        public void SortLoot()
        {
            Quicksort(loots, 0, loots.Count - 1);
        }

        public int SortByCount(ObservableCollection<Loot> array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i].Count <= array[end].Count)
                {
                    var temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        public int SortByWeight(ObservableCollection<Loot> array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i].Count * array[i].Item.Weight <= array[end].Count * array[end].Item.Weight)
                {
                    var temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        private void Quicksort(ObservableCollection<Loot> array, int start, int end)
        {
            if (start >= end) return;
            int pivot = sort.Invoke(loots, start, loots.Count - 1);
            Quicksort(array, start, pivot - 1);
            Quicksort(array, pivot + 1, end);
        }
    }

}