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
            var query = from a in context.Authors
                        from c in context.Courses
                        select new { AuthorName = a.Name, CourseName = c.Name };

            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.AuthorName, group.CourseName);
            }

            Console.ReadLine();
        }
    }
}
