using System.Windows.Controls;
using SurvivalGT.viewmodels;

namespace SurvivalGT.views
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
