using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Services service = new Services();
            FizzBuzzIO Io = new FizzBuzzIO();

            bool cont;

            do
            {
                Io.Write("what is your number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Io.Write(service.FindNumberOutput(userInput));
                cont = Io.Repeat();
            } while (cont);

        }
    }
}
