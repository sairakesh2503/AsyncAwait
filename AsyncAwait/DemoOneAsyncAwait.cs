using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class DemoOneAsyncAwait
    {
        static void Main()
        {
            Method2();
            Method1();
            Console.Read();
        }
        public static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + " of Method2");
                    Task.Delay(300).Wait();
                }
            });

        }
        private static void Method1()
        {
            for(int i=0; i < 25; i++)
            {
                Console.WriteLine(i+" of Method1");
                Task.Delay(300).Wait();
            }
        }
        
    }
}
