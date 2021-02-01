using System.Windows.Controls;
using SurvivalGT.ViewModels;

namespace SurvivalGT.Views
{
    /// <summary>
    /// Interaction logic for InventoryUserControl.xaml
    /// </summary>
    public partial class InventoryUserControl : UserControl
    {
        public InventoryUserControl()
        {
            InitializeComponent();
            DataContext = new InventoryViewModel();
        }
    }
}
