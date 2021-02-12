using SurvivalGT.Models;
using SurvivalGT.Utility;

namespace SurvivalGT.ViewModels.Items
{
    public class ArmorViewModel : ObserableObject
    {
        private ILoot loot;

        public ArmorViewModel(ILoot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            BreakableViewModel = new BreakableViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
            RepairViewModel = new RepairViewModel(loot);
        }

        public ILoot Loot { get => loot; set => Set(ref loot, value); }
        public ItemViewModel ItemViewModel { get; }
        public BreakableViewModel BreakableViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
        public RepairViewModel RepairViewModel { get; }
    }
}
