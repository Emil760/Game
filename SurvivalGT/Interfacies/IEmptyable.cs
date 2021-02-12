namespace SurvivalGT.Interfacies
{
    interface IEmptyable
    {
        bool IsEmpty { get; set; }
        string NormalPath { get; }
        string EmptyPath { get; }
    }
}
