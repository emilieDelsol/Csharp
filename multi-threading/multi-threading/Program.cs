using System;
using System.Collections.Generic;
using System.Threading;

namespace multi_threading
{
    class Program

    {
        private static Mutex mut = new Mutex();
        private const int numIterations = 1;
        private const int numThreads = 3;
        public static void Main()
        {
            
            while (true)
            {
                Console.WriteLine("\nNew game:");
                var threadStartDelegate = new ThreadStart(OnThreadStart);
                var threads = new List<Thread>();
                for (int i = 0; i < numThreads; i++)
                {
                    threads.Add(new Thread(threadStartDelegate));
                }

                for (int i = 0; i < threads.Count; i++)
                {
                    threads[i].Name = $"{i + 1}";
                    threads[i].Start(); // We launch the threads
                }
                foreach (var t in threads)
                {
                    t.Join(); // We wait until all threads are finished
                }
                Console.WriteLine("Press Enter for new game:");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }
        }

	

		private static void OnThreadStart()
		{
            var random = new System.Random();

            var executionTime = random.Next(1, 4);

            var timeSpan = TimeSpan.FromSeconds(executionTime);

            Thread.Sleep(timeSpan); // Simulate computing by waiting a random period of time
     
                UseResource();
    
        }        

		private static void UseResource()
		{
            if (mut.WaitOne(1000))
            {
                Console.WriteLine("{0} has win", Thread.CurrentThread.Name);

                Thread.Sleep(4000);
                mut.ReleaseMutex();
             
            }
            else
            {
                Console.WriteLine("{0} loose", Thread.CurrentThread.Name);
            }
        }
	}
}
