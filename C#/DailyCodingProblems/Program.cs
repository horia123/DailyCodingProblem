using Days;
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
