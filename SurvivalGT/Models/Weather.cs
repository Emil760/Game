namespace SurvivalGT.Models
{
    //public static class WeatherFactory
    //{
    //    private static Effect[] effects;

    //    static WeatherFactory()
    //    {
    //        effects = new Effect[10];
    //        effects[0] = new Rainy();
    //        effects[1] = new Frosty();
    //    }

    //    public static Effect[] Effects { get => effects; }

    //    public static Effect GetItem(int index)
    //    {
    //        return effects[index];
    //    }
    //}

    public class Day : Effect
    {
        public Day() : base(720, "Day", "")
        {
            Light = 80;
        }

        public short Light { get; }

        public override void Enter(Player player)
        {

        }

        public override void Leave(Player player)
        {

        }
    }

    public class Night : Effect
    {
        public Night() : base(720, "Night", "")
        {
            Light = 40;
        }

        public short Light { get; }

        public override void Enter(Player player)
        {

        }

        public override void Leave(Player player)
        {

        }
    }

    public class Rainy : Effect
    {
        public Rainy() : base(111, "Rainy", "")
        {
            Speed = -20;
            Light = -15;
        }

        public short Speed { get; }
        public short Light { get; }

        public override void Enter(Player player)
        {

        }

        public override void Leave(Player player)
        {

        }
    }

    public class Frosty : Effect
    {
        public Frosty() : base(111, "Frosty", "")
        {
            Light = -5;
            Stamina = 10;
            Food = -10;
        }

        public short Light { get; }
        public short Stamina { get; }
        //remove if
        public short Food { get; }

        public override void Enter(Player player)
        {

        }

        public override void Leave(Player player)
        {

        }
    }

    ////light -50%
    //public class Foggy : Weather
    //{

    //}

    ////light 0%
    //public class BlackSky : Weather
    //{

    //}

    ////enemy 0%
    //public class Calm : Weather
    //{

    //}

    ////thirst +30% food -10%
    //public class AnomalousHeat : Weather
    //{

    //}

    ////rad +2 light -15%
    //public class DustStorm : Weather
    //{

    //}

    ////rad +5 health -1
    //public class Fallout : Weather
    //{

    //}

    ////rad -3
    //public class FreshBreeze : Weather
    //{

    //}

    ////enemy +30%
    //public class HungrySeason : Weather
    //{

    //}

    ////health -1 speed -30% 
    //public class IceStorm : Weather
    //{

    //}

    ////speed -50%
    //public class Slush : Weather
    //{

    //}

    ////speed +20%
    //public class Tailwind : Weather
    //{

    //}

    ////enemy -20%
    //public class WellFedSeason : Weather
    //{

    //}

    //public class WeatherDecorator : Effect
    //{
    //    private Weather weather;

    //    public WeatherDecorator(int duration, Weather weather) : base(duration)
    //    {
    //        this.weather = weather;
    //    }

    //    public Weather Weather { get => weather; }

    //    public void SetTarget(Weather weather)
    //    {
    //        this.weather = weather;
    //    }

    //    public override void Enter(Player player)
    //    {

    //    }

    //    public override void Leave(Player player)
    //    {

    //    }
    //}
}
