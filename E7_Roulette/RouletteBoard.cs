using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8_Roulette
{
    class RouletteBoard
    {
        enum Color
        {
            Red,
            Black,
            Green
        }

        public Random rnd = new Random();
        public Enum[] colors = new Enum[3] { Color.Red, Color.Black, Color.Green };
        public int[] numbers = new int[38] { 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        
        public int ball = 0;
        
        public void Spin()
        {
            int pickNumber = rnd.Next(numbers[0], numbers[37]);
            int pickColor = rnd.Next(0, 3);

            var fin = colors[pickColor];

            Console.WriteLine($"Number: {pickNumber}, Color: {fin}");
        }
    }
}
