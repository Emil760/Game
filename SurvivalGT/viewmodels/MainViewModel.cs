using SurvivalGT.Models;
using SurvivalGT.Utility;
using SurvivalGT.Views;
using System.Windows.Controls;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    public class MainViewModel : ObserableObject
    {
        private Player player;
        private ContentControl interaction_view;
        //private Timer timer;
        //private float miunte = 1;
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
        public ContentControl InteractionView
        {
            get => interaction_view;
            set
            {
                game.Timer.Stop();
                Set(ref interaction_view, value);
            }
        }

        private void InventoryShow(object sender)
        {
            if (!(interaction_view is InventoryUserControl)) InteractionView = new InventoryUserControl();
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
            if (!(interaction_view is MapUserControl)) InteractionView = new MapUserControl(this);
        }
    }
}
