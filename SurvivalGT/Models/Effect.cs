using System;

namespace SurvivalGT.Models
{
    public enum EffectTag
    {
        SleepResistance,
        Alcogolizm,
        Smoking,
        Overdose,
        Poisoning,
        Bledding,
        RadiationResistance,
        Healing,
        RadiationSickness,
    }

    public abstract class Effect : ICloneable
    {
        protected int time;

        public int Time { get => time; set => time = value; }

        public abstract void Run(Player player);

        public abstract object Clone();
    }


    public class SleepResistance : Effect
    {
        public override void Run(Player player)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }

    }

    public class Alcogolizm : Effect
    {
        public override void Run(Player player)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }

    public class Smoking : Effect
    {
        public override void Run(Player player)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }

    public class Worms : Effect
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void Run(Player player)
        {
            throw new NotImplementedException();
        }
    }

}
