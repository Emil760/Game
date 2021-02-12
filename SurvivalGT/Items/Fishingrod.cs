using SurvivalGT.Interfacies;
using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    class Fishingrod : Tool, IRepairable
    {
        private static Goods[] baits;
        private Goods[] repair_materials;
        private ItemTag[] repair_options;
        private int repair_time;

        static Fishingrod()
        {
            baits = new Goods[9];
            baits[0] = new Goods(ItemTag.Crumbs, 1);
            baits[1] = new Goods(ItemTag.FreshMeat, 4);
            baits[2] = new Goods(ItemTag.FreshFish, 2);
            baits[3] = new Goods(ItemTag.FreshSnake, 3);
            baits[4] = new Goods(ItemTag.FreshRat, 5);
            baits[5] = new Goods(ItemTag.FriedMeat, 3);
            baits[6] = new Goods(ItemTag.FriedFish, 1);
            baits[7] = new Goods(ItemTag.FriedSnake, 2);
            baits[8] = new Goods(ItemTag.FriedRat, 3);
        }

        public Fishingrod(ItemTag tag, string name, float weight, string path, int durability, Goods[] repair_materials, int repair_time)
            : base(tag, name, weight, path, durability)
        {
            this.repair_materials = repair_materials;
            this.repair_time = repair_time;
        }

        public static Goods[] Baits { get => baits; }

        public Goods[] RepairGoods { get => repair_materials; }

        public int RepairTime { get => repair_time; }

        public void Repair(Inventory inventory, CraftItem[] crafts)
        {
            //if (current_durability == durability) return;

            //for (int i = 0; i < repair_materials.Length; i++)
            //{
            //    if (!materials_craft[i].Loot.Check(materials_craft[i].Count)) return;
            //}
            //for (int i = 0; i < repair_options.Length; i++)
            //{
            //    if (!options_craft[i].Loots.First.Value.Check(options_craft[i].Count)) return;
            //}

            //for (int i = 0; i < repair_materials.Length; i++)
            //{
            //    materials_craft[i].Loot.Use(materials_craft[i].Count, inventory);
            //}
            //for (int i = 0; i < repair_options.Length; i++)
            //{
            //    options_craft[i].Loots.First.Value.Use(1, inventory);
            //}

            //if (durability - current_durability < 20) CurrentDurability += durability - current_durability;
            //else CurrentDurability += 20;
        }

        public void CatchFish(int count, Inventory inventory)
        {

        }
    }
}
