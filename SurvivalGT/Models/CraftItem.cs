namespace SurvivalGT.Models
{
    public class CraftItem
    {
        int count;
        Loot loot;

        public CraftItem(int count, Loot loot)
        {
            this.Count = count;
            this.Loot = loot;
        }

        public int Count { get => count; set => count = value; }
        public Loot Loot { get => loot; set => loot = value; }
    }
}
