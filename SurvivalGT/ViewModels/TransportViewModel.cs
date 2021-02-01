using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class TransportViewModel
    {
        public TransportViewModel(Loot loot)
        {
            Loot = loot;

            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
