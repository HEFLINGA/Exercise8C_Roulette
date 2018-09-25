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
            int input = 0;
            RouletteBoard r = new RouletteBoard();

            Console.Clear();
            Console.WriteLine("Pick your Bet: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine($"You bet number: {r.currentNumber = input} Color: {r.AssignColor(input)}");
            Console.WriteLine("Press enter to spin!");
            Console.ReadLine();

            r.Spin();
            r.BetNumbers(input);
            r.BetOddEven(input);
            r.BetRedBlack(input);
            r.BetLowHigh(input);
            r.BetDozen(input);
            r.BetColumns(input);
            r.BetStreet(input);
            r.BetSixNumbers(input);
            r.BetSplit(input);
            //r.BetCorner(input);

            Console.WriteLine($"Number: {r.currentNumber}, Color: {r.currentColor}");
            Console.WriteLine($"Possible bets to be won: {r.countWon}");
            r.PossibleBetsWon(input);
        } 
    }
}