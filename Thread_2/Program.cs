using System.Diagnostics;

namespace Thread_2
{
    internal class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            #region thread

            Thread thread = new Thread(() => Print());
            thread.Name = "Test        ";

            Thread thread1 = new Thread(() => Print());
            thread1.Name = "Test  1    ";

            Thread thread2 = new Thread(() => Print());
            thread2.Name = "Test  2    ";

            Thread thread3 = new Thread(() => Print());
            thread3.Name = "Test  3    ";

            Thread thread4 = new Thread(() => Print());
            thread4.Name = "Test  4    ";

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            #endregion


        }

        public static void Print()
        {
            lock(locker)
            {
                for (double i = 0; i < 100; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + i);
                }
            }
        }
    }
}