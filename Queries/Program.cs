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
            var query = context.Courses
                .GroupBy(c => c.Level);

            foreach (var group in query)
            {
                Console.WriteLine("Key: ", group);

                foreach (var item in group)
                { 
                    Console.WriteLine("\t", item.Name); 
                }
                //Console.WriteLine("{0} - ({1})", group.Id, group.Name);
            }

            Console.ReadLine();
        }
    }
}
