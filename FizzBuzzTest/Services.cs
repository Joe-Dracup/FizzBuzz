using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Services
    {
        public string FindNumberOutput(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return num.ToString();
            }
        }
        public List<string> WorkUpTo(int NumTo)
        {
            List<string> numbers = new List<string>();

            for (int i = 0; i <= NumTo; i++)
            {
                numbers.Add(FindNumberOutput(i));
            }

            return numbers;
        }
    }
}
