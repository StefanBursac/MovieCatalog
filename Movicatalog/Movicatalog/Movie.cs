using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Movicatalog
{
    public class Movie 
    {
        private string name;
        private string genre;
        private string director;
        private DateTime date;

        public string Name
        {
            get { return name; }

            set { name = value; }

        }

        public string Genre
        {
            get { return genre; }

            set { genre = value; }
        }

        public string Director
        {
            get { return director; }

            set { director = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }

}


