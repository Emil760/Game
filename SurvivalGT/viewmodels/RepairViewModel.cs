using SurvivalGT.Utility;
using System.Windows.Input;

namespace SurvivalGT.viewmodels
{
    class RepairViewModel
    {
        public RepairViewModel()
        {
            RepairCommand = new Command(Repair);
        }

        ICommand RepairCommand { get; }

        public void Repair(object param)
        {

        }
    }
}
