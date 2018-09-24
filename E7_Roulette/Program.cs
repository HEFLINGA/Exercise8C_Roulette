using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            RouletteBoard roulette = new RouletteBoard();

            do
            {
                roulette.Spin();
                input = Console.ReadLine();
            } while (input != "exit");
            
        }
    }
}