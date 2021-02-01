﻿using SurvivalGT.Models;
using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.ViewModels
{
    class BookViewModel
    {
        public BookViewModel(Loot loot)
        {
            Player = Player.Instance;
            ReadCommand = new Command(Read);
            Loot = loot;

            ItemViewModel = new ItemViewModel(loot);
        }

        public ICommand ReadCommand { get; }

        public Player Player { get; }
        public Loot Loot { get; set; }
        public ItemViewModel ItemViewModel { get; }

        private void Read(object param)
        {

        }
    }
}
