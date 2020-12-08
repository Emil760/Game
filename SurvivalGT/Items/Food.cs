using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    public class PrepareFood : Item
    {
        HealthyFood output;
        Loot[] input;

        public PrepareFood()
        {

        }

        public void Cook()
        {

        }

        //public override object Clone()
        //{
        //    return base.Clone();
        //}
    }

    public class EatFood : Item, ISpoilable
    {
        private int hunger;
        private int thirst;
        private int time;

        public EatFood()
        {

        }

        public int Hunger { get => hunger; }
        public int Thirst { get => thirst; }
        public int Time { get => time; set => time = value; }

        virtual public void Eat(Player player)
        {

        }

        //public override object Clone()
        //{
        //    return base.Clone();
        //}
    }



    public class HealthyFood : EatFood
    {
        private int stamina;

        public HealthyFood()
        {

        }

        public int Stamina { get => stamina; }

        public override void Eat(Player player)
        {
            base.Eat(player);
        }

        public override object Clone()
        {
            return base.Clone();
        }
    }



    public class PoisonFood : EatFood
    {
        private int poison;
        private short chance;
        private Effect effect;

        public PoisonFood()
        {

        }

        public int Poison { get => poison; }
        public short Chance { get => chance; }
        public Effect Effect { get => effect; }

        public override void Eat(Player player)
        {
            base.Eat(player);
        }
    }

    public class RawFood : PoisonFood
    {
        PrepareFood prepare;
        HealthyFood healthy;

        public RawFood()
        {

        }

        PrepareFood Prepare { get => prepare; }
        HealthyFood Healthy { get => healthy; }

        public void Cook()
        {

        }

        public override void Eat(Player player)
        {
            base.Eat(player);
        }

        //public override object Clone()
        //{
        //    return base.Clone();
        //}
    }
}

//float weight
