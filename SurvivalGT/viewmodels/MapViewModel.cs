using SurvivalGT.Models;
using SurvivalGT.Utility;

namespace SurvivalGT.ViewModels
{
    class MapViewModel : ObserableObject
    {
        private Game game;
        private bool is_moving;

        public MapViewModel()
        {
            game = Game.Instance;
        }

        public bool IsMoving { get => is_moving; set => Set(ref is_moving, value); }
    }
}
