using System;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            //This will include Auther in the query that EF send to DB and Solve N+1 Problem
            var query = context.Courses.Include(c => c.Author).ToList();

            foreach (var group in query)
            {
                Console.WriteLine("{0} - ({1})", group.Name, group.Author.Name);
            }

            Console.ReadLine();
        }
    }
}
