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

            var authers = context.Authors.ToList();
            var auther = context.Authors.Single(x => x.Id == 1);

            var course = new Course
            {
                Name = "New Course",
                Description = "Math Course",
                FullPrice = 0,
                Level = 1,
                Author = auther
            };

            Console.ReadLine();
        }
    }
}
