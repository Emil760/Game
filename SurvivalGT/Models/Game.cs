using SurvivalGT.Utility;
using System;
using System.Timers;

namespace SurvivalGT.Models
{
    public class Game : ObserableObject
    {
        private static Game instance;
        private float zoom;
        private bool is_moving;

        //get saved data
        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                    instance.Player = Player.Instance;
                    instance.Map = Map.Instance;
                    instance.zoom = 1;
                    instance.MaxZoom = 2;
                    instance.MinZoom = 0.5f;
                    instance.Fps = 33.333f;
                    instance.ZoomPer = 1.02f;
                    instance.IsMoving = false;
                    instance.Timer = new Timer(instance.Fps);
                    instance.Timer.Elapsed += instance.WeatherTimer;
                    instance.Minute = 2;
                    instance.DayNight = new Day();
                    instance.Weather = null;
                }
                return instance;
            }
        }

        public Player Player { get; private set; }
        public Map Map { get; private set; }
        public Timer Timer { get; private set; }
        public short Minute { get; private set; }

        public float Zoom { get => zoom; set => zoom = value; }
        public float ZoomPer { get; private set; }
        public float MaxZoom { get; private set; }
        public float MinZoom { get; private set; }

        public float Fps { get; private set; }
        public bool IsMoving { get => is_moving; set => Set(ref is_moving, value); }
        //private set
        public Effect DayNight { get; set; }
        public Effect Weather { get; set; }

        public void Move()
        {

        }

        public void PrepareMove()
        {

        }

        private void TimerMove(object sender, ElapsedEventArgs e)
        {

        }

        private void TimerPlayer(object sender, ElapsedEventArgs e)
        {

        }

        private void TimerCraft(object sender, ElapsedEventArgs e)
        {

        }

        private void WeatherTimer(object sender, ElapsedEventArgs e)
        {
            DayNight.Duration -= Minute;
            if (DayNight.Duration <= 0)
            {
                DayNight.Leave(Player);
                if (DayNight is Day) DayNight = new Night();
                else
                {
                    DayNight = new Day();
                    if (Weather == null)
                    {
                        Random random = new Random();
                        if (random.Next(0, 5) == 0)
                        {
                            //random weather
                            //Weather = WeatherFactory.GetItem(random.Next(0, WeatherFactory.Effects.Length));
                            Weather.Enter(Player);
                        }
                        return;
                    }
                }
                DayNight.Enter(Player);
            }
            if (Weather != null)
            {
                Weather.Duration -= Minute;
                if (Weather.Duration <= 0)
                {
                    Weather.Leave(Player);
                    Weather = null;
                }
            }
        }
    }
}
