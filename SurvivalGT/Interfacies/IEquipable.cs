namespace SurvivalGT.Interfacies
{
    interface IEquipable
    {
        bool IsEquip { get; set; }
        void Equip();
        void Unequip();
    }
}
