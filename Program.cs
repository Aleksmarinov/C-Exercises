﻿namespace _06.Sequence_of_Numbers_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int allNumbers = 1;

            while (allNumbers <= number)
            {
                Console.WriteLine(allNumbers);
                allNumbers = allNumbers * 2 + 1;
            }
        }
    }
}