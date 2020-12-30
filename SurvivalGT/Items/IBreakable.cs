namespace SurvivalGT.Items
{
    //remove set for current
    public interface IBreakable
    {
        int Durability { get; }
        int CurrentDurability { get; set; }
        void WearOut();
    }
}
