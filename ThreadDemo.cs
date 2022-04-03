using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadDemo
    {
        public void Test() 
        {
            lock (this)
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                }
            }
        }

        //public void Test2() 
        //{
        //    for(int i = 0; i < 5; i++) 
        //    {
        //        Console.WriteLine(i);
        //        Thread.Sleep(200);
        //    }
        //
        //}
    }
}
