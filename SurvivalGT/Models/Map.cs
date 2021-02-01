namespace SurvivalGT.Models
{
    public class Map
    {
        private static Map instance;

        private Map()
        {

        }

        public static Map Instance
        {
            get
            {
                if (instance == null) instance = new Map();
                return instance;
            }
        }
    }
}
