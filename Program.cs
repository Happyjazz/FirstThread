using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();

            Thread t1 = new Thread(() => print.PrintMethod("Hello World", 20, Thread.CurrentThread.Name, 500));
            Thread t2 = new Thread(() => print.PrintMethod("Hello World", 20, Thread.CurrentThread.Name, 100));
            Thread t3 = new Thread(() => print.PrintMethod("Hello World", 20, Thread.CurrentThread.Name));
            Thread t4 = new Thread(() => print.PrintMethod("Hello World", 20, Thread.CurrentThread.Name));

            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t3.Name = "Thread3";
            t4.Name = "Thread4";

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            t1.Join();
            Console.WriteLine("...Og slut!");
        }
    }
}
