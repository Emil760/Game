using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    //abstract
    class Consumer : Item
    {
        private short hp;
        private short hunger;
        private short thirst;
        private short stamina;
        private short poison;
        private short rad;

        public Consumer(ItemTag tag, ItemType type, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad)
            : base(tag, type, name, weight, path)
        {
            this.hp = hp;
            this.hunger = hunger;
            this.thirst = thirst;
            this.stamina = stamina;
            this.poison = poison;
            this.rad = rad;
        }

        public short Hp { get => hp; }
        public short Hunger { get => hunger; }
        public short Thirst { get => thirst; }
        public short Stamina { get => stamina; }
        public short Poison { get => poison; }
        public short Rad { get => rad; }

        public virtual void Consume()
        {

        }
    }

    class Food : Consumer, ISpoilable
    {
        protected int time;

        public Food(ItemTag tag, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad, int time)
                   : base(tag, ItemType.Food, name, weight, path, hp, hunger, thirst, stamina, poison, rad)
        {
            this.time = time;
        }

        public int Time { get => time; set => time = value; }

        public void Spoil()
        {
            throw new System.NotImplementedException();
        }
    }

    class PoisonFood : Food, IChanceable
    {
        private short chance;
        private Effect effect;

        public PoisonFood(ItemTag tag, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad, int time, short chance, Effect effect)
                   : base(tag, name, weight, path, hp, hunger, thirst, stamina, poison, rad, time)
        {
            this.chance = chance;
            this.effect = effect;
        }

        public short Chance  { get => chance; }

        public Effect Effect { get => effect; }
    }

    class Medecine : Consumer
    {
        private short overdose;

        public Medecine(ItemTag tag, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad, short overdose)
            : base(tag, ItemType.Medecine, name, weight, path, hp, hunger, thirst, stamina, poison, rad)
        {
            this.overdose = overdose;
        }

        protected short Overdose { get => overdose; set => overdose = value; }
    }

    class MedecineEffect : Medecine, IEffectable
    {
        private Effect effect;

        public MedecineEffect(ItemTag tag, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad, short overdose, Effect effect)
            : base(tag, name, weight, path, hp, hunger, thirst, stamina, poison, rad, overdose)
        {
            this.effect = effect;
        }

        public Effect Effect { get => effect; }
    }

    class Alco : Consumer, IBreakable, IAddictable
    {
        private int durability;
        private int current_durability;
        private short addict;
        private short chance;
        private Effect effect;

        public Alco(ItemTag tag, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad, short chance, short addict, Effect effect, short durability)
            : base(tag, ItemType.Medecine, name, weight, path, hp, hunger, thirst, stamina, poison, rad)
        {
            this.addict = addict;
            this.chance = chance;
            this.effect = effect;
            this.durability = durability;
            this.current_durability = durability;
        }

        public int Durability { get => durability; }

        public int CurrentDurability { get => current_durability; set => current_durability = value; }

        public short Addict { get => addict; }

        public short Chance { get => chance; }

        public Effect Effect { get => effect; }

        public void WearOut()
        {
            throw new System.NotImplementedException();
        }

        public override void Consume()
        {
            base.Consume();
        }
    }

    class Cigarette : Consumer, IAddictable
    {
        private short addict;
        private short chance;
        private Effect effect;

        public Cigarette(ItemTag tag, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad, short chance, short addict, Effect effect)
             : base(tag, ItemType.Medecine, name, weight, path, hp, hunger, thirst, stamina, poison, rad)
        {
            this.addict = addict;
            this.chance = chance;
            this.effect = effect;
        }

        public short Addict { get => addict; }

        public short Chance { get => chance; }

        public Effect Effect { get => effect; }

        public override void Consume()
        {
            base.Consume();
        }
    }

    class Potion : Consumer, IBreakable
    {
        private int durability;
        private int current_durability;

        public Potion(ItemTag tag, string name, float weight, string path, short hp, short hunger, short thirst, short stamina, short poison, short rad, int durability)
            : base(tag, ItemType.Medecine, name, weight, path, hp, hunger, thirst, stamina, poison, rad)
        {
            this.durability = durability;
            this.current_durability = durability;
        }

        public int Durability { get => durability; }

        public int CurrentDurability { get => current_durability; set => current_durability = value; }

        public void WearOut()
        {
            throw new System.NotImplementedException();
        }
    }
}
