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
                        where c.Name.Contains("c#")
                        orderby c.Name
                        select c;

            //foreach (var course in query)
            //    Console.WriteLine(course.Name);

            // Extention Methods
            var courses = context.Courses
                .Where(c => c.Name.Contains("c#"))
                .OrderBy(c => c.Name);

            foreach (var course in courses)
                Console.WriteLine(course.Name);

            Console.ReadLine();
        }
    }
}
