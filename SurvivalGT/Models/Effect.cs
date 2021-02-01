using SurvivalGT.Utility;
using System.Collections.Generic;

namespace SurvivalGT.Models
{
    public enum EffectTag
    {
        Rainy,
        Frosty,
        SleepResistance,
        Alcogolizm,
        Smoking,
        Overdose,
        Poisoning,
        Bledding,
        RadiationResistance,
        Healing,
        RadiationSickness,
        Worms
    }

    public static class EffectFactory
    {
        private static Dictionary<EffectTag, Effect> effects;

        static EffectFactory()
        {
            effects = new Dictionary<EffectTag, Effect>();
            effects.Add(EffectTag.Rainy, new Rainy());
            effects.Add(EffectTag.Frosty, new Frosty());
            effects.Add(EffectTag.Worms, new Worms());
            effects.Add(EffectTag.Healing, new Healing());
        }

        public static Effect GetEffect(EffectTag tag)
        {
            return effects[tag];
        }
    }

    //name first duration second
    public abstract class Effect : ObserableObject
    {
        protected int duration;

        //remove
        protected Effect()
        {

        }

        protected Effect(int duration, string name, string path = null)
        {
            Duration = duration;
            Name = name;
            Path = path;
        }

        public int Duration { get => duration; set => Set(ref duration, value); }
        public string Name { get; }
        public string Path { get; }

        public abstract void Enter(Player player);

        public abstract void Leave(Player player);
    }

    //rad -5
    //public class RadiationResistance : Effect
    //{

    //}

    ////stamina +5
    //public class SleepResistance : Effect
    //{

    //}

    ////thirst -1 hunger -1 stamina -1
    //public class Alcogolizm : Effect
    //{

    //}

    ////thirst -2 hunger -1
    //public class Smoking : Effect
    //{

    //}

    //// weight -10% HpMax 90 HungerMax 90 ThirstMax 90 StaminaMax 90 
    //public class Exhaustion : Effect
    //{

    //}

    public class Worms : Effect
    {
        public Worms() : base(48, "Intestinal worms", "/images/effects/worms.png")
        {
            Hunger = 1f;
            Thirst = 0.5f;
        }

        public float Hunger { get; }
        public float Thirst { get; }

        public override void Enter(Player player)
        {
            player.HungerDec += Hunger;
            player.ThirstDec += Thirst;
        }

        public override void Leave(Player player)
        {
            player.HungerDec -= Hunger;
            player.ThirstDec -= Thirst;
        }
    }

    public class Healing : Effect
    {
        public Healing() : base(24, "Healing", "/images/effects/plus.png")
        {

        }

        public float Hp { get; }

        public override void Enter(Player player)
        {
            player.HpDec += Hp;
        }

        public override void Leave(Player player)
        {
            player.HpDec -= Hp;
        }
    }

}

//class Hangover : Effect
//{

//}

//class Headache : Effect
//{

//}

//class Sleepless : Effect
//{

//}
