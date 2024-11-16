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
                        where c.Author.Id == 1
                        orderby c.Level descending, c.Name
                        select new { Name = c.Name, Author = c.Author.Name};

            foreach (var course in query)
                Console.WriteLine(course.Name);

            Console.ReadLine();
        }
    }
}
