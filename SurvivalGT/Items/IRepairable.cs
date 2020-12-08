using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    interface IRepairable
    {
        Loot[] RepairLoots { get; }
    }
}
