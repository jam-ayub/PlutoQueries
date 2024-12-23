using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            
            var query = context.Courses.ToList();

            //Here EF Send query to get courses and for each couse it send another query to get Author
            //This is an N+1 Problem as to get N courses we need to send 1 another query to DB to get Authers
            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.Name, group.Author.Name);
            }

            Console.ReadLine();
        }
    }
}
