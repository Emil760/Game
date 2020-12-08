namespace SurvivalGT.Items
{
    class GasMask : Item, IBreakable
    {
        private short radiation;
        private short current_durability;
        private short durability;

        public GasMask(ItemTag tag, string name, float weight, string image, short durability, short radiation)
            : base(tag, name, weight, image)
        {
            this.durability = durability;
            this.radiation = radiation;
        }

        public short Radiathion => radiation;

        public short CurrentDurability { get => current_durability; set => Set(ref current_durability, value); }

        public short Durability { get => durability; }

        //public override object Clone()
        //{
        //    return new GasMask(tag, name, weight, path, durability, radiation);
        //}
    }
}
