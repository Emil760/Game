namespace SurvivalGT.Interfacies
{
    interface ISpoilable
    {
        int Time { get; set; }
        void Spoil();
    }

    interface IRespoilable : ISpoilable
    {
        int FullTime { get; }
    }
}
