namespace SurvivalGT.Items
{
    interface IEmptyable
    {
        bool IsEmpty { get; set; }
        string NormalPath { get; }
        string EmptyPath { get; }
    }
}
