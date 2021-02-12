using SurvivalGT.Utility;

namespace SurvivalGT.Models
{
    public class Level : ObserableObject
    {
        private short current_level;
        private int experience;
        private int level_points;
        private int[] experiences;
        private int[] points;

        public Level()
        {
            experiences = new int[10];
            points = new int[10];

            CurrentLevel = 3;
            Experience = 250;
            LevelPoints = 5;

            //1
            experiences[0] = 1000;
            points[0] = 1;
            //2
            experiences[1] = 2000;
            points[1] = 2;
            //3
            experiences[2] = 3000;
            points[2] = 3;
            //4
            experiences[3] = 4000;
            points[3] = 4;
            //5
            experiences[4] = 5000;
            points[4] = 5;
            //6
            experiences[5] = 6000;
            points[5] = 6;
            //7
            experiences[6] = 7000;
            points[6] = 7;
            //8
            experiences[7] = 8000;
            points[7] = 8;
            //9
            experiences[8] = 9000;
            points[8] = 9;
            //10
            experiences[9] = 10000;
            points[9] = 10;
        }

        public short CurrentLevel { get => current_level; private set => Set(ref current_level, value); }
        public int LevelPoints { get => level_points; private set => Set(ref level_points, value); }
        public int NextExperience { get => experiences[current_level]; }
        private int Points { get => points[current_level]; }

        public int Experience
        {
            get { return experience; }
            set
            {
                if (value >= NextExperience)
                {
                    Set(ref experience, value - experience);
                    CurrentLevel++;
                    LevelPoints += Points;
                }
                else
                {
                    Set(ref experience, value);
                }
            }
        }
    }
}
