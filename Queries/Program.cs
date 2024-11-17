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

            // Aggregating
            // .Count .Min .Max .Average these all are aggregate functions
            context.Courses.Count();

            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.AuthorName, group.CoursesName);
            }

            Console.ReadLine();
        }
    }
}
