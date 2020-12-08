using SurvivalGT.Models;

namespace SurvivalGT.Items
{
    static class ItemFactory
    {
        private static Item[] items;

        static ItemFactory()
        {
            items = new Item[200];

            items[0] = new Item(ItemTag.Akumulator, "Akumulator", 25, "/images/components/accumulator.png");

            items[1] = new Item(ItemTag.AkumulatorBrocken, "Brocken Akumulator", 25, "images/components/broken_battery.png");

            items[2] = new Item(ItemTag.Battery, "Battery", 0.05f, "images/components/battery.png");

            items[3] = new Item(ItemTag.Bone, "Bone", 0.2f, "/images/components/bone.png");

            items[4] = new Item(ItemTag.Benzin, "Benzin", 0.001f, "images/components/gas.png");

            items[5] = new Tool(ItemTag.Axe, "Axe", 2, "/images/tools/axe.png", 200);

            items[6] = new Tool(ItemTag.Instruments, "Instruments", 2f, "/images/tools/instruments.png", 100);

            items[6] = new Item(ItemTag.Ak47SpareParts, "Ak47 spare parts", 0.4f, "/images/weapons/ak47_spare_parts.png");

            items[7] = new Item(ItemTag.Oil, "Oil", 0.001f, "/images/components/oil.png");

            items[6] = new RangeWeapon(ItemTag.Ak47, "Ak47", 2.2f, "/images/weapons/ak47.png", 2, 100, 200, 450,
                new Loot[] { new Loot(GetItem(ItemTag.Instruments), 1), new Loot(GetItem(ItemTag.Oil), 50), new Loot(GetItem(ItemTag.Ak47SpareParts), 2) });

            items[7] = new Item(ItemTag.String, "a", 1, "a");
        }

        public static Item GetItem(ItemTag tag)
        {
            for (int i = 0; i < items.Length; i++)
                if (items[i].Tag == tag)
                    return items[i];
            return null;
        }
    }

    //items[4] = new Item(ItemTag.Books, "Books", 150, "images/components/books.png");

    //items[5] = new Item(ItemTag.Benzin, "Benzin", 1, "images/components/gas.png");

    //items[6] = new Item(ItemTag.Can, "Can", 100, "images/components/can.png");

    //items[7] = new Item(ItemTag.Capsule, "Capsule", 10, "images/components/capsule.png");

    //items[8] = new Item(ItemTag.Cartrige, "Cartrige", 10, "images/components/cartridge_d4.png");

    //items[9] = new Item(ItemTag.Cloth, "Cloth", 50, "images/components/cloth.png");

    //items[10] = new Item(ItemTag.Coal, "Coal", 150, "images/components/coal.png");

    //items[11] = new Item(ItemTag.Flint, "Flint", 200, "images/components/flint.png");

    //items[12] = new Item(ItemTag.FlintBlade, "Flint blade", 150, "images/components/flint_blade.png");

    //items[13] = new Item(ItemTag.Gilza, "Gilza", 10, "images/components/gilza.png");

    //items[14] = new Item(ItemTag.Gear, "Gear", 1000, "images/components/gears.png");

    //items[15] = new Item(ItemTag.GasMaskFilter, "Gas mask filter", 100, "images/components/gasmask_filter.png");

    //items[16] = new Item(ItemTag.Gunpowder, "Gunpowder", 1, "images/materials/gunpowder.png");

    //items[17] = new Item(ItemTag.Lead, "Lead", 1, "images/materials/lead.png");

    //items[18] = new Item(ItemTag.Nail, "Nail", 20, "images/materials/nail.png");

    //items[19] = new Item(ItemTag.Oil, "Oil", 1, "images/materials/oil.png");

    //items[20] = new Item(ItemTag.Paper, "Paper", 10, "images/materials/paper.png");

    //items[21] = new Item(ItemTag.Pipe, "Pipe", 1500, "images/materials/pipe.png");

    //items[22] = new Item(ItemTag.PreparedSkin, "Prepared skin", 1500, "images/materials/prepared_skin.png");

    //items[23] = new Item(ItemTag.Rope, "Rope", 500, "images/materials/rope.png");

    //items[24] = new Item(ItemTag.Rubber, "Rubber", 50, "images/materials/rubber.png");

    //items[25] = new Item(ItemTag.Scrap, "Scrap", 1, "images/materials/scrap.png");

    //items[26] = new Item(ItemTag.Skin, "Skin", 2500, "images/materials/animal_skin.png");

    //items[27] = new Item(ItemTag.Soap, "Soap", 150, "images/materials/soap.png");

