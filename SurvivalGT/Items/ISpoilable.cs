namespace SurvivalGT.Items
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
