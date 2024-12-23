using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            
            var query = context.Courses.Single(c=>c.Id == 2);
            // EF first send query to get courses
            // Then send another query to get Tags when they are needed
            foreach (var group in query.Tags)
            {
                Console.WriteLine("{0} - ({1})", group.Id, group.Name);
            }

            Console.ReadLine();
        }
    }
}
