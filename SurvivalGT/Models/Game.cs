using SurvivalGT.views;
using System;
using System.Timers;

namespace SurvivalGT.Models
{
    public class Game
    {
        private static Game instance;

        private Player player;
        private Map map;
        private Timer timer = new Timer();

        private float zoom;
        private float fps;

        private MainWindow mainWindow;
        private MapUserControl mapUserControl;

        private bool is_moving;

        private Game()
        {
            player = Player.Instance;
        }

        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                    instance.zoom = 1;
                    instance.fps = 33.333f;
                }
                return instance;
            }
        }

        public float Zoom { get => zoom; set => zoom = value; }
        public float Fps { get => fps; set => fps = value; }

        public void Move()
        {

        }

        public void PrepareMove()
        {

        }

        private void TimerMove(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TimerPlayer(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TimerCraft(object sender, ElapsedEventArgs e)
        {

        }
    }
}
