using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8_Roulette
{
    class RouletteBoard
    {
        enum Color { Red, Black, Green }
        public int currentNumber = 0;
        public Enum currentColor;
        public int countWon = 0;
        string[] output = new string[7];

        public int numbersBet = 0;
        public int evenOdd = 0;
        public int redBlack = 0;
        public int lowHigh = 0;
        public int dozens = 0;
        public int columns = 0;
        public int street = 0;
        public int sixNumbers = 0;
        public int split = 0;
        public int corner = 0;

        public Random rnd = new Random();        
        public Enum[] colors = new Enum[3] { Color.Red, Color.Black, Color.Green };
        public int[] numbers = new int[38] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21
            , 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 4, 35, 36, 00 };

        public Enum AssignColor(int i)
        {
            var color = colors[0];

            if (numbers[i] == 1 || numbers[i] == 3 || numbers[i] == 5 || numbers[i] == 7 || numbers[i] == 9 || numbers[i] == 12 || numbers[i] == 14 || numbers[i] == 16 || numbers[i] == 18 | numbers[i] == 19 || numbers[i] == 21 || numbers[i] == 23 || numbers[i] == 25 || numbers[i] == 27 || numbers[i] == 30 || numbers[i] == 32 || numbers[i] == 34 || numbers[i] == 36)
            {
                color = colors[0];
            }
            else if (numbers[i] == 0 || numbers[i] == 37)
            {
                color = colors[2];
            }
            else
            {
                color = colors[1];
            }

            return color;
        }
        public void Spin() 
        {
            int pickNumber = rnd.Next(0, 38);
            currentColor = AssignColor(pickNumber);
            currentNumber = numbers[pickNumber];
        }
        public void BetNumbers(int input)
        {
            // Bet for Numbers: number of the bin
            if (input == currentNumber)
            {
                countWon++;
                numbersBet++;
            }
        }
        public void BetOddEven(int input)
        {
            // Bet for odds or evens
            if ((input == 1 && currentNumber == 1) || (input == 3 && currentNumber == 3) || (input == 5 && currentNumber == 5) || (input == 7 && currentNumber == 7) || (input == 9 && currentNumber == 9) || (input == 11 && currentNumber == 11) || (input == 13 && currentNumber == 13) || (input == 15 && currentNumber == 15) || (input == 17 && currentNumber == 17) || (input == 19 && currentNumber == 19) || (input == 21 && currentNumber == 21) || (input == 23 && currentNumber == 23) || (input == 25 && currentNumber == 25) || (input == 27 && currentNumber == 27) || (input == 29 && currentNumber == 29) || (input == 31 && currentNumber == 31) || (input == 33 && currentNumber == 33) || (input == 35 && currentNumber == 35))
            {
                countWon++;
                evenOdd++;
            }
            else if ((input == 2 && currentNumber == 2) || (input == 4 && currentNumber == 4) || (input == 6 && currentNumber == 6) || (input == 8 && currentNumber == 8) || (input == 10 && currentNumber == 10) || (input == 12 && currentNumber == 12) || (input == 14 && currentNumber == 14) || (input == 16 && currentNumber == 16) || (input == 18 && currentNumber == 18) || (input == 20 && currentNumber == 20) || (input == 22 && currentNumber == 22) || (input == 24 && currentNumber == 24) || (input == 26 && currentNumber == 26) || (input == 28 && currentNumber == 28) || (input == 30 && currentNumber == 30) || (input == 32 && currentNumber == 32) || (input == 34 && currentNumber == 34) || (input == 36 && currentNumber == 36))
            {
                countWon++;
                evenOdd++;
            }
        }        
        public void BetRedBlack(int input)
        {
            if ((currentColor == colors[0] && input == 1) || (currentColor == colors[0] && input == 3) || (currentColor == colors[0] && input == 5) || (currentColor == colors[0] && input == 7) || (currentColor == colors[0] && input == 9) || (currentColor == colors[0] && input == 12) || (currentColor == colors[0] && input == 14) || (currentColor == colors[0] && input == 16) || (currentColor == colors[0] && input == 18) || (currentColor == colors[0] && input == 19) || (currentColor == colors[0] && input == 21) || (currentColor == colors[0] && input == 23) || (currentColor == colors[0] && input == 25) || (currentColor == colors[0] && input == 27) || (currentColor == colors[0] && input == 30) || (currentColor == colors[0] && input == 32) || (currentColor == colors[0] && input == 34) || (currentColor == colors[0] && input == 36))
            {
                countWon++;
                redBlack++;
            }
            else if ((currentColor == colors[1] && input == 2) || (currentColor == colors[1] && input == 4) || (currentColor == colors[1] && input == 6) || (currentColor == colors[1] && input == 8) || (currentColor == colors[1] && input == 10) || (currentColor == colors[1] && input == 11) || (currentColor == colors[1] && input == 13) || (currentColor == colors[1] && input == 15) || (currentColor == colors[1] && input == 17) || (currentColor == colors[1] && input == 20) || (currentColor == colors[1] && input == 22) || (currentColor == colors[1] && input == 24) || (currentColor == colors[1] && input == 26) || (currentColor == colors[1] && input == 28) || (currentColor == colors[1] && input == 29) || (currentColor == colors[1] && input == 31) || (currentColor == colors[1] && input == 33) || (currentColor == colors[1] && input == 35))
            {
                countWon++;
                redBlack++;
            }
        }
        public void BetLowHigh(int input)
        {
            if (currentNumber > 0 && currentNumber <= 18 && input > 0 && input <= 18)
            {
                countWon++;
                lowHigh++;
                output[0] = "Low (1 - 18)";
            }
            else if (currentNumber > 18 && currentNumber <= 36 && input > 18 && currentNumber <= 36)
            {
                countWon++;
                lowHigh++;
                output[0] = "high (19 - 36)";
            }
        }
        public void BetDozen(int input)
        {
            if (currentNumber >= 1 && input >= 1 && currentNumber < 13 && input < 13)
            {
                countWon++;
                dozens++;
                output[1] = "Row 1 - 12";
            }
            else if (currentNumber >= 13 && input >= 13 && currentNumber < 25 && input < 25)
            {
                countWon++;
                dozens++;
                output[1] = "Row 13 - 24";
            }
            else if (currentNumber >= 25 && input >= 25 && currentNumber <= 36 && input <= 36)
            {
                countWon++;
                dozens++;
                output[1] = "Row 25 - 36";
            }
        }
        public void BetColumns(int input)
        {
            if ((input == 1 || input == 4 || input == 7 || input == 10 || input == 13 || input == 16 || input == 19 || input == 22 || input == 25 || input == 28 || input == 31 || input == 34) && (currentNumber == 1 || currentNumber == 4 || currentNumber == 7 || currentNumber == 10 || currentNumber == 13 || currentNumber == 16 || currentNumber == 19 || currentNumber == 22 || currentNumber == 25 || currentNumber == 28 || currentNumber == 31 || currentNumber == 34))
            {
                countWon++;
                columns++;
                output[2] = "First Column";
            }
            else if ((input == 2 || input == 5 || input == 8 || input == 11 || input == 14 || input == 17 || input == 20 || input == 23 || input == 26 || input == 29 || input == 32 || input == 35) && (currentNumber == 2 || currentNumber == 5 || currentNumber == 8 || currentNumber == 11 || currentNumber == 14 || currentNumber == 17 || currentNumber == 20 || currentNumber == 23 || currentNumber == 26 || currentNumber == 29 || currentNumber == 32 || currentNumber == 35))
            {
                countWon++;
                columns++;
                output[2] = "Second Column";
            }
            else if ((input == 3 || input == 6 || input == 9 || input == 12 || input == 15 || input == 18 || input == 21 || input == 24 || input == 27 || input == 30 || input == 33 || input == 36) && (currentNumber == 3 || currentNumber == 6 || currentNumber == 9 || currentNumber == 12 || currentNumber == 15 || currentNumber == 18 || currentNumber == 21 || currentNumber == 24 || currentNumber == 27 || currentNumber == 30 || currentNumber == 33 || currentNumber == 36))
            {
                countWon++;
                columns++;
                output[2] = "Third Column";
            }
        }
        public void BetStreet(int input)
        {
            if (currentNumber >= 1 && currentNumber < 4 && input >= 1 && input < 4)
            {
                countWon++;
                street++;
                output[3] = "1/2/3";
            }
            else if (currentNumber >= 4 && currentNumber < 7 && input >= 4 && input < 7)
            {
                countWon++;
                street++;
                output[3] = "4/5/6";
            }
            else if (currentNumber >= 7 && currentNumber < 10 && input >= 7 && input < 10)
            {
                countWon++;
                street++;
                output[3] = "7/8/9";
            }
            else if (currentNumber >= 10 && currentNumber < 13 && input >= 10 && input < 13)
            {
                countWon++;
                street++;
                output[3] = "10/11/12";
            }
            else if (currentNumber >= 13 && currentNumber < 16 && input >= 13 && input < 16)
            {
                countWon++;
                street++;
                output[3] = "13/14/15";
            }
            else if (currentNumber >= 16 && currentNumber < 19 && input >= 16 && input < 19)
            {
                countWon++;
                street++;
                output[3] = "16/17/18";
            }
            else if (currentNumber >= 19 && currentNumber < 22 && input >= 19 && input < 22)
            {
                countWon++;
                street++;
                output[3] = "19/20/21";
            }
            else if (currentNumber >= 22 && currentNumber < 25 && input >= 22 && input < 25)
            {
                countWon++;
                street++;
                output[3] = "22/23/24";
            }
            else if (currentNumber >= 25 && currentNumber < 28 && input >= 25 && input < 28)
            {
                countWon++;
                street++;
                output[3] = "25/26/27";
            }
            else if (currentNumber >= 28 && currentNumber < 31 && input >= 28 && input < 31)
            {
                countWon++;
                street++;
                output[3] = "28/29/30";
            }
            else if (currentNumber >= 31 && currentNumber < 34 && input >= 31 && input < 34)
            {
                countWon++;
                street++;
                output[3] = "31/32/33";
            }
            else if (currentNumber >= 34 && currentNumber < 36 && input >= 34 && input < 36)
            {
                countWon++;
                street++;
                output[3] = "34/35/36";
            }
        }
        
        public void BetSixNumbers(int input)
        {
            if (currentNumber >= 1 && currentNumber < 7 && input >= 1 && input < 7)
            {
                countWon++;
                sixNumbers++;
                output[4] = "1/2/3/4/5/6";
            }
            else if (currentNumber >= 4 && currentNumber < 10 && input >= 4 && input < 10)
            {
                countWon++;
                sixNumbers++;
                output[4] = "4/5/6/7/8/9";
            }
            else if (currentNumber >= 7 && currentNumber < 13 && input >= 7 && input < 13)
            {
                countWon++;
                sixNumbers++;
                output[4] = "7/8/9/10/11/12";
            }
            else if (currentNumber >= 10 && currentNumber < 16 && input >= 10 && input < 16)
            {
                countWon++;
                sixNumbers++;
                output[4] = "10/11/12/13/14/15";
            }
            else if (currentNumber >= 13 && currentNumber < 19 && input >= 13 && input < 19)
            {
                countWon++;
                sixNumbers++;
                output[4] = "13/14/15/16/17/18";
            }
            else if (currentNumber >= 16 && currentNumber < 22 && input >= 16 && input < 22)
            {
                countWon++;
                sixNumbers++;
                output[4] = "16/17/18/19/20/21";
            }
            else if (currentNumber >= 19 && currentNumber < 25 && input >= 19 && input < 25)
            {
                countWon++;
                sixNumbers++;
                output[4] = "19/20/21/22/23/24";
            }
            else if (currentNumber >= 22 && currentNumber < 28 && input >= 22 && input < 28)
            {
                countWon++;
                sixNumbers++;
                output[4] = "22/23/24/25/26/27";
            }
            else if (currentNumber >= 25 && currentNumber < 31 && input >= 25 && input < 31)
            {
                countWon++;
                sixNumbers++;
                output[4] = "25/26/27/28/29/30";
            }
            else if (currentNumber >= 28 && currentNumber < 34 && input >= 28 && input < 34)
            {
                countWon++;
                sixNumbers++;
                output[4] = "28/29/30/31/32/33";
            }
            else if (currentNumber >= 31 && currentNumber <= 36 && input >= 31 && input <= 36)
            {
                countWon++;
                sixNumbers++;
                output[4] = "31/32/33/34/35/36";
            }
        }
        public void BetSplit(int input)
        {

            if (input == currentNumber - 1 
                || input == currentNumber + 1 
                || input == currentNumber + 3
                || input == currentNumber - 3)
            {
                countWon++;
                split++;
            }
        }
        public void BetCorner(int input)
        {
            if (input == currentNumber + 3 
                || input == currentNumber - 3
                || input == currentNumber + 4 
                || input == currentNumber - 4 
                || input == currentNumber + 2 
                || input == currentNumber - 2 
                || input == currentNumber + 1 
                || input == currentNumber - 1)
            {
                countWon++;
                corner++;
            }
        }        

        public void PossibleBetsWon(int input)
        {
            if (numbersBet == 1)
            {
                Console.WriteLine($"You would have won a Numbers bet using {input}");
            }
            if (evenOdd == 1)
            {
                Console.WriteLine("You would have won an Evens/Odds bet");
            }
            if (redBlack == 1)
            {
                Console.WriteLine($"You would have won with your {currentColor} bet");
            }
            if (lowHigh == 1)
            {
                Console.WriteLine($"You would have won a {output[0]} bet");
            }
            if (dozens == 1)
            {
                Console.WriteLine($"You would have won a dozens bet of {output[1]}");
            }
            if (columns == 1)
            {
                Console.WriteLine($"You would have won a columns bet of {output[2]}");
            }
            if (street == 1)
            {
                Console.WriteLine($"You would have won with a street bet of {output[3]}");
            }
            if (sixNumbers == 1)
            {
                Console.WriteLine($"You would have won with a 6 Number/Double row bet of {output[4]}");
            }
        }
    }
}