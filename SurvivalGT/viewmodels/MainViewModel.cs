using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.views;
using System;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Input;

namespace SurvivalGT.viewmodels
{
    public class MainViewModel : ObserableObject
    {
        private Player player;
        private ContentControl interaction_control;
        private DateTime date;
        private Timer timer;
        private double miunte = 1;

        public MainViewModel()
        {
            InventoryShowCommand = new Command(InventoryShow);
            CraftShowCommand = new Command(CraftShow);
            SearchShowCommand = new Command(SearchShow);
            HealthShowCommand = new Command(HealthShow);
            StatisticShowCommand = new Command(StatisticShow);
            AbilityShowCommand = new Command(AbilityShow);
            MapShowCommand = new Command(MapShow);

            //InteractionView = new MapUserControl(this);

            Player = Player.Instance;

            timer = new Timer(16.666);
            timer.Elapsed += Timer_Elapsed;
            Date = new DateTime(1999, 1, 1, 0, 0, 0);
            //timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Date = Date.AddMinutes(miunte);
            player.Decrease();
        }

        public ICommand InventoryShowCommand { get; }
        public ICommand CraftShowCommand { get; }
        public ICommand SearchShowCommand { get; }
        public ICommand HealthShowCommand { get; }
        public ICommand StatisticShowCommand { get; }
        public ICommand AbilityShowCommand { get; }
        public ICommand MapShowCommand { get; }

        public Player Player { get => player; set => Set(ref player, value); }
        public ContentControl InteractionView { get => interaction_control; set => Set(ref interaction_control, value); }
        public DateTime Date { get => date; set => Set(ref date, value); }
        public Timer Timer { get => timer; set => timer = value; }

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
            //InteractionView = new MapUserControl(this);
        }
    }
}
