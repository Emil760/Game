using SurvivalGT.Models;
using System.Windows.Controls;

namespace SurvivalGT.InfoUC
{
    /// <summary>
    /// Interaction logic for BreakableUC.xaml
    /// </summary>
    public partial class BreakableUC : UserControl, System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private Loot loot;

        public BreakableUC()
        {
            // Дмитрий здрасьте
            // У меня есть два UserControl
            // один BreakableUC другой ItemUC
            // и я пытаюсь в DataContext второго дать данные из обьекта Loot
            // но почему то ItemUС не отображает эти данные 
            // хотя я забиндил Loot к DataContext у ItemUC      
            // < local:ItemUC DataContext = "{Binding Path=Loot}" />
        }

        public BreakableUC(Loot loot)
        {
            InitializeComponent();
            Loot = loot;
            DataContext = this;
        }

        // тот самый Loot для биндинга
        public Loot Loot { get => loot; set => Set(ref loot, value); }

        public void Set<T>(ref T prop, T value, [System.Runtime.CompilerServices.CallerMemberName] string prop_name = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(prop_name));
        }
    }
}
