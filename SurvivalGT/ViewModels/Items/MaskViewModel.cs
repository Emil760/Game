namespace SurvivalGT.ViewModels.Items
{
    class MaskViewModel : ItemViewModel
    {
        public MaskViewModel(Models.ILoot loot, bool is_info) : base(loot, is_info)
        {
            EquipViewModel = new EquipViewModel(loot, is_info);
        }

        public EquipViewModel EquipViewModel { get; }
    }
}
