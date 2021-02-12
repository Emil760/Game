using SurvivalGT.Items;
using SurvivalGT.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SurvivalGT.Models
{
    public class Inventory : ObserableObject
    {
        public delegate void FilterType(ILoot loot);
        public delegate int SortType(ObservableCollection<ILoot> array, int start, int end);

        private Dictionary<ItemTag, ILoot> all_loots;
        private ObservableCollection<ILoot> loots;
        private ILoot selected_loot;

        private FilterType filter;
        private SortType sort;

        public Inventory()
        {
            AllLoots = new Dictionary<ItemTag, ILoot>();
            Loots = new ObservableCollection<ILoot>();
        }

        public ILoot this[ItemTag index]
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

        public Dictionary<ItemTag, ILoot> AllLoots { get => all_loots; set => all_loots = value; }
        public ObservableCollection<ILoot> Loots { get => loots; set => Set(ref loots, value); }
        public ILoot SelectedLoot { get => selected_loot; set => Set(ref selected_loot, value); }
        public FilterType Filter { get => filter; set => filter = value; }
        public SortType Sort { get => sort; set => sort = value; }

        public Dictionary<ItemTag, ILoot> DropAll()
        {
            return all_loots;
        }

        public void Take(ILoot loot)
        {
            loot.Take(this);
        }

        public void TakeCount(int count, ILoot loot)
        {

        }

        public KeyValuePair<ItemTag, ILoot> Drop(ItemTag tag)
        {
            foreach (var loot in all_loots)
            {
                if (loot.Key == tag) return loot;
            }
            return new KeyValuePair<ItemTag, ILoot>(ItemTag.None, null);
        }

        public ILoot DropCount(ItemTag tag, int count)
        {
            foreach (var loot in all_loots)
            {
                if (loot.Key == tag) return loot.Value.Drop(this);
            }
            return null;
        }

        public bool Check(ItemTag tag, int count = 1, int? time = null)
        {
            try
            {
                if (all_loots[tag].Check(count, time)) return true;
                else return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public void Use(ItemTag tag, int count)
        {
            all_loots[tag].Use(this, count);
        }

        public int GetCount(ItemTag tag)
        {
            try
            {
                return all_loots[tag].Count;
            }
            catch (KeyNotFoundException)
            {
                return 0;
            }
        }
    }

}

//public void FilterAll(ILoot loot)
//{

//}

//public void FilterFood(ILoot loot)
//{
//    if (loot.Item is Item || loot.Item is Item)
//    {
//        loots.Add(loot);
//        SortLoot();
//    }
//}

//public void FilterMedecine(ILoot loot)
//{
//    if (loot.Item is Medecine)
//    {
//        loots.Add(loot);
//        SortLoot();
//    }

//}

//public void FilterComponent(ILoot loot)
//{
//    if (loot.Item.GetType() == typeof(Item))
//    {
//        loots.Add(loot);
//        SortLoot();
//    }
//}

//public void FilterUtility(ILoot loot)
//{
//    if (loot.Item is GasMask || loot.Item is Bag || loot.Item is Tool || loot.Item is Armor)
//    {
//        loots.Add(loot);
//        SortLoot();
//    }
//}

//public void FilterWeapon(ILoot loot)
//{
//    if (loot.Item is Weapon)
//    {
//        loots.Add(loot);
//        SortLoot();
//    }
//}

//public void SortLoot()
//{
//    Quicksort(loots, 0, loots.Count - 1);
//}

//public int SortByCount(ObservableCollection<ILoot> array, int start, int end)
//{
//    int marker = start;
//    for (int i = start; i <= end; i++)
//    {
//        if (array[i].Count <= array[end].Count)
//        {
//            var temp = array[marker];
//            array[marker] = array[i];
//            array[i] = temp;
//            marker += 1;
//        }
//    }
//    return marker - 1;
//}

//public int SortByWeight(ObservableCollection<ILoot> array, int start, int end)
//{
//    int marker = start;
//    for (int i = start; i <= end; i++)
//    {
//        if (array[i].Count * array[i].Item.Weight <= array[end].Count * array[end].Item.Weight)
//        {
//            var temp = array[marker];
//            array[marker] = array[i];
//            array[i] = temp;
//            marker += 1;
//        }
//    }
//    return marker - 1;
//}

//private void Quicksort(ObservableCollection<ILoot> array, int start, int end)
//{
//    if (start >= end) return;
//    int pivot = sort.Invoke(loots, start, loots.Count - 1);
//    Quicksort(array, start, pivot - 1);
//    Quicksort(array, pivot + 1, end);
//}

//public ILoot GetMaterial(ItemTag tag)
//{
//    try
//    {
//        return all_loots[tag];
//    }
//    catch (KeyNotFoundException)
//    {
//        return null;
//    }
//}