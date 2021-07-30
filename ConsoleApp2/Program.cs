using System;
using System.Threading;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DisplayMessage);
            Thread t2 = new Thread(DisplayMessage);
            Thread t3 = new Thread(DisplayMessage);
            Thread t4 = new Thread(Display);
            Thread t5= new Thread(Display);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            Console.Read();
        }
        private static object lobj=new object();
        static void DisplayMessage()
        {
            lock (lobj)
            {
                Console.Write("Hi This is ");
                Thread.Sleep(1000);
                Console.WriteLine("GANESHRAJ!!!");
            }
        }
        static void Display()
        {
            lock (lobj)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Value of i is : " + i);
                }
            }
        }
    }
}
