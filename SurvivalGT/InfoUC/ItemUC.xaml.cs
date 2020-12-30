using SurvivalGT.Models;
using System.Windows.Controls;

namespace SurvivalGT.InfoUC
{
    /// <summary>
    /// Interaction logic for ItemUC.xaml
    /// </summary>
    public partial class ItemUC : UserControl
    {
        public ItemUC()
        {

        }

        public ItemUC(Loot loot)
        {
            InitializeComponent();
            DataContext = loot;
        }
    }
}
