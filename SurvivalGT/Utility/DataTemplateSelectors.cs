using SurvivalGT.Items;
using SurvivalGT.Models;
using System.Windows;
using System.Windows.Controls;

namespace SurvivalGT.Utility
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
            if (loot.Item is IBreakable) return BrockenableDataTemplate;
            else return NormaDataTemplate;
        }
    }


    class CraftDataTemplateSelector : DataTemplateSelector
    {
        public CraftDataTemplateSelector()
        {

        }

        public DataTemplate MaterialDataTemplate { get; set; }
        public DataTemplate OptionDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is CraftMaterial) return MaterialDataTemplate;
            else return OptionDataTemplate;
        }
    }
}
