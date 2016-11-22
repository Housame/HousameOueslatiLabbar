using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb11
{
    class NumberFilter
    {
        public static bool IsEven(int input)
        {
            return input % 2 == 0;
        }

        public static bool IsDivisableByThree(int input)
        {
            return input % 3 == 0;
        }

        public static bool IsPrimeNumber(int input)
        {

            return Prime(input);
        }

        static bool Prime(int num)
        {
            
            if (num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int a = 2; a <= num / 2; a++)
                {
                    if (num % a == 0)
                    {
                          return false;
                    }


                }
                return true;
                
            }
        }
    }
}
