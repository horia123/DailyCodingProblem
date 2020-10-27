using System;

namespace Days.Day5
{
    public class Day5
    {
        /*
         * cons(a, b) constructs a pair, and car(pair) and cdr(pair) returns the first and last element of that pair. 
         * For example, car(cons(3, 4)) returns 3, and cdr(cons(3, 4)) returns 4.
         * Given this implementation of cons:
         * 
         * def cons(a, b):
         *      def pair(f):
         *          return f(a, b)
         *      return pair
         *      
         * Implement car and cdr.
         */
        public void Run()
        {
            //I've allowed myself the comfort to implement them in a generic manner.
            var pair = new Pair<string>("first", "last");
            Console.WriteLine($"car(pair(first,last)) gives: {Pair<string>.Car(pair)}");
            Console.WriteLine($"cdr(pair(first,last)) gives: {Pair<string>.Cdr(pair)}");

            var intPair = new Pair<int>(3, 4);
            Console.WriteLine($"car(pair(3,4)) gives: {Pair<int>.Car(intPair)}");
            Console.WriteLine($"cdr(pair(3,4)) gives: {Pair<int>.Cdr(intPair)}");
        }        
    }
}
