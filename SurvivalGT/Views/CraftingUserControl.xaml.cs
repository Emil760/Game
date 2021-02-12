using SurvivalGT.ViewModels;
using System.Windows.Controls;

namespace SurvivalGT.Views
{
    /// <summary>
    /// Interaction logic for CraftingUserControl.xaml
    /// </summary>
    public partial class CraftingUserControl : UserControl
    {
        public CraftingUserControl()
        {
            InitializeComponent();
            DataContext = new CraftViewModel();
        }
    }
}
