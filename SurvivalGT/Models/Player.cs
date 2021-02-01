using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Shapes;

namespace SurvivalGT.Models
{
    //put auto property if is needed
    public class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static Player instance;
        private Game game;

        private Inventory inventory;
        private LinkedList<Effect> effects;

        private double x;
        private double y;
        private double width;
        private double height;

        //test;
        private double actual_width;
        private double actual_height;
        public double ActualWidth { get => actual_width; private set => actual_width = value; }
        public double ActualHeight { get => actual_height; private set => actual_height = value; }

        private double speed;
        private DateTime date;

        private string name;
        private short max_hp;
        private float hp;
        private float hp_dec;
        private float hunger;
        private float hunger_dec;
        private float thirst;
        private float thirst_dec;
        private float stamina;
        private float stamina_dec;
        private float poison;
        private float poison_dec;
        private float radiation;
        private float radiation_dec;

        private float alco;
        private float smoking;
        private float overdose;

        private int max_weight;
        private int weight;
        private short seacrh;
        private short armor;

        private Player()
        {
            X = 3;
            Y = 3;
            Height = 40;
            Width = 40;
            Speed = 5;

            Date = new DateTime(1999, 1, 1, 0, 0, 0);

            MaxHp = 100;
            Hp = 100;
            HpDec = 0;
            Thirst = 100;
            ThirstDec = 15;
            Hunger = 100;
            HungerDec = 10;
            Stamina = 100;
            StaminaDec = 8;
            Poison = 0;
            PoisonDec = 0;
            Radiation = 0;
            RadiationDec = 0;

            Weight = 20000;
            Armor = 0;

            inventory = new Inventory();
            game = Game.Instance;
        }

        public static Player Instance
        {
            get
            {
                if (instance == null) instance = new Player();
                return instance;
            }
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public double Speed { get => speed; set => speed = value; }
        public DateTime Date { get => date; set => date = value; }

        public string Name { get => name; }
        public short MaxHp { get => max_hp; set => max_hp = value; }

        public float Hp
        {
            get => hp;
            set
            {
                if (value <= 0)
                {
                    if (hp == 0) return;
                    hp = 0;
                }
                else if (value >= 100)
                {
                    if (hp == 100) return;
                    hp = 100;
                }
                else hp = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hp"));
            }
        }
        public float HpDec { get => hp_dec; set => hp_dec = value; }

        public float Hunger
        {
            get => hunger;
            set
            {
                if (value <= 0)
                {
                    if (hunger == 0) return;
                    hunger = 0;
                }
                else if (value >= 100)
                {
                    if (hunger == 100) return;
                    hunger = 100;
                }
                else hunger = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hunger"));
            }
        }
        public float HungerDec { get => hunger_dec; set => hunger_dec = value; }

        public float Thirst
        {
            get => thirst;
            set
            {
                if (value <= 0)
                {
                    if (thirst == 0) return;
                    thirst = 0;
                }
                else if (value >= 100)
                {
                    if (thirst == 100) return;
                    thirst = 100;
                }
                else thirst = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Thirst"));
            }
        }
        public float ThirstDec { get => thirst_dec; set => thirst_dec = value; }

        public float Stamina
        {
            get => stamina;
            set
            {
                if (value <= 0)
                {
                    if (stamina == 0) return;
                    stamina = 0;
                }
                else if (value >= 100)
                {
                    if (stamina == 100) return;
                    stamina = 100;
                }
                else stamina = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Stamina"));
            }
        }
        public float StaminaDec { get => stamina_dec; set => stamina_dec = value; }

        public float Poison
        {
            get => poison;
            set
            {
                if (value <= 0)
                {
                    if (poison == 0) return;
                    poison = 0;
                }
                else poison = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison"));
            }
        }
        public float PoisonDec { get => poison_dec; set => poison_dec = value; }

        public float Radiation
        {
            get => radiation;
            set
            {
                if (radiation <= 0)
                {
                    if (radiation == 0) return;
                    radiation = 0;
                }
                else radiation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Radiation"));
            }
        }
        public float RadiationDec { get => radiation_dec; set => radiation_dec = value; }

        public float Alco { get => alco; set => alco = value; }
        public float Smoking { get => smoking; set => smoking = value; }
        public float Overdose { get => overdose; set => overdose = value; }

        public int MaxWeight { get => max_weight; set => max_weight = value; }

        public int Weight { get => weight; set => weight = value; }

        public short Armor { get => armor; set => armor = value; }

        public short Seacrh { get => seacrh; set => seacrh = value; }

        public Inventory Inventory { get => inventory; }

        public LinkedList<Effect> Effects { get => effects; set => effects = value; }


        public void Decrease()
        {
            Hp -= hp_dec / game.Fps / game.Minute;
            Radiation -= radiation_dec / game.Fps / game.Minute;
            Poison -= poison_dec / game.Fps / game.Minute;
            Hunger -= hunger_dec / game.Fps / game.Minute;
            Thirst -= thirst_dec / game.Fps / game.Minute;
            Stamina -= stamina_dec / game.Fps / game.Minute;
            date = date.AddMinutes(game.Minute);
        }

        public void EffectFinished(Effect effect)
        {
            effects.Remove(effect);
            effect.Leave(this);
        }

        public void Set<T>(ref T prop, T value, [System.Runtime.CompilerServices.CallerMemberName] string prop_name = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop_name));
        }
    }
}
