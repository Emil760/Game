using SurvivalGT.Models;
using SurvivalGT.ViewModels;
using System.Timers;
using System.Windows;

namespace SurvivalGT.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Player player;
        Game game;
        //clear
        MainViewModel main_view_model;
        int a;

        public MainWindow()
        {
            InitializeComponent();
            main_view_model = new MainViewModel();
            DataContext = main_view_model;

            player = Player.Instance;
            game = Game.Instance;
            game.Timer.Elapsed += DecreaseStats;

            hp_txtblock.Text = ((short)player.Hp).ToString();
            hunger_txtblock.Text = ((short)player.Hunger).ToString();
            thirst_txtblock.Text = ((short)player.Thirst).ToString();
            stamina_txtblock.Text = ((short)player.Stamina).ToString();
            poison_txtblock.Text = ((short)player.Poison).ToString();
            rad_txtblock.Text = ((short)player.Radiation).ToString();
            date_txtblock.Text = player.Date.ToShortTimeString();
        }

        private void DecreaseStats(object sender, ElapsedEventArgs e)
        {
            player.Decrease();
            Dispatcher.Invoke(() =>
            {
                hp_txtblock.Text = ((short)player.Hp).ToString();
                hunger_txtblock.Text = ((short)player.Hunger).ToString();
                thirst_txtblock.Text = ((short)player.Thirst).ToString();
                stamina_txtblock.Text = ((short)player.Stamina).ToString();
                poison_txtblock.Text = ((short)player.Poison).ToString();
                rad_txtblock.Text = ((short)player.Radiation).ToString();
                date_txtblock.Text = player.Date.ToShortTimeString();
            });
        }
    }
}
