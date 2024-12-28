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

            var authers = context.Authors.Find(1);
            context.Authors.Remove(authers);

            Console.ReadLine();
        }
    }
}
