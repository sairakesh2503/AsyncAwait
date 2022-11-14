using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace ConAsyncAwait
{
    internal class Program
    {
        static void CountUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("Thread of Count Up:" + Thread.CurrentThread.ManagedThreadId);
        }
        static void CountDn()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i + ",");
                Thread.Sleep(500);
            }
            Console.WriteLine("Thread of Count Down :" + Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Thread Id is :" + Thread.CurrentThread.ManagedThreadId);
            ThreadStart th1 = new ThreadStart(CountDn);
            Thread t1 = new Thread(th1);
            t1.Start();
            Console.WriteLine();
            Thread t2 = new Thread(new ThreadStart(CountUp));
            t2.Start();
            Console.WriteLine();
            Console.Read();



        }
    }
}