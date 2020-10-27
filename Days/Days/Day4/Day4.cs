using System;
using System.Collections.Generic;
using System.Linq;

namespace Days.Day4
{
    /*
     * Given an array of integers, find the first missing positive integer in linear time and constant space. 
     * In other words, find the lowest positive integer that does not exist in the array. 
     * The array can contain duplicates and negative numbers as well.
     * For example, given the input `[3,4,-1,1]` should give `2`.
     * The input `[1,2,0]` should give `3`
     */
    public class Day4
    {
        public void Run()
        {
            //I suppose that the first missing positive integer will be in the 1-100 range.
            List<int> arraryOfZeroes = Enumerable.Repeat(0, 100).ToList();
            List<int> arraryOfZeroes2 = Enumerable.Repeat(0, 100).ToList();

            var list1 = new List<int> { 3, 4, -1, 1 };
            var list2 = new List<int> { 1,2,0 };

            foreach (var item in list1)
            {
                if(item > 0)
                {
                    arraryOfZeroes[item-1] = item;
                }
            }

            foreach (var item in list2)
            {
                if (item > 0)
                {
                    arraryOfZeroes2[item - 1] = item;
                }
            }

            Console.WriteLine("For array: {3, 4, -1, 1}. The first positive missing is: ");
            foreach (var item in arraryOfZeroes)
            {
                if(item == 0)
                {
                    Console.WriteLine($"The first positive missing is: {arraryOfZeroes.IndexOf(item) + 1}");
                    break;
                }
            }

            Console.WriteLine("For array: {1, 2, 0, -1}. The first positive missing is: ");
            foreach (var item in arraryOfZeroes2)
            {
                if (item == 0)
                {
                    Console.WriteLine($"The first positive missing is: {arraryOfZeroes2.IndexOf(item) + 1}");
                    break;
                }
            }

        }
    }
}
