using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class FizzBuzzIO
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
        public bool Repeat()
        {
            Write("Would you like to go again? Y:N");

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey(true);
            } while (keyPressed.Key != ConsoleKey.Y && keyPressed.Key != ConsoleKey.N);

            
            return keyPressed.Key == ConsoleKey.Y;
        }
    }
}
