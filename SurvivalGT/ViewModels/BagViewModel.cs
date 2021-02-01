using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class BagViewModel
    {
        public BagViewModel(Loot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public Loot Loot { get; set; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
