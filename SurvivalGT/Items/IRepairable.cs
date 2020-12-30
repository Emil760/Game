namespace SurvivalGT.Items
{
    interface IRepairable
    {
        Goods[] RepairGoods { get; }
        void Repair();
    }
}
