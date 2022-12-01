using System;
using System.Collections.Generic;
using System.IO;

namespace day1
{
    class TaskClass
    {
        public void Solution()
        {
            List<int> Inventory = new List<int>();

            using (StreamReader sr = new StreamReader("data.txt"))
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

            using (StreamReader sr = new StreamReader("data.txt"))
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
    
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskClass t = new TaskClass();
            t.Solution();
            t.Solution2();
        }
    }
}