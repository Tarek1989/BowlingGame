using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLogicTest
{
    public static class Game 
    {
        private static int totalScore = 0;
        private static bool spare = false;
        private static bool strike = false;

        public static  void rolls(int PinsFirstTry, int PinsSecondTry, int numberofframes )
        {
            /* If spare it will takes #PinsFirstTry as bonus
             * If strike it will takes #PinsSecondTry as bonus*/

            if (spare)
            {
                Spare(PinsFirstTry);
                spare = false;
            }
            else if(strike)
            {
                Strike(PinsFirstTry, PinsSecondTry);
                strike=false;
            }

            //Conditions for calculation
            // If number of frame is not 10 in addition to pins  knowcked down 
            if (numberofframes != 10 &&  (PinsFirstTry !=10 && PinsSecondTry !=10))
            {
                //Check if Spare
                if(PinsFirstTry + PinsSecondTry != 10)
                {
                    totalScore += PinsFirstTry + PinsSecondTry;
                }
                else
                {
                    totalScore += PinsFirstTry + PinsSecondTry;
                    spare = true;
                } 
            }
            // Check if strike
            if(numberofframes != 10 && PinsFirstTry ==10)
            {
                totalScore += PinsFirstTry + PinsSecondTry;
                strike = true;
            }
            //Last Frame
            if (numberofframes==10)
            {
                LastFrame(PinsFirstTry, PinsSecondTry);
            }

        }

        private  static void Spare(int PinsFirstTry)
        {
            totalScore += PinsFirstTry;
        }

        private static void Strike(int PinsFirstTry, int PinsSecondTry)
        {
            totalScore += PinsFirstTry + PinsSecondTry;
        }

        private static void LastFrame(int PinsFirstTry, int PinsSecondTry)
        {
            Random random = new Random();
            int finalBonus = random.Next(0, 11);
            totalScore += PinsFirstTry + PinsSecondTry + finalBonus;

        }

        public static  int score()
        {
            return totalScore;
        }
    }
}
