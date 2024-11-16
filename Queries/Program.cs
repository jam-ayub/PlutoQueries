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
                        join c in context.Courses on a.Id equals c.AuthorId into g
                        select new { AuthorName = a.Name, Courses = g.Count() };

            foreach (var group in query)
            {
                Console.WriteLine("{0} ({1})", group.AuthorName, group.Courses);
            }

            Console.ReadLine();
        }
    }
}
