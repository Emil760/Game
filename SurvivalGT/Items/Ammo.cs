namespace SurvivalGT.Items
{
    class Ammo : Item
    {
        ItemTag weapon;

        public Ammo(ItemTag tag, string name, float weight, string path, ItemTag weapon)
            : base(tag, name, weight, path)
        {
            Weapon = weapon;
        }

        public ItemTag Weapon { get => weapon; set => weapon = value; }

        //public override object Clone()
        //{
        //    return base.Clone();
        //}
    }
}
