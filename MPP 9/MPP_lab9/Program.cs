using System;

namespace MPP_lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<double> list = new DynamicList<double>(10, 0.75);
            Random rnd = new Random();
            for (int j = 0; j < 5; j++)
            {
                list.Add(Math.Round(rnd.NextDouble(),1));
            }
            list.Add(400);
            Console.WriteLine(list.ToString());
            Console.WriteLine("{0} {1}\n",list.Count, list.Capacity);
            
            for (int j = 0; j < 10; j++)
            {
                list.Add(Math.Round(rnd.NextDouble(),1));
            }
            Console.WriteLine(list.ToString());
            Console.WriteLine("{0} {1}\n",list.Count, list.Capacity);

            bool removed=list.Remove(400);
            Console.WriteLine(list.ToString());
            Console.WriteLine("{0} {1} {2}\n",list.Count, list.Capacity,removed);
            
            removed=list.Remove(10);
            Console.WriteLine(list.ToString());
            Console.WriteLine("{0} {1} {2}\n",list.Count, list.Capacity,removed);

            removed=list.RemoveAt(3);
            Console.WriteLine(list.ToString());
            Console.WriteLine("{0} {1} {2}\n",list.Count, list.Capacity, removed);
            
            removed=list.RemoveAt(-2);
            Console.WriteLine(list.ToString());
            Console.WriteLine("{0} {1} {2}\n",list.Count, list.Capacity, removed);
            
            list.Clear();
            Console.WriteLine(list.ToString());
            Console.WriteLine("{0} {1}\n",list.Count, list.Capacity);
        }
    }
}
