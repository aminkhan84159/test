using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
     public class Movie : Book
    {
        public Movie(string name, int year) : base(name)
        {
            Console.WriteLine($"Hello {name} you are {year} years old");
        }
    }
}
