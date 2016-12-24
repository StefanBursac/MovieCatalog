using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {   Movie m = new Movie();
        List<Movie> movie = new List<Movie>();
        public void AddMoive()
        {

            m.Name = "Stefan";
            m.Director = "Stefan";
            movie.Add(m);
        }



        static void Main(string[] args) {

            Console.WriteLine();


        }

    }
}




