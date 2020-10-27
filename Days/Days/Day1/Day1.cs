using System;
using System.Collections.Generic;

namespace Days.Day1
{
    public class Day1
    {
        public void TwoNumbersInArrayAddUp()
        {
            Console.WriteLine("Building the data-set");
            Console.Write("Input the No. of Elements in the array: ");
            int.TryParse(Console.ReadLine(), out int noOfElements);
            var arr = new List<int>();
            bool found = false;

            Console.WriteLine("Input elements: ");
            for(var i = 0; i < noOfElements; i++)
            {
                int.TryParse(Console.ReadLine(), out int elem);
                arr.Add(elem);
            }

            Console.WriteLine("Input sum: ");
            int.TryParse(Console.ReadLine(), out int k);

            Console.Write("Finding any two numbers in the list : ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"That add up to {k} ... ");

            HashSet<int> values = new HashSet<int>();
            for(int i = 0; i < arr.Count; i++)
            {                
                if (values.Contains(k - arr[i]))
                    found = true;

                values.Add(arr[i]);
            }

            if (found)
            {
                Console.WriteLine("Two such numbers were FOUND");
            }
            else
            {
                Console.WriteLine("Two such numbers were NOT FOUND");
            }            
        }
    }
}
