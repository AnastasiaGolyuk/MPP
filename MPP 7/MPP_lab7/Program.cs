using System;
using System.Threading;

namespace MPP_lab7
{
    class Program
    {
        public static void Main(string[] args)
        {
            var tasks = CreateTasks();
            Parallel.WaitAll(tasks);
        }

        private static WaitCallback[] CreateTasks()
        {
            WaitCallback[] tasks = new WaitCallback[21];
            for (int i = 0; i < tasks.Length; i++)
            {
                int j = i;
                tasks[i] = obj =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Task {j+1} completed.");
                };
            }

            return tasks;
        }
    }
}