using SurvivalGT.Models;

namespace SurvivalGT.ViewModels
{
    class MaskViewModel
    {
        public MaskViewModel(Loot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
        }

        public Loot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
