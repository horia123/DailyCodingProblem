using System;
using System.Collections.Generic;

namespace Day1
{
    public class AnyTwoNoInArrayAddUp
    {
        public bool TwoNumbersInArrayAddUp()
        {
            Console.Write("Input the No. of Elements in the array: ");            
            int.TryParse(Console.ReadLine(), out int noOfElements);
            var arr = new List<int>();

            Console.Write("Input elements: ");
            for(var i = 0; i < noOfElements; i++)
            {
                int.TryParse(Console.ReadLine(), out int elem);
                arr.Add(elem);
            }

            foreach (var item in arr)
            {
                Console.Write(item+" ");
                Console.WriteLine();
            }

            return true;
        }
    }
}
