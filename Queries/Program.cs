using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // Extention Methods Syntax
            var query = context.Courses.Where(c => c.Level == 1);

            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.Level, group.Name);
            }

            Console.ReadLine();
        }
    }
}
