using SurvivalGT.Models;
using System.Windows.Controls;

namespace SurvivalGT.InfoUC
{
    /// <summary>
    /// Interaction logic for BreakableUC.xaml
    /// </summary>
    public partial class BreakableUC : UserControl, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private Loot loot;

        public BreakableUC()
        {

        }

        public BreakableUC(Loot loot)
        {
            InitializeComponent();
            Loot = loot;
            DataContext = this;
        }

        public Loot Loot { get => loot; set => Set(ref loot, value); }

        public void Set<T>(ref T prop, T value, [System.Runtime.CompilerServices.CallerMemberName] string prop_name = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(prop_name));
        }
    }
}
