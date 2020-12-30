using SurvivalGT.Models;
using SurvivalGT.viewmodels;
using System.Timers;
using System.Windows;

namespace SurvivalGT.views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;
        MainViewModel main_view_model;

        public MainWindow()
        {
            InitializeComponent();
            main_view_model = new MainViewModel();
            DataContext = main_view_model;

            player = Player.Instance;
            main_view_model.Timer.Elapsed += DecreaseStats;

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
            Dispatcher.Invoke(() =>
            {
                hp_txtblock.Text = ((short)(player.Hp -= player.HpDec)).ToString();
                hunger_txtblock.Text = ((short)(player.Hunger -= player.HungerDec)).ToString();
                thirst_txtblock.Text = ((short)(player.Thirst -= player.ThirstDec)).ToString();
                stamina_txtblock.Text = ((short)(player.Stamina -= player.StaminaDec)).ToString();
                poison_txtblock.Text = ((short)(player.Poison -= player.PoisonDec)).ToString();
                rad_txtblock.Text = ((short)(player.Radiation -= player.RadiationDec)).ToString();
                date_txtblock.Text = (player.Date = player.Date.AddMinutes(2)).ToShortTimeString();
            });
        }
    }
}
