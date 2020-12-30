using System.Collections.ObjectModel;

namespace SurvivalGT.Models
{
    class Craft
    {
        CraftItem[] crafts;
        Player player;
        CraftItem selected_craft;
        ObservableCollection<LootFullCount> materials;
        ObservableCollection<LootFullCount> tools;
        Loot[] inventory_loot;
        Loot[] ground_loot;
        int count;
        int max_craft;

        static Craft()
        {

        }

        public Craft()
        {

        }

        public void CraftChanged()
        {
            //search from inventory;

            //search from ground;

            //max_craft;
        }

        public void Make()
        {
            for (int i = 0; i < count; i++)
            {

            }
        }
    }

    public class CraftItem
    {
        Loot output;
        Loot[] inputs;
        short time;

        public CraftItem(Loot output, Loot[] inputs, short time)
        {
            this.output = output;
            this.inputs = inputs;
            this.time = time;
        }

        public Loot Output { get => output; private set => output = value; }
        public Loot[] Inputs { get => inputs; private set => inputs = value; }
        public short Time { get => time; private set => time = value; }
    }

    //class Craft
    //{
    //    static Craft[] crafts;

    //    Loot output;

    //    static Craft()
    //    {
    //        crafts = new Craft[200];
    //    }

    //    public Craft(Loot output, ItemTag[] inputs, ItemTag[] tools)
    //    {
    //        Output = output;
    //        Inputs = inputs;
    //        Tools = tools;
    //    }

    //    public Loot Output { get => output; private set => output = value; }
    //    public ItemTag[] Inputs { get => inputs; private set => inputs = value; }
    //    public ItemTag[] Tools { get => tools; private set => tools = value; }

    //    public Loot Make(Loot[] loots)
    //    {
    //        return output;
    //    }
    //}

    //class CraftItem
    //{
    //    public virtual bool Check()
    //    {

    //    }
    //}

    //class CraftItem : CraftItem
    //{
    //    ItemTag tag;
    //    short count;

    //    public override bool Check()
    //    {
    //        return base.Check();
    //    }
    //}

    //class Craft : CraftItem
    //{
    //    ItemTag[] tags;

    //    public override bool Check()
    //    {
    //        return base.Check();
    //    }
    //}


    //class Craft
}
