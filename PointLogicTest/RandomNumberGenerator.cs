using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLogicTest
{
    public static class RandomNumberGenerator
    {
        private static List<int> NumberGeneratorList = new List<int>();

        //Method to return list with two random number.
        public  static List<int> Display()
        {
            NumberGeneratorList.Clear();

            Random r = new Random();
            //One and two random numbers
            int FirstRandomNumber = r.Next(0, 11);
            int Substractvalue = 10 - FirstRandomNumber;
            int SecondRandomNumber;
            if (Substractvalue !=0)
            {
                SecondRandomNumber = r.Next(Substractvalue + 1);
            }
            else
            {
                SecondRandomNumber = r.Next(Substractvalue);
            }
            
            NumberGeneratorList.Add(FirstRandomNumber);
            NumberGeneratorList.Add(SecondRandomNumber);

            return NumberGeneratorList;
        }
            

    }
}
