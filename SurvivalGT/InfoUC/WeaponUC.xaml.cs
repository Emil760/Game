using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SurvivalGT.InfoUC
{
    /// <summary>
    /// Interaction logic for WeaponUC.xaml
    /// </summary>
    public partial class WeaponUC : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private CraftItem[] crafts;
        private Visibility repair_visibility;

        public WeaponUC(CraftItem[] crafts)
        {
            InitializeComponent();
            RepairCommand = new Command(Repair);
            Crafts = crafts;
        }

        ICommand RepairCommand { get; }

        public CraftItem[] Crafts { get => crafts; set => Set(ref crafts, value); }
        public Visibility RepairVisibility  { get => repair_visibility; set => Set(ref repair_visibility, value); }

        public void Repair(object param)
        {

        }

        public void Check()
        {
            RepairVisibility = Visibility.Visible;
        }

        public void Set<T>(ref T prop, T value, [System.Runtime.CompilerServices.CallerMemberName] string prop_name = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(prop_name));
        }
    }
}
