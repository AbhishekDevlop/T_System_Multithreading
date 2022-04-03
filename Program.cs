using System;
using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadDemo threadDemo = new ThreadDemo();

            Thread t1 = new Thread(new ThreadStart(threadDemo.Test));
            Thread t2 = new Thread(new ThreadStart(threadDemo.Test));
            Thread t3 = new Thread(new ThreadStart(threadDemo.Test));
            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t3.Name = "Third Thread";

            t1.Priority = ThreadPriority.Lowest;   //setting priority
            t2.Priority = ThreadPriority.BelowNormal;
            t3.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();
            t2.Join();
            t3.Start();

               

        }
    }
}