    //items[28] = new Item(ItemTag.Saltpeter, "Saltpeter", 1, "images/materials/saltpeter.png");

    //items[29] = new Item(ItemTag.SoilSaltpeter, "Soil saltpeter", 1000, "images/materials/soil_saltpeter.png");

    //items[30] = new Item(ItemTag.SoilSulfur, "Solid sulfur", 1000, "images/materials/soil_sulfur.png");

    //items[31] = new Item(ItemTag.String, "String", 1, "images/materials/string.png");

    //items[32] = new Item(ItemTag.Sulfur, "Sulfur", 1, "images/materials/sulfur.png");

    //items[33] = new Item(ItemTag.SulfurAcid, "Sulfur acid", 100, "images/materials/sulfuric_acid.png");

    //items[34] = new Item(ItemTag.TaningSolution, "Tannig solution", 250, "images/materials/tanning_solution.png");

    //items[35] = new Item(ItemTag.Tape, "Tape", 50, "images/materials/tape.png");

    //items[36] = new Item(ItemTag.Tire, "Tire", 3000, "images/materials/tire.png");

    //items[37] = new Item(ItemTag.Wire, "Wire", 50, "images/materials/provoloka.png");

    //items[38] = new Item(ItemTag.Wood, "Wood", 2000, "images/materials/wood.png");

    //items[39] = new Item(ItemTag.WeaponsPart, "Weapons part", 1000, "images/materials/weapons_parts.png");

    //items[40] = new Tool(ItemTag.Axe, "Axe", 2000, "/images/tools/axe.png", 150);

    //armors[0] = new Armor(ItemTag.HomemadeCloth, "Homemade cloth", 1000, "images/equipment/handmade_clothes.png", 100, 50);

    //armors[1] = new Armor(ItemTag.LeatherCloth, "Leather cloth", 2000, "images/equipment/leather_armor.png", 150, 100);

    //armors[2] = new Armor(ItemTag.MotorwayCloth, "Motorway cloth", 4000, "images/equipment/motorway_armor.png", 200, 250);

    //armors[3] = new Armor(ItemTag.MilitaryCloth, "Military cloth", 4500, "images/equipment/military_armor.png", 300, 300);

    //armors[4] = new Armor(ItemTag.IronCloth, "Iron cloth", 5500, "images/equipment/steel_armor.png", 350, 450);

    //bags[0] = new Bag(ItemTag.Bag1, "Simple bag", 500, "images/equipment/bag0.png", 100, 15000);

    //bags[1] = new Bag(ItemTag.Bag2, "School bag", 800, "images/equipment/bag1.png", 200, 25000);

    //bags[2] = new Bag(ItemTag.Bag3, "Bag", 1200, "images/equipment/bag2.png", 350, 35000);

    //bags[3] = new Bag(ItemTag.Bag4, "Tourist bag", 1500, "images/equipment/bag3.png", 500, 50000);

    //eat_foods[0] = new EatFood(ItemTag.Apple, "Apple", 100, "images/food/apple.png", 2, 20, 10, 0, 144);

    //eat_foods[1] = new EatFood(ItemTag.AppleBrandy, "Apple brandy", 150, "images/food/apple_brandy.png", 3, 0, 30, 10, 1440);

    //eat_foods[2] = new EatFood(ItemTag.BackedFish, "Backed fish", 250, "images/food/fried_fish.png", 0, 25, 0, 0, 144);

    //eat_foods[3] = new EatFood(ItemTag.BackedMeat, "Backed meat", 400, "images/food/fryed_meat.png", 0, 50, -5, 0, 144);

    //eat_foods[4] = new EatFood(ItemTag.BackedSalo, "Backed salo", 250, "images/food/smoked_salo.png", 2, 25, 0, 0, 720);

    //eat_foods[5] = new EatFood(ItemTag.BeefCan, "Beef can", 200, "images/food/beef_can.png", 0, 30, 0, 0, 4320);

    //eat_foods[6] = new EatFood(ItemTag.BoiledPasta, "Boiled pasta", 350, "images/food/boiled_pasta.png", 0, 30, 15, 0, 72);

    //eat_foods[7] = new EatFood(ItemTag.BoiledRice, "Boiled rice", 350, "images/food/boiled_rice.png", 0, 35, 20, 0, 72);

    //eat_foods[8] = new EatFood(ItemTag.Bread, "Bread", 500, "images/food/bread.png", 10, 100, 0, 0, 120);

    //eat_foods[9] = new EatFood(ItemTag.CleanWater, "Clean water", 500, "images/food/bottled_water.png", 0, 0, 30, 2, 336);

