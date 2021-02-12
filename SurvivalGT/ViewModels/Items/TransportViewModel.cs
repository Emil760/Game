using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class TransportViewModel
    {
        public TransportViewModel(ILoot loot)
        {
            Loot = loot;

            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
