﻿using System;
using System.IO;
using System.Collections.Generic;

namespace adventOfCode
{
    class Day1
    {
        public void Solution()
        {
            List<int> Inventory = new List<int>();

            using (StreamReader sr = new StreamReader("data1.txt"))
            {
                int sum = 0;
                while (!sr.EndOfStream)
                {
                    string? line = sr.ReadLine();
                    if (line == "")
                    {
                        Inventory.Add(sum);
                        sum = 0;
                    }
                    else
                    {
                        int number = Convert.ToInt32(line);
                        sum += number;
                    }
                }
            }

            // Task 1
            // Maximum of sums
            int max1 = 0;
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (max1 < Inventory[i])
                {
                    max1 = Inventory[i];
                }
            }
            Console.WriteLine("Maximum: {0}", max1);

            // Task 2
            // Summary of the top 3 of the sums
            int max2 = 0;
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (max2 < Inventory[i] && Inventory[i] != max1)
                {
                    max2 = Inventory[i];
                }
            }

            int max3 = 0;
            for (int i = 0; i < Inventory.Count; i++)
            {
                if (max3 < Inventory[i] && Inventory[i] != max1 && Inventory[i] != max2)
                {
                    max3 = Inventory[i];
                }
            }

            int sumoftop3 = max1 + max2 + max3;
            Console.WriteLine("Summary of the top 3: {0}", sumoftop3);
        }

        public void Solution2()
        {
            List<int> Inventory = new List<int>();

            using (StreamReader sr = new StreamReader("data1.txt"))
            {
                int sum = 0;
                while (!sr.EndOfStream)
                {
                    string? line = sr.ReadLine();
                    if (line == "")
                    {
                        Inventory.Add(sum);
                        sum = 0;
                    }
                    else
                    {
                        int number = Convert.ToInt32(line);
                        sum += number;
                    }
                }
            }

            // Task 1
            // Maximum of sums
            Inventory.Sort();
            Inventory.Reverse();
            Console.WriteLine("Maximum: {0}", Inventory[0]);

            // Task 2
            // Summary of the top 3 of the sums
            Console.WriteLine("Summary of top 3: {0}", Inventory[0] + Inventory[1] + Inventory[2]);
        }
    }

    class Day2
    {
        // Task 1

        // A and X = rock       p: 1
        // B and Y = paper      p: 2
        // C and Z = scissors   p: 3

        // You lose: 0
        // Draw: 3
        // You win: 6

        public int Shapes(string letter)
        {
            switch (letter)
            {
                case "A":
                case "X":
                    return 1;
                case "B":
                case "Y":
                    return 2;
                case "C":
                case "Z":
                    return 3;
                default:
                    return 0;
            }
        }

        public int ResultsforTask1(string opp, string you)
        {
            int o = Shapes(opp);
            int y = Shapes(you);
            if (o == y)
            {
                return 3 + y;
            }
            else if ((o == 1 && y == 2) || (o == 2 && y == 3) || (o == 3 && y == 1))
            {
                return 6 + y;
            }
            else
            {
                return y;
            }
        }

        // Task 2

        // X: lose
        // Y: draw
        // Z: win

        public int ResultsforTask2(string opp, string round)
        {
            if (round == "X")
            {
                if (opp == "A") return 3;
                else if (opp == "B") return 1;
                else return 2;

            }
            else if (round == "Y")
            {
                if (opp == "A") return 3 + 1;
                else if (opp == "B") return 3 + 2;
                else return 3 + 3;
            }
            else
            {
                if (opp == "A") return 6 + 2;
                else if (opp == "B") return 6 + 3;
                else return 6 + 1;
            }
        }

        public void Solution()
        {
            int sumforTask1 = 0;
            int sumforTask2 = 0;

            using (StreamReader sr = new StreamReader("data2.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] h = sr.ReadLine().Split(" ");
                    sumforTask1 += ResultsforTask1(h[0], h[1]);
                    sumforTask2 += ResultsforTask2(h[0], h[1]);
                }
            }

            Console.WriteLine("Task 1 sum: {0}", sumforTask1);
            Console.WriteLine("Task 2 sum: {0}", sumforTask2);
        }
    }

    class Day3
    {

        public void Solution()
        {





        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Day2 d = new Day2();
            d.Solution();

        }
    }
}