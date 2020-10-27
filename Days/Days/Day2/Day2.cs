using System;
using System.Collections.Generic;
using System.Linq;

namespace Days.Day2
{
    public class Day2
    {
        public void MultiplyArrElementsSkippingCurrentElement()
        {
            var array = new List<int> {1, 2, 3, 4, 5};

            Console.WriteLine("Computing multiplication for array: 1, 2, 3, 4, 5");
            var internalArr = new List<int>();

            foreach (var i in array)
            {
                var product = array.Where(j => j != i).Aggregate(1, (current, j) => current * j);

                internalArr.Add(product);
            }

            foreach (var tem in internalArr)
            {
                Console.Write(tem+" ");
            }
        }
    }
}
