using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBindingExersize
{
    public class Movie
    {
        public List<string> movieList = new List<string>();



        public string Name { get; set; }

        public void AddMovie()
        {
            movieList.Add("Stefan");
        }

      


    }
}
