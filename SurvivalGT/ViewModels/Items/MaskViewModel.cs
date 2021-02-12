using SurvivalGT.Models;

namespace SurvivalGT.ViewModels.Items
{
    class MaskViewModel
    {
        public MaskViewModel(ILoot loot)
        {
            Loot = loot;
            ItemViewModel = new ItemViewModel(loot);
            EquipViewModel = new EquipViewModel(loot);
        }

        public ILoot Loot { get; }
        public ItemViewModel ItemViewModel { get; }
        public EquipViewModel EquipViewModel { get; }
    }
}
