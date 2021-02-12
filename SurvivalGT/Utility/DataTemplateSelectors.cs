using SurvivalGT.Interfacies;
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
            ILoot loot = item as ILoot;
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
            ILoot loot = ((CraftItem)item).Loot;
            if (loot is LootOption) return OptionDataTemplate;
            else return MaterialDataTemplate;
        }
    }
}
