using System;

namespace MPP_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var logBuffer = new LogBuffer("C:\\Users\\User\\RiderProjects\\MPP_lab6\\MPP_lab6\\test.txt");
            for (var i = 0; i < 210; i++)
            {
                logBuffer.Add(i.ToString());
            }
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
            logBuffer.Close();
        }
    }
}
