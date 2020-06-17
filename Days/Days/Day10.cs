using System;
using System.Threading;

namespace Days
{
    public class Day10
    {
        public void myF()
        {
            Console.WriteLine("Something");
        }
        public void JobScheduler(int n)
        {
            //Works for a basic console app where blocking the UI Thread proves this is working
            Thread.Sleep(n);
            myF();

            //Best approach:
            //Task.Delay(n).ContinueWith(t => myF());
        }
    }
}
