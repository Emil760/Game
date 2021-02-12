﻿using SurvivalGT.Models;
using System.Windows.Input;

namespace SurvivalGT.ViewModels.Items
{
    class FoodViewModel : ItemViewModel
    {
        public FoodViewModel(ILoot loot, bool is_info) : base(loot, is_info)
        {
            Player = Player.Instance;
        }

        public ICommand ConsumeCommand { get; }

        public Player Player { get; }

        public void Consume(object param)
        {

        }
    }
}
