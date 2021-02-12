namespace SurvivalGT.ViewModels.Items
{
    class GasMaskViewModel : ItemViewModel
    {
        public GasMaskViewModel(Models.ILoot loot, bool is_info) : base(loot, is_info)
        {
            MaskViewModel = new MaskViewModel(loot, is_info);
            RepairViewModel = new RepairViewModel(loot, is_info);
        }

        public MaskViewModel MaskViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
