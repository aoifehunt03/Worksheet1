﻿namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersFor();
        }

        static int PrintIntegersFor()
        {
            int i;
            for (i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);
                i++;
            }
            return i;
        }
    }
}