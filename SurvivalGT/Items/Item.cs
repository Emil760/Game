using SurvivalGT.Utility;
using System;

namespace SurvivalGT.Items
{
    public enum ItemTag
    {
        /// <summary>
        /// Food
        /// </summary>
        Apple,
        AppleBrandy,
        BeefCan,
        Bread,
        BoiledPasta,
        BoiledRice,
        CondensedMilk,
        Crusmbs,
        Coffee,
        CoffeeCold,
        CoffeHot,
        Cutlet,
        CutletRice,
        Flour,
        Crumbs,
        Honey,
        Salo,
        Tea,
        TeaHot,
        TeaCold,
        Salt,
        MarinatedVegetables,
        Pasta,
        Pepsi,
        Rice,
        FreshMeat,
        FreshFish,
        DryMeat,
        DryFish,
        CleanWater,
        PoisonWater,
        DurtyWater,
        BackedMeat,
        BackedFish,
        BackedSalo,
        SaltedMeat,
        SaltedFish,
        RoutedFish,
        RoutedMeat,
        RoutedFood,
        RottenVegetables,
        Vodka,
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
        /// Materials
        /// </summary>
        Akumulator,
        AkumulatorBrocken,
        Books,
        Bone,
        Battery,
        Cartrige,
        Rags,
        Cloth,
        Coal,
        Component,
        Capsule,
        Electrodes,
        Fat,
        Flint,
        FlintBlade,
        Benzin,
        Gilza,
        Gunpowder,
        GasMaskFilter,
        Gear,
        Lead,
        Nail,
        Oil,
        Paper,
        Pipe,
        PreparedSkin,
        Provoloka,
        Rope,
        Rubber,
        Soap,
        Scrap,
        Saltpeter,
        Sulfur,
        SulfurAcid,
        SoilSaltpeter,
        SoilSulfur,
        Skin,
        String,
        Tape,
        Tire,
        Wire,
        Wood,
        WeaponsPart,
        TaningSolution,
        /// <summary>
        /// Weapon
        /// </summary>
        RifleAmmo,
        SniperAmmo,
        Arrow,
        SubmachineAmmo,
        PistolAmmo,
        Rpg7Ammo,
        TTPistol,
        Ak47,
        Ak47SpareParts,
        Rpg7,
        Pistol,
        Crossbow,
        Crossbow2,
        Grenade,
        Molotov,
        SelfmadeGrenade,
        SelfmadeGun,
        SelfmadeAmmo,
        Spear,
        Berdish,
        /// <summary>
        /// Medical
        /// </summary>
        ActivatedCarbon,
        Bandage,
        Spirt, // останавливаеи кровотечение 
        Chlorcystamine, // от радиации 
        Cigarettes,
        Metocaine, // от сна эффект не спит 2 дня
        Painkiller, // от травм
        HealingSalve, // для хп
        Protozepam, // для хп остновливает кровотечение
        DetoxPotion,
        EnergyPotion,
        Fleminсillin, // от поноса
        Tratodonide, // от радиации
        Bryocarm, // дает хп 
        MixedAlcohol,
        /// <summary>
        ///  //Bag
        /// </summary>
        Bag1,
        Bag2,
        Bag3,
        Bag4,
        /// <summary>
        /// Mask
        /// </summary>
        Gasmask1,
        Gasmask2,
        Gasmask3,
        HomemadeResperator,
        /// <summary>
        /// Cloth
        /// </summary>
        HomemadeCloth,
        LeatherCloth,
        MilitaryCloth,
        MotorwayCloth,
        IronCloth,
        /// <summary>
        /// Tools
        /// </summary>
        Axe,
        Knife,
        FlintAxe,
        FlintKnife,
        Matches,
        FishingRod,
        Flashlight,
        SelfmadeNeadle,
        Instruments,
        Instruments2,
        Can,
        Pan,
        Torch,
        /// <summary>
        /// Transport
        /// </summary>
        Bike,
        Motocycle,
        Zaz,
        /// <summary>
        /// Aniamls
        /// </summary>
        BearCorpse,
        BoarCorpse,
        FishCorpse,
        RatCorpse,
        WolfCorpse,
        /// <summary>
        /// Books
        /// </summary>
        BookChemistry,
        BookDriving,
        BookMechanics,
        BookMelle,
        BookSewing,
        BookShoot
    }

    public class Item : ObserableObject, ICloneable
    {
        protected ItemTag tag;
        protected string name;
        protected float weight;
        protected string path;

        public Item()
        {

        }

        public Item(ItemTag tag, string name, float weight, string path)
        {
            this.tag = tag;
            this.name = name;
            this.weight = weight;
            Path = path;
        }

        public ItemTag Tag { get => tag; }
        public string Name { get => name; }
        public float Weight { get => weight; }
        public string Path { get => path; private set => Set(ref path, value); }

        public virtual object Clone()
        {
            return this.Clone();
        }
    }
}
