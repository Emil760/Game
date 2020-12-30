using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.views;
using System;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace SurvivalGT.viewmodels
{
    public class MainViewModel : ObserableObject
    {
        private Player player;
        private ContentControl interaction_control;
        private Timer timer;
        private float miunte = 1;
        private bool is_moving;
        Game game;

        public MainViewModel()
        {
             game = Game.Instance;

            InventoryShowCommand = new Command(InventoryShow);
            CraftShowCommand = new Command(CraftShow);
            SearchShowCommand = new Command(SearchShow);
            HealthShowCommand = new Command(HealthShow);
            StatisticShowCommand = new Command(StatisticShow);
            AbilityShowCommand = new Command(AbilityShow);
            MapShowCommand = new Command(MapShow);

            Player = Player.Instance;

            timer = new Timer(game.Fps);

            InteractionView = new MapUserControl(this);
        }

        public ICommand InventoryShowCommand { get; }
        public ICommand CraftShowCommand { get; }
        public ICommand SearchShowCommand { get; }
        public ICommand HealthShowCommand { get; }
        public ICommand StatisticShowCommand { get; }
        public ICommand AbilityShowCommand { get; }
        public ICommand MapShowCommand { get; }

        public Game Game { get => game; }
        public Player Player { get => player; set => Set(ref player, value); }
        public ContentControl InteractionView { get => interaction_control; set => Set(ref interaction_control, value); }

        public Timer Timer { get => timer; set => timer = value; }

        public bool IsMoving { get => is_moving; set => Set(ref is_moving, value); }

        private void InventoryShow(object sender)
        {
            InteractionView = new InventoryUserControl();
            timer.Stop();
        }

        private void CraftShow(object sender)
        {

        }

        private void SearchShow(object sender)
        {

        }

        private void HealthShow(object sender)
        {

        }

        private void StatisticShow(object sender)
        {

        }

        private void AbilityShow(object sender)
        {

        }

        private void MapShow(object sender)
        {
            InteractionView = new MapUserControl(this);
        }
    }
}
