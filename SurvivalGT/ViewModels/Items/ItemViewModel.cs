namespace SurvivalGT.ViewModels.Items
{
    public class ItemViewModel : Utility.ObserableObject
    {
        public ItemViewModel(Models.ILoot loot, bool is_info)
        {
            Loot = loot;
            IsInfo = is_info;
        }

        public Models.ILoot Loot { get; }
        public bool IsInfo { get; }
    }
}