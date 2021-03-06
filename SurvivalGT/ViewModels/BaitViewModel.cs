﻿using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class BaitViewModel : ObserableObject
    {
        private ObservableCollection<ILoot> baits;
        private Goods selected_bait;

        public BaitViewModel(Fishingrod  fishingrod)
        {
            BaitChangedCommand = new Command(BaitChanged);
            Fishingrod = fishingrod;
            SelectedBait = null;

            baits = new ObservableCollection<ILoot>();
            foreach (var bait in Fishingrod.Baits)
                baits.Add(new LootSpoil(ItemFactory.GetItem(bait.Tag), bait.Count));
        }

        public ICommand BaitChangedCommand { get; }

        public Fishingrod Fishingrod { get; }
        public ObservableCollection<ILoot> Baits { get => baits; set => Set(ref baits, value); }
        public Goods SelectedBait { get => selected_bait; set => Set(ref selected_bait, value); }

        public void BaitChanged(object param)
        {

        }
    }
}
