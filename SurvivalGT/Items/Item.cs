using SurvivalGT.Models;
using SurvivalGT.Utility;
using System;

namespace SurvivalGT.Items
{
    public enum ItemType
    {
        Component,
        Food,
        Medecine,
        Weapon,
        Tool,
        Utility,
        Transport,
        Armor,
    }

    public enum ItemTag
    {
        /// <summary>
        /// Materials
        /// </summary>
        None,
        Akumulator,
        BrockenAkumulator,
        Acid,
        Books,
        Bone,
        Benzin,
        Battery,
        Blowball,
        Cartrige,
        Cloth,
        Coal,
        Component,
        Capsule,
        Explosivs,
        Electrodes,
        Flint,
        Gilza,
        Gas,
        Gunpowder,
        Filter,
        Gear,
        Herb,
        Lead,
        Nail,
        Nettle,
        Nightshade,
        Oil,
        Paper,
        Pipe,
        Poison,
        Rags,
        Rope,
        Rubber,
        Soap,
        Scrap,
        PreparedSkin,
        Saltpeter,
        Sulfur,
        SoilSaltpeter,
        SoilSulfur,
        Steel,
        String,
        SparkPlug,
        Skin,
        Tape,
        Table,
        TaningSolution,
        Tire,
        Wire,
        Wood,
        Ice,
        BicyleSpareParts,
        MotocycleSpareParts,
        SpareParts,
        /// <summary>
        /// Food
        /// </summary>
        Apple,
        BeefCan,
        Bread,
        Berries,
        BoiledBackwheat,
        BoiledPasta,
        BoiledRice,
        BackedSalo,
        Backwheat,
        Crumbs,
        Coffee,
        Cake,
        PreparedCoffe,
        MeatCutlet,
        Water,
        MeatDry,
        FishDry,
        DurtyWater,
        Doner,
        Flour,
        FriedMeat,
        FriedFish,
        FriedRat,
        FriedSnake,
        FreshRat,
        FreshSnake,
        FreshMeat,
        FreshFish,
        Fat,
        Jam,
        Honey,
        Kebab,
        Milk,
        PoisonWater,
        MarinatedVegetables,
        Pasta,
        Pepsi,
        Pickles,
        Rice,
        RadWater,
        RiceCutlet,
        RoutedFish,
        RoutedMeat,
        RoutedFood,
        RottenVegetables,
        RadMeat,
        RadFish,
        Salt,
        Salo,
        SaltedMeat,
        SaltedFish,
        SmokedSalo,
        Strawberry,
        Tea,
        PreparedTea,
        BlackMushroom,
        BlueMushroom,
        GreenMushroom,
        LightBlueMushroom,
        OrangeMushroom,
        RedMushroom,
        VioletMushroom,
        YellowMushroom,
        WhiteMushroom,
        /// <summary>
        /// Weapon
        /// </summary>
        Arrow,
        PistolAmmo,
        SubmachineAmmo,
        RifleAmmo,
        SniperAmmo,
        Rpg7Ammo,
        HandmadeBulkshot,
        HandmadeRocket,
        HandmadeAmmo,
        PistolCapsule,
        SubmachineCapsule,
        RifleCapsule,
        SniperCapsule,
        PistolSpareParts,
        RifleSpareParts,
        SniperSpareParts,
        Ak47,
        BrockenAk47,
        Dp,
        BrockenDp,
        Pistol,
        BrockenPistol,
        Pps42,
        BrockenPps42,
        Mosin,
        BrockenMosin,
        Rpg7,
        BrockenRpg7,
        SVD,
        BrockenSVD,
        Crossbow,
        Crossbow2,
        Grenade,
        HandmadeGrenade,
        Molotov,
        HandmadeGun,
        HandmadeLauncher,
        HandmadeShotgun,
        FlintSpear,
        Berdish,
        Club,
        IronBattleKnife,
        BattleKnife,
        /// <summary>
        /// Tools
        /// </summary>
        Axe,
        OldAxe,
        FlintAxe,
        SteelAxe,
        BladeFlint,
        СhimKit,
        Can,
        Crowbar,
        OldCrowbar,
        SteelCrowbar,
        HandmadeFishingRod,
        FishingRod,
        Flashlight,
        Fire,
        Hacksaw,
        OldHacksaw,
        HandmadeCandle,
        Matches,
        Instruments,
        OldInstruments,
        SteelInstruments,
        Knife,
        FlintKnife,
        SteelKnife,
        Lighter,
        HandmadeLighter,
        Pan,
        OldPan,
        SteelPan,
        Primus,
        EmptyPrimus,
        HandmadePrimus,
        EmptyHandmadePrimus,
        Shovel,
        SteelShovel,
        OldShovel,
        SleepingBag,
        Needle,
        SteelNeedle,
        HandmadeNeadle,
        Torch,
        WaterFilter,
        /// <summary>
        /// Medical
        /// </summary>
        ActivatedCarbon,
        Bandage,
        Brendy,
        Bryocarm, // дает хп 
        Chlorcystamine, // от радиации 
        Cigarettes,
        Cigar,
        DetoxPotion,
        EnergyPotion,
        Prokozol,
        Fleminсillin, // от поноса
        HealingSalve, // для хп
        Injector,
        Kazotein,
        Lidiacide, // от сна
        Metocaine, // от сна эффект не спит 2 дня
        MixedAlcohol,
        Mutocaine,
        Painkiller, // от травм
        Protozepam, // для хп остновливает кровотечение
        Spirt, // останавливаеи кровотечение 
        Tratodonide, // от радиации
        Vodka,
        Wine,
        /// <summary>
        ///  //Bag
        /// </summary>
        HandmadeBag,
        Suitcase,
        Bag,
        MilitaryBag,
        TravelBag,
        /// <summary>
        /// Mask
        /// </summary>
        Gasmask1,
        BrockenGasmask1,
        EmptyGasmask1,
        Gasmask2,
        BrockenGasmask2,
        EmptyGasmask2,
        Gasmask3,
        BrockenGasmask3,
        EmptyGasmask3,
        Gasmask4,
        BrockenGasmask4,
        EmptyGasmask4,
        Respirator,
        HandmadeRespirator,
        /// <summary>
        /// Armor
        /// </summary>
        HandmadeArmor,
        LeatherArmor,
        MilitaryArmor,
        MotorwayArmor,
        SteelArmor,
        TankArmor,
        Hazmat,
        /// <summary>
        /// Transport
        /// </summary>
        Bicycle,
        BrockenBicycle,
        BrockenGas,
        DemoGas,
        Motocycle,
        DemoMotocycle,
        BrockenMotocycle,
        Uaz,
        BrockenUaz,
        DemoUaz,
        Vaz,
        DemoVaz,
        BrockenVaz,
        Zaz,
        BrockenZaz,
        DemoZaz,
        /// <summary>
        /// Aniamls
        /// </summary
        BearCorpse,
        RadBearCorpse,
        BoarCorpse,
        RadBoarCorpse,
        FishCorpse,
        RatCorpse,
        RadRatCorpse,
        WolfCorpse,
        RadWolfCorpse,
        LynxCorpse,
        RadLynxCorpse,
        SnakeCorpse,
        /// <summary>
        /// Books
        /// </summary>
        Book
    }

    public class Item : ObserableObject, ICloneable
    {
        protected ItemTag tag;
        protected ItemType type;
        protected string name;
        protected float weight;
        protected string path;

        public Item()
        {

        }

        public Item(ItemTag tag, string name, float weight, string path)
        {
            this.tag = tag;
            this.type = ItemType.Component;
            this.name = name;
            this.weight = weight;
            Path = path;
        }

        public Item(ItemTag tag, ItemType type, string name, float weight, string path)
            : this(tag, name, weight, path)
        {
            this.type = type;
        }

        public ItemTag Tag { get => tag; }
        public string Name { get => name; }
        public float Weight { get => weight; }
        public string Path { get => path; private set => path = value; }

        public virtual ILoot GetLoot(int count = 0)
        {
            return new LootItem(this, count);
        }

        public virtual object Clone()
        {
            return new Item(tag, type, name, weight, path);
        }
    }
}
