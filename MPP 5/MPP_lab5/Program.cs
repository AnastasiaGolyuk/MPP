using System;
using System.Linq;
using System.Reflection;

namespace MPP_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = 
                "C:\\Users\\User\\RiderProjects\\MPP_lab1\\MPP_lab1\\bin\\Debug\\netcoreapp3.1\\MPP_lab1.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            var types = assembly.GetTypes()
                .OrderBy(type => type.Namespace + type.FullName);
            foreach (var type in types)
            {
                if (type.IsPublic)
                {
                    Console.Out.WriteLine(type.FullName);
                }
            }
        }
    }
}