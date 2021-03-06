﻿using Days.Day1;
using Days.Day10;
using Days.Day2;
using Days.Day3;
using Days.Day4;
using Days.Day5;
using System;

namespace DailyCodingProblems
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Please input a number representing the day you want to run: ");
            int.TryParse(Console.ReadLine(), out var problemToBeRan);

            switch (problemToBeRan)
            {
                case (int)DayToRunEnums.Day1:
                    {
                        var day1 = new Day1();

                        day1.TwoNumbersInArrayAddUp();
                        break;
                    }
                case (int)DayToRunEnums.Day2:
                    {
                        var day2 = new Day2();

                        day2.MultiplyArrElementsSkippingCurrentElement();
                        break;
                    }
                case (int)DayToRunEnums.Day3:
                    {
                        var day3 = new Day3();
                        day3.SerializeDeserializeBinaryTree();
                        break;
                    }
                case (int)DayToRunEnums.Day4:
                    {
                        var day4 = new Day4();
                        day4.Run();
                        break;
                    }
                case (int)DayToRunEnums.Day5:
                    {
                        var day5 = new Day5();
                        day5.Run();
                        break;
                    }
                case (int)DayToRunEnums.Day10:
                    {
                        var day10 = new Day10();

                        day10.JobScheduler(5000);

                        break;
                    }
            }
        }
    }
}
