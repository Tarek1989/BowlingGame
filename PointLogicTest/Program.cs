using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int NumberOfRolls = 0;
            while (NumberOfRolls != 11)
            {
                List<int> RandomNumbers = RandomNumberGenerator.Display();

                
                int pinOne = RandomNumbers.ElementAt(0);
                int pinTwo = RandomNumbers.ElementAt(1);

                Game.rolls(pinOne, pinTwo, NumberOfRolls);
                NumberOfRolls++;
            }


            Console.WriteLine(Game.score());
            Console.ReadLine();

        }
    }
}
