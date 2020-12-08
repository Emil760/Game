﻿using SurvivalGT.viewmodels;
using System.Windows.Controls;

namespace SurvivalGT.InfoUC
{
    /// <summary>
    /// Interaction logic for WeaponUC.xaml
    /// </summary>
    public partial class WeaponUC : UserControl
    {
        public WeaponUC()
        {
            InitializeComponent();
            repair_btn.DataContext = new RepairViewModel();
        }
    }
}
