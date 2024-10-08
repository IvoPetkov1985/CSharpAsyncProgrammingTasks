﻿namespace SumEvensInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? command = Console.ReadLine();

            if (command == "show")
            {
                long result = SumAsync();
                Console.WriteLine(result);
            }
        }

        private static long SumAsync()
        {
            return Task.Run(() =>
            {
                long sum = 0;

                for (int i = 1; i < 10000; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }

                return sum;
            }).Result;
        }
    }
}
