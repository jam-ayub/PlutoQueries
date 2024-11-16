using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // LINQ Syntax
            var query = from c in context.Courses 
                        group c by c.Level
                        into g
                        select g;

            foreach (var group in query)
            {
                Console.WriteLine("{0} ({1})", group.Key, group.Count());
            }

            Console.ReadLine();
        }
    }
}
