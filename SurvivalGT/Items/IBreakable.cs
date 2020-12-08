namespace SurvivalGT.Items
{
    public interface IBreakable
    {
        short Durability { get; }
        short CurrentDurability { get; set; }
    }
}
