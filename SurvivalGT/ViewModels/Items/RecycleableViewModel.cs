using SurvivalGT.Items;
using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Collections.ObjectModel;

namespace SurvivalGT.ViewModels.Items
{
    class RecycleableViewModel : ObserableObject
    {
        private Player player;

        private ObservableCollection<LootRandomShow> loot_random;
        private Recycleable recycleable;
        private int count;
        private int max;

        public RecycleableViewModel(ILoot loot)
        {
            player = Player.Instance;

            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            recycleable = loot.Item as Recycleable;
            LootRandom = GetLootRandoms();
        }

        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public ObservableCollection<LootRandomShow> LootRandom { get => loot_random; set => Set(ref loot_random, value); }
        public int Count { get => count; set => Set(ref count, value); }
        public int Max { get => max; set => Set(ref max, value); }

        public ObservableCollection<LootRandomShow> GetLootRandoms()
        {
            LootRandom = new ObservableCollection<LootRandomShow>();
            foreach (var item in recycleable.Outputs)
                LootRandom.Add(new LootRandomShow(ItemFactory.GetItem(item.Tag), item.Min, item.Max));
            return LootRandom;
        }

        public void Recycle()
        {
            recycleable.Recycle(player.Inventory);
        }
    }

    class LootRandomShow
    {
        private Item item;
        private int min;
        private int max;

        public LootRandomShow(Item item, int min, int max)
        {
            Item = item;
            Min = min;
            Max = max;
        }

        public int Min { get; }
        public int Max { get; }
        public Item Item { get; }
    }
}
