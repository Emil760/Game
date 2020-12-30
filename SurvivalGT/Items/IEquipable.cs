namespace SurvivalGT.Items
{
    interface IEquipable
    {
        bool IsEquip { get; set; }
        void Equip();
        void Unequip();
    }
}
