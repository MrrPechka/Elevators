using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Program
    {
        static void Main()
        {
            Assembly a = Assembly.GetExecutingAssembly();
            Assembly b = Assembly.GetEntryAssembly();
            Assembly c = Assembly.GetCallingAssembly();
            Assembly d = Assembly.Load("Models");
            foreach (Type type in a.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            foreach (Type type in b.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            foreach (Type type in c.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            foreach (Type type in d.GetTypes())
                Console.WriteLine(type.FullName);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
