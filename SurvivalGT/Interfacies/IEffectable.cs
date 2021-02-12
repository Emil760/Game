using SurvivalGT.Models;

namespace SurvivalGT.Interfacies
{
    interface IEffectable
    {
        Effect Effect { get; }
    }

    interface IChanceable : IEffectable
    {
        short Chance { get; }
    }

    interface IAddictable : IChanceable
    {
        short Addict { get; }
    }
}
