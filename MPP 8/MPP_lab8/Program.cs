using System;
using System.Linq;
using System.Reflection;
using Lab8Attribute;

namespace MPP_lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Assembly.GetExecutingAssembly().Location;
            Console.WriteLine(path);
            Assembly assembly = Assembly.LoadFrom(path);
            var types = assembly.GetTypes()
                .OrderBy(type => type.Namespace + type.FullName);
            foreach (var type in types)
            {
                if (type.IsPublic 
                    && Attribute.GetCustomAttribute(type, typeof(ExportClass)) != null )
                {
                    Console.Out.WriteLine(type.FullName);
                }
            }
        }
    }
}

namespace Test1
{
    [ExportClass]
    public class Bird1
    {
    }

    [ExportClass]
    class A
    {
    }
}

namespace Test2
{
    public class Cat
    {
    }
    
    [ExportClass]
    public class Bird2
    {
    }
}