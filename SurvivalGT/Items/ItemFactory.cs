using SurvivalGT.Models;
using System.Collections.Generic;

namespace SurvivalGT.Items
{
    static class ItemFactory
    {
        private static Dictionary<ItemTag, Item> items;

        static ItemFactory()
        {
            items = new Dictionary<ItemTag, Item>();

            items.Add(ItemTag.Akumulator, new Item(ItemTag.Akumulator, "Akumulator", 25, "/images/components/accumulator.png"));
            items.Add(ItemTag.Acid, new Item(ItemTag.Acid, "Acid", 0.1f, "/images/components/acid.png"));
            items.Add(ItemTag.Battery, new Item(ItemTag.Battery, "Battery", 0.05f, "/images/components/battery.png"));
            items.Add(ItemTag.BlackMushroom, new Item(ItemTag.BlackMushroom, "Black mushroom", 0.03f, "/images/components/black_mushroom.png"));
            items.Add(ItemTag.Blowball, new Item(ItemTag.Blowball, "Blowball", 0.05f, "/images/components/blowball.png"));
            items.Add(ItemTag.BlueMushroom, new Item(ItemTag.BlueMushroom, "Blue mushroom", 0.03f, "/images/components/blue_mushroom.png"));
            items.Add(ItemTag.Bone, new Item(ItemTag.Bone, "Bone", 0.2f, "/images/components/bone.png"));
            items.Add(ItemTag.Capsule, new Item(ItemTag.Capsule, "Capsule", 0.005f, "/images/components/capsule.png"));
            items.Add(ItemTag.Coal, new Item(ItemTag.Coal, "Coal", 0.15f, "/images/components/coal.png"));
            items.Add(ItemTag.Explosivs, new Item(ItemTag.Explosivs, "Explosivs", 0.15f, "/images/components/explosivs.png"));
            items.Add(ItemTag.Filter, new Item(ItemTag.Filter, "Filter", 0.01f, "/images/components/filter.png"));
            items.Add(ItemTag.Flint, new Item(ItemTag.Flint, "Flint", 0.15f, "/images/components/flint.png"));
            items.Add(ItemTag.Gas, new Item(ItemTag.Gas, "Gas", 0.001f, "/images/components/gas.png"));
            items.Add(ItemTag.Gilza, new Item(ItemTag.Gilza, "Gilza", 0.005f, "/images/components/gilza.png"));
            items.Add(ItemTag.GreenMushroom, new Item(ItemTag.GreenMushroom, "Green mushroom", 0.03f, "/images/components/green_mushroom.png"));
            items.Add(ItemTag.Gunpowder, new Item(ItemTag.Gunpowder, "Gunpowder", 0.001f, "/images/components/gunpowder.png"));
            items.Add(ItemTag.Herb, new Item(ItemTag.Herb, "", 0.05f, "/images/components/herb.png"));
            items.Add(ItemTag.Ice, new Item(ItemTag.Ice, "Ice", 1, "/images/components/ice.png"));
            items.Add(ItemTag.Lead, new Item(ItemTag.Lead, "Lead", 0.001f, "/images/components/lead.png"));
            items.Add(ItemTag.LightBlueMushroom, new Item(ItemTag.LightBlueMushroom, "Light blue mushroom", 0.03f, "/images/components/lightblue_mushroom.png"));
            items.Add(ItemTag.Nettle, new Item(ItemTag.Nettle, "Nettle", 0.05f, "/images/components/nettle.png"));
            items.Add(ItemTag.Nightshade, new Item(ItemTag.Nightshade, "Night shade", 0.05f, "/images/components/nightshade.png"));
            items.Add(ItemTag.Oil, new Item(ItemTag.Oil, "Oil", 0.001f, "/images/components/oil.png"));
            items.Add(ItemTag.Paper, new Item(ItemTag.Paper, "Paper", 0.008f, "/images/components/paper.png"));
            items.Add(ItemTag.Poison, new Item(ItemTag.Poison, "Poison", 0.01f, "/images/components/poison.png"));
            items.Add(ItemTag.PreparedSkin, new Item(ItemTag.PreparedSkin, "Prepared skin", 1, "/images/components/prepared_skin.png"));
            items.Add(ItemTag.Rags, new Item(ItemTag.Rags, "Rags", 0.1f, "/images/components/rags.png"));
            items.Add(ItemTag.RedMushroom, new Item(ItemTag.RedMushroom, "Red mushroom", 0.03f, "/images/components/red_mushroom.png"));
            items.Add(ItemTag.Rubber, new Item(ItemTag.Rubber, "Rubber", 0.12f, "/images/components/rubber.png"));
            items.Add(ItemTag.SparkPlug, new Item(ItemTag.SparkPlug, "Spark plug", 20, "/images/components/spark_plug.png"));
            items.Add(ItemTag.Saltpeter, new Item(ItemTag.Saltpeter, "Saltpeter", 0.001f, "/images/components/saltpeter.png"));
            items.Add(ItemTag.Scrap, new Item(ItemTag.Scrap, "Scrap", 0.08f, "/images/components/scrap.png"));
            items.Add(ItemTag.Skin, new Item(ItemTag.Skin, "Skin", 0.15f, "/images/components/skin.png"));
            items.Add(ItemTag.Soap, new Item(ItemTag.Soap, "Soap", 0.1f, "/images/components/soap.png"));
            items.Add(ItemTag.SoilSaltpeter, new Item(ItemTag.SoilSaltpeter, "Soil saltpeter", 1, "/images/components/soil_saltpeter.png"));
            items.Add(ItemTag.SoilSulfur, new Item(ItemTag.SoilSulfur, "Soil sulfur", 1, "/images/components/soil_sulfur.png"));
            items.Add(ItemTag.Steel, new Item(ItemTag.Steel, "Steel", 0.15f, "/images/components/steel.png"));
            items.Add(ItemTag.String, new Item(ItemTag.String, "String", 0.003f, "/images/components/string.png"));
            items.Add(ItemTag.Sulfur, new Item(ItemTag.Sulfur, "Sulfur", 0.001f, "/images/components/sulfur.png"));
            items.Add(ItemTag.TaningSolution, new Item(ItemTag.TaningSolution, "Taning solution", 0.5f, "/images/components/tanning_solution.png"));
            items.Add(ItemTag.Tape, new Item(ItemTag.Tape, "Tape", 0.015f, "/images/components/tape.png"));
            items.Add(ItemTag.Tire, new Item(ItemTag.Tire, "Tire", 3, "/images/components/tire.png"));
            items.Add(ItemTag.VioletMushroom, new Item(ItemTag.VioletMushroom, "Violet mushroom", 0.03f, "/images/components/violet_mushroom.png"));
            items.Add(ItemTag.WhiteMushroom, new Item(ItemTag.WhiteMushroom, "White mushroom", 0.03f, "/images/components/white_mushroom.png"));
            items.Add(ItemTag.YellowMushroom, new Item(ItemTag.YellowMushroom, "Yellow mushroom", 0.03f, "/images/components/yellow_mushroom.png"));
            items.Add(ItemTag.Wood, new Item(ItemTag.Wood, "Wood", 1, "/images/components/wood.png"));
            items.Add(ItemTag.Wire, new Item(ItemTag.Wire, "Wire", 0.15f, "/images/components/wire.png"));

            items.Add(ItemTag.Tea, new Item(ItemTag.Tea, ItemType.Food, "Tea", 0.02f, "/images/food/tea.png"));
            items.Add(ItemTag.Salt, new Item(ItemTag.Salt, ItemType.Food, "Salt", 0.005f, "/images/food/salt.png"));
            items.Add(ItemTag.Salo, new Item(ItemTag.Salo, ItemType.Food, "Salo", 0.01f, "/images/food/salo.png"));
            items.Add(ItemTag.Rice, new Item(ItemTag.Rice, ItemType.Food, "Rice", 0.1f, "/images/food/rice.png"));
            items.Add(ItemTag.Pasta, new Item(ItemTag.Pasta, ItemType.Food, "Pasta", 0.1f, "/images/food/pasta.png"));
            items.Add(ItemTag.Backwheat, new Item(ItemTag.Backwheat, ItemType.Food, "Backwheat", 0.1f, "/images/food/backwheat.png"));
            items.Add(ItemTag.Coffee, new Item(ItemTag.Coffee, ItemType.Food, "Coffee", 0.02f, "/images/food/coffee.png"));
            items.Add(ItemTag.Flour, new Item(ItemTag.Flour, ItemType.Food, "Flour", 0.20f, "/images/food/flour.png"));


            items.Add(ItemTag.BeefCan, new Food(ItemTag.BeefCan, "Beef can", 0.25f, "/images/food/beef_can.png", 0, 40, 20, 0, 0, 0, 64800));
            items.Add(ItemTag.Berries, new Food(ItemTag.Berries, "Berries", 0.01f, "/images/food/berries.png", 0, 10, 5, 5, 3, 0, 10080));
            items.Add(ItemTag.BoiledBackwheat, new Food(ItemTag.BoiledBackwheat, "Boiled backwheat", 0.2f, "/images/food/boiled_backwheat.png", 5, 40, 25, 0, 0, 0, 2160));
            items.Add(ItemTag.BoiledPasta, new Food(ItemTag.BoiledPasta, "Boiled pasta", 0.2f, "/images/food/boiled_pasta.png", 5, 30, 15, 0, 0, 0, 2160));
            items.Add(ItemTag.BoiledRice, new Food(ItemTag.BoiledRice, "Boiled rice", 0.2f, "/images/food/boiled_rice.png", 5, 30, 25, 5, 0, 0, 2160));
            items.Add(ItemTag.Cake, new Food(ItemTag.Cake, "Cake", 0.2f, "/images/food/cake.png", 0, 25, 5, 2, 0, 0, 5040));
            items.Add(ItemTag.Bread, new Food(ItemTag.Bread, "Bread", 0.5f, "/images/food/bread.png", 15, 100, 20, 15, 0, 0, 5040));
            items.Add(ItemTag.Crumbs, new Food(ItemTag.Crumbs, "Crumbs", 0.05f, "/images/food/crumbs.png", 0, 15, -5, 0, 0, 0, 86400));
            items.Add(ItemTag.MeatCutlet, new Food(ItemTag.MeatCutlet, "Meat cutlet", 0.3f, "/images/food/meat_cutlet.png", 10, 60, 20, 5, 0, 0, 5040));
            items.Add(ItemTag.RiceCutlet, new Food(ItemTag.RiceCutlet, "Rice cutlet", 0.3f, "/images/food/rice_cutlet.png", 10, 60, 25, 10, 0, 0, 5040));
            items.Add(ItemTag.Doner, new Food(ItemTag.Doner, "Doner", 0.5f, "/images/food/doner.png", 25, 100, 100, 25, 0, 0, 2160));
            items.Add(ItemTag.Fat, new Food(ItemTag.Fat, "Fat", 0.01f, "/images/food/fat.png", -3, 10, 5, 0, 0, 0, 64800));
            items.Add(ItemTag.FreshFish, new PoisonFood(ItemTag.FreshFish, "Fresh fish", 0.2f, "/images/food/fresh_fish.png", 0, 15, 5, 0, 8, 2, 2160, 15, new Worms()));
            items.Add(ItemTag.FreshMeat, new PoisonFood(ItemTag.FreshMeat, "Fresh meat", 0.4f, "/images/food/fresh_meat.png", 0, 25, 5, 0, 10, 2, 2160, 15, new Worms()));
            items.Add(ItemTag.FreshRat, new PoisonFood(ItemTag.FreshRat, "Fresh rat", 0.1f, "/images/food/fresh_rat.png", 0, 10, 5, 0, 5, 2, 2160, 15, new Worms()));
            items.Add(ItemTag.FreshSnake, new PoisonFood(ItemTag.FreshSnake, "Fresh snake", 0.15f, "/images/food/fresh_snake.png", 0, 10, 5, 0, 10, 2, 2160, 15, new Worms()));
            items.Add(ItemTag.FriedFish, new Food(ItemTag.FriedFish, "Fried fish", 0.2f, "/images/food/fried_fish.png", 0, 25, 0, 0, 0, 0, 2160));
            items.Add(ItemTag.FriedMeat, new Food(ItemTag.FriedMeat, "Fried meat", 0.4f, "/images/food/fried_meat.png", 0, 40, 0, 0, 0, 0, 2160));
            items.Add(ItemTag.FriedRat, new Food(ItemTag.FriedRat, "Fried rat", 0.1f, "/images/food/fried_rat.png", 0, 20, 0, 0, 0, 0, 2160));
            items.Add(ItemTag.FriedSnake, new Food(ItemTag.FriedSnake, "Fried snake", 0.15f, "/images/food/fried_snake.png", 0, 30, 5, 0, 0, 0, 2160));
            items.Add(ItemTag.Honey, new Food(ItemTag.Honey, "Honey", 0.3f, "/images/food/honey.png", 10, 100, 50, 20, -50, -20, 259200));
            items.Add(ItemTag.Jam, new Food(ItemTag.Jam, "Jam", 0.3f, "/images/food/jam.png", 5, 100, 35, 30, 0, 0, 259200));
            items.Add(ItemTag.Kebab, new Food(ItemTag.Kebab, "Kebab", 0.5f, "/images/food/kebab.png", 25, 100, -10, 50, 0, 0, 2160));
            items.Add(ItemTag.MarinatedVegetables, new Food(ItemTag.MarinatedVegetables, "Marinated vegetables", 0.3f, "/images/food/marinated_vegetables.png", 10, 100, 100, 0, -10, 5, 259200));
            items.Add(ItemTag.Milk, new Food(ItemTag.Milk, "Milk", 0.2f, "/images/food/milk.png", 0, 75, 10, 5, 0, 0, 2592000));
            items.Add(ItemTag.Pepsi, new Food(ItemTag.Pepsi, "Pepsi", 0.5f, "/images/food/pepsi.png", 0, 0, 35, 20, 0, 0, 43200));
            items.Add(ItemTag.Pickles, new Food(ItemTag.Pickles, "Pickles", 1, "/images/food/pickles.png", 10, 85, 45, 10, 0, 0, 259200));
            items.Add(ItemTag.PoisonWater, new PoisonFood(ItemTag.PoisonWater, "Poison water", 0.5f, "/images/food/poison_water.png", 0, 0, 35, 0, 10, 2, 21600, 10, new Worms()));
            items.Add(ItemTag.RadMeat, new PoisonFood(ItemTag.RadMeat, "Radiactive meat", 0.3f, "/images/food/radiactive_meat.png", 0, 35, 5, 0, 10, 5, 2160, 25, new Worms()));
            items.Add(ItemTag.RadWater, new PoisonFood(ItemTag.RadWater, "Radiactive water", 0.5f, "/images/food/radiactive_water.png", 0, 0, 35, 0, 10, 5, 2160, 25, new Worms()));
            items.Add(ItemTag.SaltedFish, new Food(ItemTag.SaltedFish, "Salted fish", 0.2f, "/images/food/salted_fish.png", 0, 25, -5, 0, 0, 0, 64800));
            items.Add(ItemTag.SaltedMeat, new Food(ItemTag.SaltedMeat, "Salted meat", 0.4f, "/images/food/salted_meat.png", 0, 35, -5, 0, 0, 0, 64800));
            items.Add(ItemTag.SmokedSalo, new Food(ItemTag.SmokedSalo, "Smoked salo", 0.15f, "/images/food/smoked_salo.png", 5, 25, 10, 5, 0, -2, 64800));
            items.Add(ItemTag.Strawberry, new Food(ItemTag.Strawberry, "Strawberry", 0.01f, "/images/food/steawberry.png", 0, 10, 5, 5, -5, 0, 16200));
            items.Add(ItemTag.PreparedTea, new Food(ItemTag.PreparedTea, "Hot tea", 0.2f, "/images/food/hot_tea.png", 0, 0, 50, 30, -15, -15, 720));
            items.Add(ItemTag.Water, new Food(ItemTag.Water, "Water", 0.5f, "/images/food/water.png", 0, 0, 35, 0, -5, -2, 21600));


            items.Add(ItemTag.ActivatedCarbon, new Medecine(ItemTag.ActivatedCarbon, "Activated carbon", 0.01f, "/images/medecines/activated_carbon.png", 0, -3, -2, 0, -10, -1, 2));
            items.Add(ItemTag.Bandage, new Item(ItemTag.Bandage, ItemType.Medecine, "Bandage", 0.05f, "/images/medecines/bandage.png"));
            items.Add(ItemTag.Brendy, new Alco(ItemTag.Brendy, "Brendy", 1, "/images/medecines/brendy.png", -2, -5, 5, -5, -5, -2, 25, 1, new Worms(), 10));
            items.Add(ItemTag.Bryocarm, new MedecineEffect(ItemTag.Bryocarm, "Bryocarm", 0.03f, "/images/medecines/bryocarm.png", 40, -20, -20, -10, 0, 0, 5, new Healing()));
            items.Add(ItemTag.Chlorcystamine, new MedecineEffect(ItemTag.Chlorcystamine, "Chlorcystamine", 0.03f, "/images/medecines/chlorcystamine.png", 0, 0, -15, -50, -30, -100, 5, new Worms()));
            items.Add(ItemTag.Cigarettes, new Cigarette(ItemTag.Cigarettes, "Cigarettes", 0.02f, "/images/medecines/cigarettes.png", -2, -5, -5, 15, 5, 0, 25, 2, new Worms()));
            items.Add(ItemTag.Cigar, new Cigarette(ItemTag.Cigar, "Cigar", 0.04f, "/images/medecines/cigar.png", -2, -25, -25, 70, 5, 0, 25, 5, new Worms()));
            items.Add(ItemTag.DetoxPotion, new Potion(ItemTag.DetoxPotion, "Detox potion", 0.5f, "/images/medecines/detox_potion.png", 0, -2, 10, -3, -20, -5, 10));
            items.Add(ItemTag.EnergyPotion, new Potion(ItemTag.EnergyPotion, "Energy potion", 0.5f, "/images/medecines/energy_potion.png", 0, 0, 10, 35, 0, 0, 10));
            items.Add(ItemTag.HealingSalve, new Medecine(ItemTag.HealingSalve, "Healing salve", 0.02f, "/images/medecines/healing_salve.png", 25, 0, 0, 0, 0, 0, 1));
            items.Add(ItemTag.Lidiacide, new Medecine(ItemTag.Lidiacide, "Lidiacide", 0.01f, "/images/medecines/lidiacide.png", 0, 0, 0, 90, 0, 0, 2));
            items.Add(ItemTag.Metocaine, new MedecineEffect(ItemTag.Metocaine, "Metocaine", 0.02f, "/images/medecines/metocaine.png", 0, 50, 0, 0, 0, 0, 5, new Worms()));
            items.Add(ItemTag.MixedAlcohol, new Alco(ItemTag.MixedAlcohol, "Mixed alcohol", 0.5f, "/images/medecines/mixed_alcohol.png", -7, -5, 10, -10, -10, -2, 25, 8, new Worms(), 10));
            items.Add(ItemTag.Spirt, new Item(ItemTag.Spirt, ItemType.Medecine, "Spirt", 0.3f, "/images/medecines/spirt.png"));
            items.Add(ItemTag.Tratodonide, new Medecine(ItemTag.Tratodonide, "Tratodonide", 0.02f, "/images/medecines/tratodonide.png", 0, 0, 0, -5, -25, -90, 2));
            items.Add(ItemTag.Vodka, new Alco(ItemTag.Vodka, "Vodka", 0.5f, "/images/medecines/vodka.png", -5, -5, 10, -15, -15, -3, 25, 3, new Worms(), 10));
            items.Add(ItemTag.Wine, new Alco(ItemTag.Wine, "Wine", 0.5f, "/images/medecines/wine.png", -2, -5, 8, -8, -20, -5, 25, 1, new Worms(), 10));
            items.Add(ItemTag.Painkiller, new Item(ItemTag.Painkiller, ItemType.Medecine, "Painkiller", 0.01f, "/images/medecines/painkiller.png"));


            items.Add(ItemTag.WaterFilter, new Tool(ItemTag.WaterFilter, "Water filter", 0.07f, "/images/tools/water_filter.png", 25));
            items.Add(ItemTag.СhimKit, new Tool(ItemTag.СhimKit, "Сhemical laboratory", 3, "/images/tools/chim_kit.png", 100));

            items.Add(ItemTag.Axe, new OptionTool(ItemTag.Axe, "Axe", 2, "/images/tools/axe.png", 200, ItemTag.Axe));
            items.Add(ItemTag.Crowbar, new OptionTool(ItemTag.Crowbar, "Crowbar", 2, "/images/tools/crowbar.png", 30, ItemTag.Crowbar));
            items.Add(ItemTag.FlintAxe, new OptionTool(ItemTag.FlintAxe, "Flint axe", 1.5f, "/images/tools/flint_axe.png", 25, ItemTag.Axe));
            items.Add(ItemTag.FlintKnife, new OptionTool(ItemTag.FlintKnife, "Flint knife", 0.4f, "/images/tools/flint_knife.png", 25, ItemTag.Knife));
            items.Add(ItemTag.Hacksaw, new OptionTool(ItemTag.Hacksaw, "Hacksaw", 2, "/images/tools/hacksaw.png", 100, ItemTag.Hacksaw));
            items.Add(ItemTag.HandmadeNeadle, new OptionTool(ItemTag.HandmadeNeadle, "Handmade neadle", 0.005f, "/images/tools/handmade_needle.png", 10, ItemTag.Needle));
            items.Add(ItemTag.HandmadeLighter, new OptionTool(ItemTag.HandmadeLighter, "Handmade lighter", 0.05f, "/images/tools/handmade_light.png", 25, ItemTag.Lighter));
            items.Add(ItemTag.Instruments, new OptionTool(ItemTag.Instruments, "Tools", 2, "/images/tools/instruments.png", 200, ItemTag.Instruments));
            items.Add(ItemTag.Knife, new OptionTool(ItemTag.Knife, "Knife", 0.15f, "/images/tools/knife.png", 20, ItemTag.Knife));
            items.Add(ItemTag.Needle, new OptionTool(ItemTag.Needle, "Needle", 0.002f, "/images/tools/needle.png", 40, ItemTag.Needle));
            items.Add(ItemTag.Pan, new OptionTool(ItemTag.Pan, "Pan", 0.4f, "/images/tools/pan.png", 100, ItemTag.Pan));
            items.Add(ItemTag.Shovel, new OptionTool(ItemTag.Shovel, "Shovel", 2, "/images/tools/shovel.png", 50, ItemTag.Shovel));
            items.Add(ItemTag.SteelAxe, new OptionTool(ItemTag.SteelAxe, "Steel axe", 3, "/images/tools/steel_axe.png", 300, ItemTag.Axe));
            items.Add(ItemTag.SteelCrowbar, new OptionTool(ItemTag.SteelCrowbar, "Steel crowbar", 3, "/images/tools/steel_crowbar.png", 100, ItemTag.Crowbar));
            items.Add(ItemTag.SteelInstruments, new OptionTool(ItemTag.SteelInstruments, "Steel tools", 3, "/images/tools/steel_instruments.png", 300, ItemTag.Instruments));
            items.Add(ItemTag.SteelKnife, new OptionTool(ItemTag.SteelKnife, "Steel knife", 0.5f, "/images/tools/steel_knife.png", 150, ItemTag.Knife));
            items.Add(ItemTag.SteelNeedle, new OptionTool(ItemTag.SteelNeedle, "Steel needle", 0.005f, "/images/tools/steel_needle.png", 100, ItemTag.Needle));
            items.Add(ItemTag.SteelPan, new OptionTool(ItemTag.SteelPan, "Steel pan", 1, "/images/tools/steel_pan.png", 150, ItemTag.Pan));
            items.Add(ItemTag.SteelShovel, new OptionTool(ItemTag.SteelShovel, "Steel", 3, "/images/tools/steel_shovel.png", 150, ItemTag.Shovel));

            items.Add(ItemTag.BladeFlint, new Lighter(ItemTag.BladeFlint, "Blade flint", 0.1f, "/images/tools/blade_flint.png", 10));
            items.Add(ItemTag.Matches, new Lighter(ItemTag.Matches, "Matches", 0.015f, "/images/tools/matches.png", 10));
            items.Add(ItemTag.Lighter, new Lighter(ItemTag.Lighter, "Lighter", 0.02f, "/images/tools/lighter.png", 40));

            items.Add(ItemTag.OldPan, new OldTool(ItemTag.OldPan, "Old pan", 0.3f, "/images/tools/old_pan.png", ItemTag.Pan));
            items.Add(ItemTag.OldAxe, new OldTool(ItemTag.OldAxe, "Old axe", 2, "/images/tools/old_axe.png", ItemTag.Axe));
            items.Add(ItemTag.OldCrowbar, new OldTool(ItemTag.OldCrowbar, "Old crowbar", 1.5f, "/images/tools/old_crowbar.png", ItemTag.Crowbar));
            items.Add(ItemTag.OldShovel, new OldTool(ItemTag.OldShovel, "Old shovel", 2, "/images/tools/old_shovel.png", ItemTag.Shovel));
            items.Add(ItemTag.OldInstruments, new OldTool(ItemTag.OldInstruments, "Old tools", 2, "/images/tools/old_instruments.png", ItemTag.Instruments));
            items.Add(ItemTag.OldHacksaw, new OldTool(ItemTag.OldHacksaw, "Old hacksaw", 2, "/images/tools/old_hacksaw.png", ItemTag.Hacksaw));

            items.Add(ItemTag.Flashlight, new Flashlight(ItemTag.Flashlight, "Flashlight", 0.3f, "/images/tools/flashlight.png", 20, 10080, new Goods[] { new Goods(ItemTag.Battery, 1) }, 111));
            items.Add(ItemTag.HandmadeCandle, new Light(ItemTag.HandmadeCandle, "Handmade candle", 0.3f, "/images/tools/handmade_candle.png", 15, 4320));
            items.Add(ItemTag.Torch, new Light(ItemTag.Torch, "Torch", 1.5f, "/images/tools/torch.png", 15, 1440));

            items.Add(ItemTag.HandmadeFishingRod, new Fishingrod(ItemTag.HandmadeFishingRod, "Handmade fishing rod", 1.5f, "/images/tools/handmade_fishing_rod.png", 25,
                new Goods[] { }, 111));
            items.Add(ItemTag.FishingRod, new Fishingrod(ItemTag.FishingRod, "Fishing rod", 2.5f, "/images/tools/fishingrod.png", 111,
                new Goods[] { new Goods(ItemTag.Wire, 5), new Goods(ItemTag.Scrap, 10), new Goods(ItemTag.Rags, 3), new Goods(ItemTag.Instruments, 1) }, 111));


            items.Add(ItemTag.HandmadeArmor, new Armor(ItemTag.HandmadeArmor, "Handmade armor", 1.5f, "/images/armors/handmade_armor.png", 100, 100,
                new Goods[] { }, 111));
            items.Add(ItemTag.MilitaryArmor, new Armor(ItemTag.MilitaryArmor, "Military armor", 2.5f, "/images/armors/military_armor.png", 100, 200,
                 new Goods[] { }, 111));
            items.Add(ItemTag.MotorwayArmor, new Armor(ItemTag.MotorwayArmor, "Motorway armor", 3.5f, "/images/armors/motorway_armor.png", 100, 300,
                 new Goods[] { new Goods(ItemTag.Cloth, 15), new Goods(ItemTag.String, 5), new Goods(ItemTag.Tire, 1), new Goods(ItemTag.Wire, 3), new Goods(ItemTag.Needle, 1) }, 111));
            items.Add(ItemTag.LeatherArmor, new Armor(ItemTag.LeatherArmor, "Leather armor", 4, "/images/armors/leather_armor.png", 100, 380,
                new Goods[] { }, 111));
            items.Add(ItemTag.SteelArmor, new Armor(ItemTag.SteelArmor, "Steel armor", 5, "/images/armors/steel_armor.png", 100, 500,
                new Goods[] { }, 111));
            items.Add(ItemTag.TankArmor, new Armor(ItemTag.TankArmor, "Tank armor", 10, "/images/armors/tank_armor.png", 100, 1000,
                new Goods[] { }, 111));
            items.Add(ItemTag.Hazmat, new Armor(ItemTag.Hazmat, "Hazmat", 1.5f, "/images/armors/hazmat.png", 100, 150,
                new Goods[] { }, 111));


            items.Add(ItemTag.HandmadeBag, new Bag(ItemTag.HandmadeBag, "Handmade bag", 0.3f, "/images/bags/handmade_bag.png", 100, 15,
                new Goods[] { }, 111));
            items.Add(ItemTag.Suitcase, new Bag(ItemTag.Suitcase, "Suitcase", 0.8f, "/images/bags/suitcase.png", 100, 25,
                 new Goods[] { }, 111));
            items.Add(ItemTag.Bag, new Bag(ItemTag.Bag, "Bag", 1, "/images/bags/bag.png", 100, 35,
                new Goods[] { }, 111));
            items.Add(ItemTag.MilitaryBag, new Bag(ItemTag.MilitaryBag, "Military bag", 1.5f, "/images/bags/military_bag.png", 100, 45,
                new Goods[] { }, 111));
            items.Add(ItemTag.TravelBag, new Bag(ItemTag.TravelBag, "Travel bag", 2, "/images/bags/travel_bag.png", 100, 60,
                new Goods[] { }, 111));


            items.Add(ItemTag.Respirator, new Mask(ItemTag.Respirator, "Respirator", 0.2f, "/images/masks/respirator.png", 2, 5040));
            items.Add(ItemTag.HandmadeRespirator, new Mask(ItemTag.HandmadeRespirator, "Handmade respirator", 0.4f, "/images/masks/handmade_respirator.png", 2, 5040));

            items.Add(ItemTag.Gasmask1, new GasMask(ItemTag.Gasmask1, "Gas mask level 1", 0.3f, "/images/masks/gasmask1.png", "/images/masks/empty_gasmask1.png", 3, 5040,
                new Goods[] { new Goods(ItemTag.Filter, 1) }, 111));
            items.Add(ItemTag.Gasmask2, new GasMask(ItemTag.Gasmask2, "Gas mask level 2", 0.5f, "/images/masks/gasmask2.png", "/images/masks/empty_gasmask2.png", 4, 5040,
                new Goods[] { new Goods(ItemTag.Filter, 1) }, 111));
            items.Add(ItemTag.Gasmask3, new GasMask(ItemTag.Gasmask3, "Gas mask level 3", 0.8f, "/images/masks/gasmask3.png", "/images/masks/empty_gasmask3.png", 6, 5040,
                new Goods[] { new Goods(ItemTag.Filter, 1) }, 111));
            items.Add(ItemTag.Gasmask4, new GasMask(ItemTag.Gasmask4, "Gas mask level 4", 1, "/images/masks/gasmask4.png", "/images/masks/empty_gasmask4.png", 8, 5040,
                new Goods[] { new Goods(ItemTag.Filter, 1) }, 111));


            items.Add(ItemTag.SpareParts, new Item(ItemTag.SpareParts, "Spare parts", 1, "/images/transports/spare_parts.png"));
            items.Add(ItemTag.BicyleSpareParts, new Item(ItemTag.BicyleSpareParts, "Bicyle spare parts", 0.4f, "/images/transports/bicycle_spare_parts.png"));
            items.Add(ItemTag.MotocycleSpareParts, new Item(ItemTag.MotocycleSpareParts, "Motocycle spare parts", 0.6f, "/images/transports/motocycle_spare_parts.png"));


            items.Add(ItemTag.Bicycle, new Transport(ItemTag.Bicycle, "Bicycle", 15, "/images/transports/bicycle.png", 100, 30, 0, 8,
                new Goods[] { }, 111));
            items.Add(ItemTag.Motocycle, new Transport(ItemTag.Motocycle, "Motocycle", 100, "/images/transports/motocycle.png", 100, 150, 4, 15,
                new Goods[] { }, 111));
            items.Add(ItemTag.Zaz, new Transport(ItemTag.Zaz, "Zaz", 1000, "/images/transports/zaz.png", 100, 500, 8, 40,
                new Goods[] { new Goods(ItemTag.SpareParts, 2), new Goods(ItemTag.Oil, 250), new Goods(ItemTag.Tire, 2), new Goods(ItemTag.SparkPlug, 1), new Goods(ItemTag.Instruments, 1) }, 111));
            items.Add(ItemTag.Vaz, new Transport(ItemTag.Vaz, "Vaz", 2000, "/images/transports/vaz.png", 100, 950, 11, 65,
                new Goods[] { }, 111));
            items.Add(ItemTag.Uaz, new Transport(ItemTag.Uaz, "Uaz", 3500, "/images/transports/uaz.png", 100, 2000, 15, 55,
                new Goods[] { }, 111));


            items.Add(ItemTag.PistolCapsule, new Item(ItemTag.PistolCapsule, ItemType.Weapon, "Pistol capsule", 0.005f, "/images/weapons/pistol_capsule.png"));
            items.Add(ItemTag.PistolSpareParts, new Item(ItemTag.PistolSpareParts, ItemType.Weapon, "Pistol spare parts", 0.005f, "/images/weapons/pistol_spare_parts.png"));
            items.Add(ItemTag.RifleCapsule, new Item(ItemTag.RifleCapsule, ItemType.Weapon, "Rifle capsule", 0.005f, "/images/weapons/rifle_capsule.png"));
            items.Add(ItemTag.RifleSpareParts, new Item(ItemTag.RifleSpareParts, ItemType.Weapon, "Rifle spare parts", 0.005f, "/images/weapons/rifle_spare_parts.png"));
            items.Add(ItemTag.SniperCapsule, new Item(ItemTag.SniperCapsule, ItemType.Weapon, "Sniper capsule", 0.005f, "/images/weapons/sniper_capsule.png"));
            items.Add(ItemTag.SniperSpareParts, new Item(ItemTag.SniperSpareParts, ItemType.Weapon, "Sniper spare parts", 0.005f, "/images/weapons/sniper_spare_parts.png"));
            items.Add(ItemTag.Arrow, new Item(ItemTag.Arrow, ItemType.Weapon, "Arrow", 0.01f, "/images/weapons/arrow.png"));
            items.Add(ItemTag.HandmadeAmmo, new Item(ItemTag.HandmadeAmmo, ItemType.Weapon, "Handmade ammo", 0.01f, "/images/weapons/handmade_ammo.png"));
            items.Add(ItemTag.PistolAmmo, new Item(ItemTag.PistolAmmo, ItemType.Weapon, "Pistol ammo", 0.05f, "/images/weapons/pistol_ammo.png"));
            items.Add(ItemTag.RifleAmmo, new Item(ItemTag.RifleAmmo, ItemType.Weapon, "Rifle ammo", 0.01f, "/images/weapons/rifle_ammo.png"));
            items.Add(ItemTag.Rpg7Ammo, new Item(ItemTag.Rpg7Ammo, ItemType.Weapon, "Rpg7 ammo", 0.5f, "/images/weapons/rpg7_ammo.png"));
            items.Add(ItemTag.SniperAmmo, new Item(ItemTag.SniperAmmo, ItemType.Weapon, "Sniper ammo", 0.15f, "/images/weapons/sniper_ammo.png"));
            items.Add(ItemTag.HandmadeBulkshot, new Item(ItemTag.HandmadeBulkshot, "Handmade bulkshot", 0.03f, "/images/weapons/handmade_buckshot.png"));
            items.Add(ItemTag.HandmadeRocket, new Item(ItemTag.HandmadeRocket, "Handmade rocket", 1, "/images/weapons/handmade_rocket.png"));


            items.Add(ItemTag.Berdish, new MeleeWeapon(ItemTag.Berdish, "Berdish", 2.5f, "/images/weapons/berdish.png", 2, 40, 65, 100));
            items.Add(ItemTag.Club, new MeleeWeapon(ItemTag.Club, "Club", 2, "/images/weapons/club.png", 1, 20, 35, 100));
            items.Add(ItemTag.Grenade, new ExplosiveWeapon(ItemTag.Grenade, "Grenade", 0.5f, "/images/weapons/grenade.png", 2, 100, 150));
            items.Add(ItemTag.HandmadeGrenade, new ExplosiveWeapon(ItemTag.HandmadeGrenade, "Handmade greande", 0.5f, "/images/weapons/handmade_grenade.png", 2, 60, 90));
            items.Add(ItemTag.BattleKnife, new MeleeWeapon(ItemTag.BattleKnife, "Batlle knife", 0.3f, "/images/weapons/battle_knife.png", 1, 25, 45, 100));
            items.Add(ItemTag.IronBattleKnife, new MeleeWeapon(ItemTag.IronBattleKnife, "Iron battle knife", 0.5f, "/images/weapons/iron_knife_battle.png", 1, 45, 55, 100));
            items.Add(ItemTag.Molotov, new ExplosiveWeapon(ItemTag.Molotov, "Molotov", 0.5f, "/images/weapons/molotov.png", 2, 50, 75));
            items.Add(ItemTag.FlintSpear, new MeleeWeapon(ItemTag.FlintSpear, "Flint spear", 1.5f, "/images/weapons/flint_spear.png", 2, 20, 55, 100));

            items.Add(ItemTag.Ak47, new RangeWeapon(ItemTag.Ak47, "Ak47", 3, "/images/weapons/ak47.png", 3, 75, 100, ItemTag.RifleAmmo, 4, 100,
               new Goods[] { new Goods(ItemTag.RifleSpareParts, 2), new Goods(ItemTag.Oil, 100), new Goods(ItemTag.SpareParts, 2), new Goods(ItemTag.Rags, 5), new Goods(ItemTag.Instruments, 1) }, 111));
            items.Add(ItemTag.Crossbow, new RangeWeapon(ItemTag.Crossbow, "Crossbow", 1.5f, "/images/weapons/crossbow1.png", 2, 20, 45, ItemTag.Arrow, 2, 100,
                new Goods[] { }, 111));
            items.Add(ItemTag.Crossbow2, new RangeWeapon(ItemTag.Crossbow2, "Crossbow", 2.5f, "/images/weapons/crossbow2.png", 2, 35, 60, ItemTag.Arrow, 3, 100,
               new Goods[] { }, 111));
            items.Add(ItemTag.Dp, new RangeWeapon(ItemTag.Dp, "Dp", 3.5f, "/images/weapons/dp.png", 3, 80, 120, ItemTag.RifleAmmo, 3, 100,
                new Goods[] { }, 111));
            items.Add(ItemTag.HandmadeGun, new RangeWeapon(ItemTag.HandmadeGun, "Handmade gun", 1.5f, "/images/weapons/handmade_gun.png", 3, 55, 75, ItemTag.HandmadeAmmo, 3, 100,
                new Goods[] { }, 111));
            items.Add(ItemTag.Mosin, new RangeWeapon(ItemTag.Mosin, "Mosin", 3, "/images/weapons/mosin.png", 3, 150, 200, ItemTag.SniperAmmo, 5, 100,
                new Goods[] { }, 111));
            items.Add(ItemTag.Pistol, new RangeWeapon(ItemTag.Pistol, "Pistol", 1, "/images/weapons/pistol.png", 1, 25, 40, ItemTag.PistolAmmo, 2, 100,
               new Goods[] { }, 111));
            items.Add(ItemTag.Pps42, new RangeWeapon(ItemTag.Pps42, "Pps 42", 2.5f, "/images/weapons/pps42.png", 2, 45, 65, ItemTag.PistolAmmo, 3, 100,
               new Goods[] { }, 111));
            items.Add(ItemTag.Rpg7, new RangeWeapon(ItemTag.Rpg7, "Rpg7", 5, "/images/weapons/rpg7.png", 3, 300, 500, ItemTag.Rpg7Ammo, 4, 100,
                new Goods[] { }, 111));
            items.Add(ItemTag.SVD, new RangeWeapon(ItemTag.SVD, "Svd", 3.5f, "/images/weapons/svd.png", 3, 200, 300, ItemTag.SniperAmmo, 6, 100,
                new Goods[] { }, 111));
            items.Add(ItemTag.HandmadeShotgun, new RangeWeapon(ItemTag.HandmadeShotgun, "Handmade shotgun", 2.5f, "/images/weapons/handmade_shotgun.png", 3, 50, 75, ItemTag.HandmadeBulkshot, 2, 111,
                new Goods[] { }, 111));
            items.Add(ItemTag.HandmadeLauncher, new RangeWeapon(ItemTag.HandmadeLauncher, "Handmade laucher", 10, "/images/weapons/handmade_launcher.png", 3, 100, 175, ItemTag.HandmadeRocket, 4, 111,
                new Goods[] { }, 111));


            items.Add(ItemTag.Nail, new Recycleable(ItemTag.Nail, ItemType.Component, "Nail", 0.05f, "/images/components/nail.png", 111, new LootRandom[] { new LootRandom(ItemTag.Scrap, 0, 3) }));
            items.Add(ItemTag.Table, new Recycleable(ItemTag.Table, ItemType.Component, "Table", 10, "/images/components/table.png", 111, new LootRandom[] { new LootRandom(ItemTag.Wood, 3, 10) }));
            items.Add(ItemTag.Cloth, new Recycleable(ItemTag.Cloth, ItemType.Component, "Cloth", 0.5f, "/images/components/cloth.png", 111, new LootRandom[] { new LootRandom(ItemTag.Rags, 0, 5) }));
            items.Add(ItemTag.Rope, new Recycleable(ItemTag.Rope, ItemType.Component, "Rope", 0.3f, "/images/components/rope.png", 111, new LootRandom[] { new LootRandom(ItemTag.String, 25, 50) }));
            items.Add(ItemTag.BrockenGasmask1, new Recycleable(ItemTag.BrockenGasmask1, ItemType.Utility, "BrockenGasmask1", 0.3f, "/images/masks/brocken_gasmask1", 111, new LootRandom[] { new LootRandom(ItemTag.Filter, 0, 1) }));
            items.Add(ItemTag.BrockenGasmask2, new Recycleable(ItemTag.BrockenGasmask2, ItemType.Utility, "BrockenGasmask2", 0.4f, "/images/masks/brocken_gasmask2", 111, new LootRandom[] { new LootRandom(ItemTag.Filter, 0, 1) }));
            items.Add(ItemTag.BrockenGasmask3, new Recycleable(ItemTag.BrockenGasmask3, ItemType.Utility, "BrockenGasmask3", 0.5f, "/images/masks/brocken_gasmask3", 111, new LootRandom[] { new LootRandom(ItemTag.Filter, 0, 1) }));
            items.Add(ItemTag.BrockenGasmask4, new Recycleable(ItemTag.BrockenGasmask4, ItemType.Utility, "BrockenGasmask4", 0.6f, "/images/masks/brocken_gasmask4", 111, new LootRandom[] { new LootRandom(ItemTag.Filter, 0, 1) }));
            items.Add(ItemTag.Can, new Recycleable(ItemTag.Can, ItemType.Component, "Can", 0.3f, "/images/components/can.png", 111, new LootRandom[] { new LootRandom(ItemTag.Scrap, 0, 3) }));
            items.Add(ItemTag.Books, new Recycleable(ItemTag.Books, ItemType.Component, "Books", 0.5f, "/images/components/books.png", 111, new LootRandom[] { new LootRandom(ItemTag.Paper, 25, 50) }));
            items.Add(ItemTag.Pipe, new Recycleable(ItemTag.Pipe, ItemType.Component, "Pipe", 2, "/images/components/pipe.png", 111, new LootRandom[] { new LootRandom(ItemTag.Scrap, 10, 25) }));

            //items.Add(ItemTag.BearCorpse, new RecycleableComplex(ItemTag.BearCorpse, ItemType.Food, "Bear corpse", 100, "/images/animals/bear_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.RadBearCorpse, new RecycleableComplex(ItemTag.RadBearCorpse, ItemType.Food, "Radioactive Bear corpse", 100, "/images/animals/rad_bear_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BoarCorpse, new RecycleableComplex(ItemTag.BoarCorpse, ItemType.Food, "Boar corpse", 70, "/images/animals/boar_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.RadBoarCorpse, new RecycleableComplex(ItemTag.RadBoarCorpse, ItemType.Food, "Radioactive Boar corpse", 70, "/images/animals/rad_boar_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.LynxCorpse, new RecycleableComplex(ItemTag.LynxCorpse, ItemType.Food, "Lynx corpse", 50, "/images/animals/lynx_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.RadLynxCorpse, new RecycleableComplex(ItemTag.RadLynxCorpse, ItemType.Food, "Radioactive Lynx corpse", 50, "/images/animals/rad_lynx_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.RatCorpse, new RecycleableComplex(ItemTag.RatCorpse, ItemType.Food, "Rat corpse", 1, "/images/animals/rat_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.RadRatCorpse, new RecycleableComplex(ItemTag.RadRatCorpse, ItemType.Food, "Radioactive Rat corpse", 1, "/images/animals/rad_rat_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.SnakeCorpse, new RecycleableComplex(ItemTag.SnakeCorpse, ItemType.Food, "Snake corpse", 2, "/images/animals/snake_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.WolfCorpse, new RecycleableComplex(ItemTag.WolfCorpse, ItemType.Food, "Wolf corpse", 40, "/images/animals/wolf_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.RadWolfCorpse, new RecycleableComplex(ItemTag.RadWolfCorpse, ItemType.Food, "Radioactive Wolf corpse", 40, "/images/animals/rad_wolf_corpse.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenAkumulator, new RecycleableComplex(ItemTag.BrockenAkumulator, ItemType.Component, "Brocken akumulator", 25, "/images/components/brocken_akumulator.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.Cartrige, new RecycleableComplex(ItemTag.Cartrige, ItemType.Component, "Cartrige", 0.05f, "/images/components/cartrige.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenBicycle, new RecycleableComplex(ItemTag.BrockenBicycle, ItemType.Utility, "Brocken Bicycle", 25, "/images/transports/brocken_bicycle.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenMotocycle, new RecycleableComplex(ItemTag.BrockenMotocycle, ItemType.Utility, "Brocken Motocycle", 100, "/images/transports/",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenGas, new RecycleableComplex(ItemTag.BrockenGas, ItemType.Utility, "Brocken Gas", 1500, "/images/transports/brocken_gas.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenVaz, new RecycleableComplex(ItemTag.BrockenVaz, ItemType.Utility, "Brocken Vaz", 2500, "/images/transports/brocken_vaz.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenZaz, new RecycleableComplex(ItemTag.BrockenZaz, ItemType.Utility, "Brocken Zaz", 3500, "/images/transports/brocken_zaz.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenUaz, new RecycleableComplex(ItemTag.BrockenUaz, ItemType.Utility, "Brocken Uaz", 5000, "/images/transports/brocken_uaz.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenPistol, new RecycleableComplex(ItemTag.BrockenPistol, ItemType.Weapon, "Brocken Pistol", 1, "/images/weapons/brocken_pistol.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenPps42, new RecycleableComplex(ItemTag.BrockenPps42, ItemType.Weapon, "Brocken Pps42", 2.5f, "/images/weapons/brocken_pps42.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenAk47, new RecycleableComplex(ItemTag.BrockenAk47, ItemType.Weapon, "Brocken Ak47", 3, "/images/weapons/brocken_ak47.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenDp, new RecycleableComplex(ItemTag.BrockenDp, ItemType.Weapon, "Brocken Dp", 3.5f, "/images/weapons/brocken_dp.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenMosin, new RecycleableComplex(ItemTag.BrockenMosin, ItemType.Weapon, "Brocken Mosin", 3.5f, "/images/weapons/brocken_mosin.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenSVD, new RecycleableComplex(ItemTag.BrockenSVD, ItemType.Weapon, "Brocken SVD", 4, "/images/weapons/brocken_svd.png",
            //    new Loot[] { }, new LootRandom[] { }));
            //items.Add(ItemTag.BrockenRpg7, new RecycleableComplex(ItemTag.BrockenRpg7, ItemType.Weapon, "Brocken Rpg7", 8, "/images/weapons/",
            //    new Loot[] { }, new LootRandom[] { }));

            items.Add(ItemTag.Book, new Book(ItemTag.Book, "Book", 0.4f, "/images/books/book.png", 111, -15));
        }

        public static Item GetItem(ItemTag tag)
        {
            return items[tag];
        }
    }
}
