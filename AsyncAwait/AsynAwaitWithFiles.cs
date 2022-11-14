using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AsyncAwait
{
    internal class AsynAwaitWithFiles
    {
        SqlCommand cmd;
        public static async Task<int>ReadFromFile(string file)
        {
            int fileLength = 0;
            Console.WriteLine("start reading the File...");
            using(StreamReader sr=new StreamReader(file))
            {
            string res=await sr.ReadToEndAsync();
                fileLength = res.Length;
            }
            Console.WriteLine("Reading of file is completed...");
            return fileLength;
        }
        static async void FileToBeRead()
        {
            string filepath = @"C:\Users\CR69908\largeFile.txt";
            Task<int>task=ReadFromFile(filepath);
            Console.WriteLine("some other work is being done..");
            Console.WriteLine("some other work is being done..");
            Console.WriteLine("some other work is being done..");
            int length = await task;
            Console.WriteLine($"Total length of large file is :{length}");
            Console.WriteLine("some other is completed...");
            Console.WriteLine("some other is completed...");
            Console.WriteLine("some other is completed...");

        }
        static void Main()
        {
            Task t = new Task(FileToBeRead);
            t.Start();
            t.Wait();
            Console.ReadLine();
          //  Task<int> task=ReadFromFile(@"C:\Users\CR69908\largeFile.txt")
        }
    }
}
