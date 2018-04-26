namespace Mordor_s_Cruelty_Plan
{
    public class Mood
    {
        private string moodLevel;

        public Mood(int points)
        {
            this.Points = points;
        }

        public int Points
        {
            set
            {
                if (value < -5)
                {
                    moodLevel = "Angry";
                }
                else if (value >= -5 && value < 0)
                {
                    moodLevel = "Sad";
                }
                else if (value >= 0 && value < 15)
                {
                    moodLevel = "Happy";
                }
                else
                {
                    moodLevel = "JavaScript";
                }

            }
        }

        public override string ToString()
        {
            return moodLevel;
        }
    }
}
