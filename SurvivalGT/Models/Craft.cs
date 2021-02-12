using SurvivalGT.Items;
using SurvivalGT.Utility;

namespace SurvivalGT.Models
{
    public class CraftItem : ObserableObject
    {
        private ILoot loot;
        private int count;

        public CraftItem(ILoot loot, int count)
        {
            Loot = loot;
            Count = count;
        }

        public ILoot Loot { get => loot; set => Set(ref loot, value); }
        public int Count { get => count; set => Set(ref count, value); }
    }

    public class Craft : ObserableObject
    {
        private ILoot[] inputs;
        private ILoot[] outputs;
        private int time;
        private ItemType type;
        private short level;
        private short points;
        private bool is_active;
        private bool is_locked;

        public Craft(ILoot[] inputs, ILoot[] outputs, ItemType type, short level, short points, int time, bool is_locked = true, bool is_active = false)
        {
            Inputs = inputs;
            Outputs = outputs;
            Time = time;
            Type = type;
            Level = level;
            Points = points;
            IsLocked = is_locked;
            IsActive = is_active;
        }

        public ILoot[] Inputs { get => inputs; private set => Set(ref inputs, value); }
        public ILoot[] Outputs { get => outputs; private set => Set(ref outputs, value); }
        public int Time { get => time; private set => Set(ref time, value); }
        public ItemType Type { get => type; private set => Set(ref type, value); }
        public short Level { get => level; private set => Set(ref level, value); }
        public short Points { get => points; private set => Set(ref points, value); }
        public bool IsActive { get => is_active; set => Set(ref is_active, value); }
        public bool IsLocked { get => is_locked; set => Set(ref is_locked, value); }

        public void Activate(Player player)
        {

        }

        public void Make()
        {

        }
    }
}
