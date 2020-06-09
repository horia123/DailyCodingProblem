using Days;
using System;

namespace DailyCodingProblems
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Please input a number representing the day you want to run: ");
            int.TryParse(Console.ReadLine(), out int problemToBeRan);

            if (problemToBeRan == (int)DayToRunEnums.Day1)
            {
                var day1 = new Day1();

                day1.TwoNumbersInArrayAddUp();
            }
        }
    }
}
