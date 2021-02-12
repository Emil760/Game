using SurvivalGT.Items;
using SurvivalGT.Models;

namespace SurvivalGT.Interfacies
{
    interface IRepairable
    {
        int RepairTime { get; }
        Goods[] RepairGoods { get; }
        void Repair(Inventory inventory, CraftItem[] crafts);
    }
}
