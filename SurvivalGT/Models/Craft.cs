using SurvivalGT.Items;
using System.Collections.ObjectModel;

namespace SurvivalGT.Models
{
    //public class Craft
    //{
    //    CraftItem[] crafts;
    //    Player player;
    //    CraftItem selected_craft;
    //    //ObservableCollection<LootCraft> materials;
    //    //ObservableCollection<LootCraft> tools;
    //    Loot[] inventory_loot;
    //    Loot[] ground_loot;
    //    int count;
    //    int max_craft;

    //    static Craft()
    //    {

    //    }

    //    public Craft()
    //    {

    //    }

    //    public void CraftChanged()
    //    {
    //        //search from inventory;

    //        //search from ground;

    //        //max_craft;
    //    }

    //    public void Make()
    //    {
    //        for (int i = 0; i < count; i++)
    //        {

    //        }
    //    }
    //}

    //public class CraftItem
    //{
    //    Loot output;
    //    Loot[] inputs;
    //    short time;

    //    public CraftItem(Loot output, Loot[] inputs, short time)
    //    {
    //        this.output = output;
    //        this.inputs = inputs;
    //        this.time = time;
    //    }

    //    public Loot Output { get => output; private set => output = value; }
    //    public Loot[] Inputs { get => inputs; private set => inputs = value; }
    //    public short Duration { get => time; private set => time = value; }
    //}

    public class Temp
    {
        private Goods[] materials;
        private ItemTag[] tools;

        public Temp(Goods[] materials, ItemTag[] tools)
        {
            this.materials = materials;
            this.tools = tools;
        }

        public Goods[] Materials { get => materials; set => materials = value; }
        public ItemTag[] Tools { get => tools; set => tools = value; }
    }

}
