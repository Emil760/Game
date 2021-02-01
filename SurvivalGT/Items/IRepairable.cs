using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    interface IRepairable
    {
        int RepairTime { get; }
        ItemTag[] RepairOptions { get; }
        Goods[] RepairMaterials { get; }
        void Repair(Inventory inventory, CraftMaterial[] materials_craft, CraftOption[] options_craft);
    }

    //interface IRepairableComplex : IRepairable
    //{
    //    ItemTag[] RepairOptions { get; }
    //}

    //class Craft : IRepairable
    //{
    //    public int RepairTime => throw new System.NotImplementedException();

    //    public Goods[] RepairMaterials => throw new System.NotImplementedException();

    //    public virtual void Repair(Inventory inventory, CraftMaterial[] materials_craft, CraftOption[] options_craft)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //class CraftComplex : Craft, IRepairableComplex
    //{
    //    public ItemTag[] RepairOptions => throw new System.NotImplementedException();

    //    public override void Repair(Inventory inventory, CraftMaterial[] materials_craft, CraftOption[] options_craft)
    //    {
    //        base.Repair(inventory, materials_craft, options_craft);
    //    }
    //}
}
