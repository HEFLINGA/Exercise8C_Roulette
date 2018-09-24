using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Roulette
{
    class RouletteBoard
    {
        public Random rnd = new Random();
        public int[] numbers = new int[38] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 00 };
        public string[] colors = new string[3] { "Red", "Black", "Green" };

        
    }
}
