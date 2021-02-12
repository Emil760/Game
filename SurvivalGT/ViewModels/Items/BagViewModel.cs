using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class BagViewModel
    {
        public BagViewModel(ILoot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public ILoot Loot { get; set; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
