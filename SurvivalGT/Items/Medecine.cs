using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Medecine : Item
    {
        protected short health;
        protected short thirst;
        protected short stamina;
        protected short poison;
        protected short radiathion;
        protected short bleeding;
        protected short overdose;

        public Medecine(ItemTag tag, string name, float weight, string path, short overdose)
            : base(tag, name, weight, path)
        {
            this.overdose = overdose;
        }

        public short Health { get => health; }

        public short Thirst { get => thirst; }

        public short Stamina { get => stamina; }

        public short Poison { get => poison; }

        public short Radiathion { get => radiathion; }

        public short Bleeding { get => bleeding; }

        public short Overdose { get => overdose; }
    }

    class EffectMedecine : Medecine
    {
        private Effect effect;

        public EffectMedecine(ItemTag tag, string name, float weight, string path, short overdose, Effect effect)
            : base(tag, name, weight, path, overdose)
        {
            this.effect = effect;
        }

        //public override object Clone()
        //{
        //    return new EffectMedecine(tag, name, weight, path, overdose, (Effect)effect.Clone());
        //}
    }

    class AddictMedecine : EffectMedecine
    {
        public AddictMedecine(ItemTag tag, string name, float weight, string path, short overdose, Effect effect)
            : base(tag, name, weight, path, overdose, effect)
        {

        }
    }
}
