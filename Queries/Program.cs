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
            var query = context.Courses.Join(
                context.Authors, 
                c => c.AuthorId, 
                a => a.Id, 
                (course, author) => new 
                    {
                        CourseName = course.Name,
                        AuthorName = author.Name,
                    });

            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.AuthorName, group.CourseName);
            }

            Console.ReadLine();
        }
    }
}