    //eat_foods[10] = new EatFood(ItemTag.CoffeeCold, "Cold Coffe", 250, "images/food/coffee_cold.png", 0, 0, 30, 0, 24);

    //eat_foods[11] = new EatFood(ItemTag.CoffeHot, "Hot coffee", 250, "images/food/coffee_hot.png", 0, 0, 30, 30, 24);

    //eat_foods[12] = new EatFood(ItemTag.CondensedMilk, "Condensed milk", 300, "images/food/condensed_milk.png", 0, 80, 0, 0, 4320);

    //eat_foods[13] = new EatFood(ItemTag.Crumbs, "Crumbs", 100, "images/food/crumbs.png", 0, 10, -5, 0, 1440);

    //eat_foods[14] = new EatFood(ItemTag.Cutlet, "Cutlet", 350, "images/food/cutlet_meat.png", 0, 50, -5, 0, 144);

    //eat_foods[15] = new EatFood(ItemTag.CutletRice, "Rice cutlet", 450, "images/foodcutlet_rice.png", 0, 80, 0, 0, 144);

    //eat_foods[16] = new EatFood(ItemTag.DryFish, "Dry fish", 300, "images/food/dry_fish.png", 0, 40, -10, 0, 2160);

    //eat_foods[17] = new EatFood(ItemTag.DryMeat, "Dry meat", 500, "images/food/dry_meat.png", 0, 70, -10, 0, 2160);

    //eat_foods[18] = new EatFood(ItemTag.Honey, "Honey", 400, "images/food/honey.png", 15, 100, 50, 15, 8640);

    //eat_foods[19] = new EatFood(ItemTag.Pepsi, "Pepsi", 250, "images/food/pepsi.png", 0, 0, 50, 10, 720);

    //eat_foods[20] = new EatFood(ItemTag.SaltedFish, "Salted fish", 400, "images/food/salted_fish.png", 0, 40, -10, 0, 720);

    //eat_foods[21] = new EatFood(ItemTag.SaltedMeat, "Salted meat", 500, "images/foodsalted_meat.png", 0, 70, -10, 0, 720);

    //eat_foods[22] = new EatFood(ItemTag.TeaCold, "Cold tea", 250, "images/food/tea_cold.png", 0, 0, 80, 0, 24);

    //eat_foods[23] = new EatFood(ItemTag.TeaHot, "Hot tea", 250, "images/food/tea_hot.png", 0, 0, 80, 20, 24);

    //raw_foods[0] = new RawFood(ItemTag.BlackMushroom, "Black mushroom", 150, "images/food/black_mushroom.png", 10, 10, 8, 20);

    //raw_foods[1] = new RawFood(ItemTag.BlueMushroom, "Blue mushroom", 150, "imagesfoodblue_mushroom.png", 10, 10, 8, 20);

    //raw_foods[2] = new RawFood(ItemTag.Coffee, "Coffee", 50, "images/food/coffee.png", 5, 5, -5, 5);

    //raw_foods[3] = new RawFood(ItemTag.DurtyWater, "Durty water", 500, "images/food/durty_water.png", 0, 30, 5, 15);

    //raw_foods[4] = new RawFood(ItemTag.Fat, "Fat", 100, "images/food/fat.png", 25, 5, 5, 10);

    //raw_foods[5] = new RawFood(ItemTag.Flour, "Flour", 200, "images/food/flour.png", 15, 0, 3, 10);

    //raw_foods[6] = new RawFood(ItemTag.FreshFish, "Fresh fish", 250, "images/food/fresh_fish.png", 25, -4, -8, 25);

    //raw_foods[7] = new RawFood(ItemTag.FreshMeat, "Fresh meat", 500, "images/food/fresh_meat.png", 40, -10, 10, 25);

    //raw_foods[8] = new RawFood(ItemTag.GreenMushroom, "Greeen mushroom", 150, "images/food/green_mushroom.png", 10, 10, 8, 20);

    //raw_foods[9] = new RawFood(ItemTag.LightBlueMushroom, "Light blue mushroom", 150, "images/food/lightblue_mushroom.png", 10, 10, 8, 20);

    //raw_foods[10] = new RawFood(ItemTag.OrangeMushroom, "Orange mushroom", 150, "images/food/orange_mushroom.png", 10, 10, 8, 20);

    //raw_foods[11] = new RawFood(ItemTag.Pasta, "Pasta", 200, "images/food/pasta.png", 25, 0, 3, 10);

    //raw_foods[12] = new RawFood(ItemTag.PoisonWater, "Poison water", 500, "images/food/poison_water.png", 0, 30, 10, 30);

