namespace SurvivalGT.Items
{
    public class Goods
    {
        private ItemTag tag;
        private int count;

        public Goods(ItemTag tag, int count)
        {
            this.tag = tag;
            this.count = count;
        }

        public ItemTag Tag { get => tag; set => tag = value; }
        public int Count { get => count; set => count = value; }
    }

    public class GoodsRandom
    {
        private ItemTag tag;
        private int min;
        private int max;

        public GoodsRandom(ItemTag tag, int min, int max)
        {
            this.tag = tag;
            this.min = min;
            this.max = max;
        }

        public ItemTag Tag { get => tag; set => tag = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
    }
}
