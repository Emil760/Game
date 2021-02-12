﻿using System;
using SurvivalGT.Items;
using System.Collections.Generic;
using SurvivalGT.Interfacies;

namespace SurvivalGT.Models
{
    public interface ILoot
    {
        Item Item { get; }
        
        int Count { get; set; }
        
        int CountUse { get; }
        
        int GetCountUse();
        
        void Take(Inventory inventory);

        LootItem Drop(Inventory inventory);

        LootItem Drop(Inventory inventory, int count);

        bool Check(int count, int? time = null);

        int Check(int count, int times = 1, int? time = null);

        void Use(Inventory inventory, int count);
    }

    public class LootItem : ILoot, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected Item item;
        protected int count;

        public LootItem(Item item, int count)
        {
            this.item = item;
            this.count = count;
        }

        public Item Item { get => item; }
        public int Count { get => count; set => Set(ref count, value); }
        public int CountUse { get => GetCountUse(); }
        
        public virtual int GetCountUse()
        {
            return count;
        }

        public virtual bool Check(int count, int? time = null)
        {
            if (this.count < count) return false;
            else return true;
        }

        public virtual int Check(int count, int times = 1, int? time = null)
        {
            return (this.count - count * times) / times;
        }

        public virtual LootItem Drop(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public virtual LootItem Drop(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Take(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Use(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }

        public void Set<T>(ref T prop, T value, [System.Runtime.CompilerServices.CallerMemberName] string prop_name = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(prop_name));
        }
    }

    public class LootBreak : LootItem
    {
        private LinkedList<int> breaks;

        public LootBreak(Item item, int count) : base(item, count)
        {
            breaks = new LinkedList<int>();
            breaks.AddLast((item as IBreakable).CurrentDurability);
        }

        public LootBreak(Item item, int count, LinkedList<int> breaks) : base(item, count)
        {
            this.breaks = breaks;
        }

        public LinkedList<int> Breaks { get; }
        
        public override int GetCountUse()
        {
            int count = 0;
            foreach (var @break in breaks)
                count += @break;
            return count;
        }

        public override void Take(Inventory inventory)
        {
            base.Take(inventory);
        }

        public override LootItem Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override LootItem Drop(Inventory inventory, int count)
        {
            return base.Drop(inventory, count);
        }

        public override bool Check(int count, int? time = null)
        {
            return base.Check(count, time);
        }

        public override int Check(int count, int times = 1, int? time = null)
        {
            int durs = 0;
            foreach (var @break in breaks)
                durs += @break;
            return (durs - count * times) / times;
        }

        public override void Use(Inventory inventory, int count)
        {
            base.Use(inventory, count);
        }
    }

    public class LootSpoil : LootItem
    {
        private LinkedList<int> spoils;

        public LootSpoil(Item item, int count) : base(item, count)
        {
            spoils = new LinkedList<int>();
            spoils.AddLast((item as ISpoilable).Time);
        }

        public LootSpoil(Item item, int count, LinkedList<int> spoils) : base(item, count)
        {
            this.spoils = spoils;
        }

        public LinkedList<int> Spoils { get; }
        
        public override int GetCountUse()
        {
            return count;
        }

        public override void Take(Inventory inventory)
        {
            base.Take(inventory);
        }

        public override LootItem Drop(Inventory inventory)
        {
            return base.Drop(inventory);
        }

        public override LootItem Drop(Inventory inventory, int count)
        {
            return base.Drop(inventory, count);
        }

        public override bool Check(int count, int? time = null)
        {
            return base.Check(count, time);
        }

        public override int Check(int count, int times = 1, int? time = null)
        {
            int num = 0;
            int[] temp = new int[spoils.Count];
            bool ok = false;
            spoils.CopyTo(temp, 0);
            for (int i = time.Value; i < times * time.Value; i += time.Value)
            {
                for (int j = 0; j < count; j++)
                {
                    ok = false;
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (temp[k] >= i)
                        {
                            num++;
                            temp[k] = 0;
                            ok = true;
                            break;
                        }
                    }
                    if (!ok) return num;
                }
            }
            return num;
        }

        public override void Use(Inventory inventory, int count)
        {
            base.Use(inventory, count);
        }
    }

    class LootOption : ILoot, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private ILoot loot;
        private LinkedList<ILoot> options;

        public LootOption(ILoot loot)
        {
            this.loot = loot;
            options = null;
        }

        public Item Item { get => loot.Item; }

        public int Count { get => loot.Count; set => loot.Count = value; }

        public int OptionsCount
        {
            get
            {
                int count = 0;
                foreach (var item in options)
                    count += item.Count;
                return count;
            }
        }
        
        public int CountUse { get => GetCountUse(); }

        public int GetCountUse()
        {
            int num = 0;
            foreach (var option in options)
                num += option.CountUse;
            return num;
        }

        public void CheckOptionsCount()
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs("OptionsCount"));
        }

        public void Take(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public LootItem Drop(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public LootItem Drop(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }

        public bool Check(int count, int? time = null)
        {
            throw new System.NotImplementedException();
        }

        public int Check(int count, int times, int? time = null)
        {
            return CountUse - (count * times);
        }
        
        public void Use(Inventory inventory, int count)
        {
            throw new System.NotImplementedException();
        }

        public void Set<T>(ref T prop, T value, [System.Runtime.CompilerServices.CallerMemberName] string prop_name = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(prop_name));
        }

    }

    public class LootRandom
    {
        private ItemTag tag;
        private int min;
        private int max;

        public LootRandom(ItemTag tag, int min, int max)
        {
            this.tag = tag;
            this.min = min;
            this.max = max;
        }

        public ItemTag Tag { get => tag; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }

        public ILoot GetLoot()
        {
            Random random = new Random();
            return ItemFactory.GetItem(Tag).GetLoot(random.Next(min, max));
        }
    }
}
