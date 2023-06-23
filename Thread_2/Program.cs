namespace Thread_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Students students = new Students(1, $"{i}");

                Room room = new Room(students);
                
                room.TakeExam(students);
            }
        }
    }

    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Students(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Room
    {

        public Room(Students students)
        {
            
            Thread thread = new Thread(() => TakeExam(students));
            thread.Name = "test 1  ";
            thread.Start();
        }

        public void TakeExam(Students students)
        {
            while(5 > 0)
            {
                Semaphore semaphore = new Semaphore(2,5);

                semaphore.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} entered");

                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} leaving");

                semaphore.Release();
            }
        }
    }
}