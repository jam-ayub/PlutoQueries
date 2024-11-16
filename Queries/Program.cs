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
            var query = context.Authors.SelectMany(
                a => context.Courses, 
                (author, course) => new
                {
                    AuthorName = author.Name,
                    CoursesName = course.Name
                });

            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.AuthorName, group.CoursesName);
            }

            Console.ReadLine();
        }
    }
}
