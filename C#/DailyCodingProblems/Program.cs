using Day1;
using System;

namespace DailyCodingProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a number representing the day you want to run: ");
            int.TryParse(Console.ReadLine(), out int problemToBeRan);

            if (problemToBeRan == (int)DayToRunEnums.Day1)
            {
                var anyTwoNumbersAddUp = new AnyTwoNoInArrayAddUp();
                anyTwoNumbersAddUp.TwoNumbersInArrayAddUp();                
            }            
        }
    }
}
