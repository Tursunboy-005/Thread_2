using System.Diagnostics;

namespace Thread_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Thread thread = new Thread(() => Print());
            Thread thread1 = new Thread(() => Print());
            Thread thread2 = new Thread(() => Print());
            Thread thread3 = new Thread(() => Print());
            Thread thread4 = new Thread(() => Print());
            thread.Name = "Test        ";
            thread1.Name = "Test  1    ";
            thread2.Name = "Test  2    ";
            thread3.Name = "Test  3    ";
            thread4.Name = "Test  4    ";
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            
        }

        public static void Print()
        {
            
            for (double i = 0; i < 100000; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + i);
            }
            
        }

    }
}