using System.Threading.Channels;

namespace Thread_2
{
    internal class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            Thread thread = new Thread(() => Print("salom"));   
            thread.Name = "Test  : ";

            Thread thread1 = new Thread(() => Print("salom"));
            thread1.Name = "Test  2 :";

            thread.Start();
            thread1.Start();
        }
        public static void Print(string s)
        {
            lock(locker)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s[i]);
                }
                Console.WriteLine();
            }
        }
    }
}