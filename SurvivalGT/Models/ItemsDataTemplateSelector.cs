using SurvivalGT.Items;
using System.Windows;
using System.Windows.Controls;

namespace SurvivalGT.Models
{
    class ItemsDataTemplateSelector : DataTemplateSelector
    {
        public ItemsDataTemplateSelector()
        {

        }

        public DataTemplate NormaDataTemplate { get; set; }
        public DataTemplate BrockenableDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Loot loot = item as Loot;
            if (loot is IBreakable) return BrockenableDataTemplate;
            else return NormaDataTemplate;
        }
    }
}
