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
            var query = context.Authors.GroupJoin(
                context.Courses, 
                a => a.Id, 
                c => c.AuthorId,
                (author, course) => new
                {
                    AuthorName = author.Name,
                    Courses = course.Count()
                });

            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.AuthorName, group.Courses);
            }

            Console.ReadLine();
        }
    }
}