    //raw_foods[13] = new RawFood(ItemTag.RedMushroom, "Red mushroom", 150, "images/food/red_mushroom.png", 10, 10, 8, 20);

    //raw_foods[14] = new RawFood(ItemTag.Rice, "Rice", 200, "images/food/rice.png", 15, 0, 3, 10);

    //raw_foods[15] = new RawFood(ItemTag.RottenVegetables, "Rotten vegetables", 150, "images/food/rotten_vegetable.png", 15, 3, 4, 15);

    //raw_foods[16] = new RawFood(ItemTag.Salo, "Salo", 100, "images/food/salo.png", 15, 0, 5, 15);

    //raw_foods[17] = new RawFood(ItemTag.Salt, "Salt", 5, "images/food/salt.png", 2, -2, 2, 5);

    //raw_foods[18] = new RawFood(ItemTag.Tea, "Tea", 50, "images/food/tea.png", 2, 2, -2, 5);

    //raw_foods[19] = new RawFood(ItemTag.VioletMushroom, "Violet mushroom", 150, "images/food/violet_mushroom.png", 10, 10, 8, 20);

    //raw_foods[20] = new RawFood(ItemTag.WhiteMushroom, "White mushroom", 150, "images/food/white_mushroom.png", 10, 10, 8, 20);

    //raw_foods[21] = new RawFood(ItemTag.YellowMushroom, "Yellow mushroom", 150, "images/food/yellow_mushroom.png", 10, 10, 8, 20);

    //masks[0] = new GasMask(ItemTag.HomemadeResperator, "Homemade resperator", 150, "images/equipment/handmade_respirator.png", 100, 20);

    //masks[1] = new GasMask(ItemTag.Gasmask1, "Gasmask level 1", 250, "images/equipment/gasmask1.png", 180, 30);

    //masks[2] = new GasMask(ItemTag.Gasmask2, "Gasmask level 2", 350, "images/equipment/gasmask2.png", 250, 40);

    //masks[3] = new GasMask(ItemTag.Gasmask3, "Gasmask level 3", 500, "images/equipment/gasmask3.png", 300, 50);

    //medecines[0] = new Medecine(ItemTag.ActivatedCarbon, "Activated carbon", 10, "images/medecine/activated_carbon.png", 5) { poison = -15, stamina = -5 };

    //medecines[1] = new Medecine(ItemTag.Bandage, "Bandage", 50, "images/medecine/bandage.png", 0) { bleeding = -5 };

    //medecines[2] = new Medecine(ItemTag.Bryocarm, "Bryocarm", 50, "images/medecine/bryocarm.png", 15) { health = 15 };

    //medecines[3] = new Medecine(ItemTag.DetoxPotion, "Detoxifying potion", 150, "images/medecine/detoxifying_potion.png", 10) { thirst = 20, poison = -8 };

    //medecines[4] = new Medecine(ItemTag.EnergyPotion, "Energy pothion", 150, "images/medecine/energizing_potion.png", 10) { thirst = 20, stamina = 10 };

    //medecines[5] = new Medecine(ItemTag.MixedAlcohol, "Mixed Alcohol", 150, "images/medecine/mixed_alcohol.png", 10) { stamina = -15, radiathion = -5, poison = -5 };

    //medecines[6] = new Medecine(ItemTag.Spirt, "Spirt", 100, "images/medecine/spirt.png", 0);

    //medecines[7] = new Medecine(ItemTag.Tratodonide, "Tratodonide", 50, "images/medecine/tratodonide.png", 15) { radiathion = -10 };

    //medecines[0] = new EffectMedecine(ItemTag.Chlorcystamine, "Chlorcystamine", 50, "images/medecine/chlorcystamine.png", 15, new SleepResistance()) { radiathion = -30, stamina = -10, thirst = -20 };

    //medecines[1] = new EffectMedecine(ItemTag.Cigarettes, "Cigarettes", 50, "images/medecine/cigarettes.png", 5, new SleepResistance()) { thirst = -5, stamina = 10 };

    //medecines[2] = new EffectMedecine(ItemTag.Fleminсillin, "Flemincilin", 50, "images/medecine/flemincillin.png", 5, new SleepResistance());

    //medecines[3] = new EffectMedecine(ItemTag.HealingSalve, "Healing salve", 50, "images/medecine/healing_salve.png", 10, new SleepResistance());

    //medecines[4] = new EffectMedecine(ItemTag.Metocaine, "Metocaine", 50, "images/medecine/metocaine.png", 10, new SleepResistance());

    //medecines[6] = new EffectMedecine(ItemTag.Protozepam, "Protezepam", 50, "images/medecine/protozepam.png", 15, new SleepResistance());

}
