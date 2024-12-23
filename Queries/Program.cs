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

            var auther = context.Authors.Include(a => a.Courses).Single(a => a.Id ==1);
            
            //MSD Way
            context.Entry(auther).Collection(a => a.Courses).Query().Where(c => c.FullPrice == 0).Load();

            //Better way
            context.Courses.Where(c => c.AuthorId == auther.Id && c.FullPrice == 0).Load();

            foreach (var group in auther.Courses)
            {
                Console.WriteLine("{0} - ({1})", group.Name, group.Author.Name);
            }

            Console.ReadLine();
        }
    }
}
