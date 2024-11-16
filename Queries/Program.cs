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
                        join a in context.Authors on c.AuthorId equals a.Id
                        select new { CourseName = c.Name, AuthorName = a.Name};

            foreach (var group in query)
            {
                Console.WriteLine("{0} ({1})", group.CourseName, group.AuthorName);
            }

            Console.ReadLine();
        }
    }
}
