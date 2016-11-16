using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Random num = new Random();
                var raso = num.Next(100);

                //Console.WriteLine(raso);

                Console.WriteLine("Please enter a number between 1 and 100");

                var counter = 0;
                var win = false;

                while (counter < 5 && !win)
                    
                {
                    var input = int.Parse(Console.ReadLine());
                    
                    if (input < raso)
                    {
                        Console.WriteLine("Sorry you are low, please try again");
                    }
                    else if (input > raso)
                    {
                        Console.WriteLine("sorry you are high, please try again");
                    }
                    else if (input == raso)
                    {
                        Console.WriteLine("Winner Winner...Chicken dinner!");
                        win = true;
                    }

                    counter++;
                }
                
                if (counter == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                }

                Console.ReadLine();
           } 
        }
    }
}
