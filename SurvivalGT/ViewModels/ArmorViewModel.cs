using SurvivalGT.Models;
using SurvivalGT.Utility;

namespace SurvivalGT.ViewModels
{
    public class ArmorViewModel : ObserableObject
    {
        private Loot loot;

        public ArmorViewModel(Loot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public Loot Loot { get => loot; set => Set(ref loot, value); }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
