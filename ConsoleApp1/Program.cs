

namespace ConsoleApp1
{

    public class Game
    {
        private int currentPin = 0;
        private int[] roller = new int[22];
        public int GetScore()
        {
            int sum = 0;

            int current = 0;
            for (int i = 0; i < 10; i++)
            {
                if (IsStrike(current))
                {
                    sum += roller.StrikeSummition(current);
                    current++;
                }
                else if (IsSpare(current))
                {
                    sum += roller.SPareSummition(current);
                    current += 2;
                }
                else
                {
                    sum += roller.OpenFrameSummition(current);

                    current += 2;
                }
            }
            return sum;
        }

        public void rolle(int pins)
        {
            roller[currentPin++] = (pins);

        }

        private bool IsStrike(int current) =>  roller[current] == 10;


        private bool IsSpare(int current) => roller[current] + roller[current + 1] == 10;
    }

   
}

