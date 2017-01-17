using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> MyList = new List<string>();

            MyList.Add("Stefan");
            MyList.Add("Mama");

            foreach (string s in MyList)
            {
                Console.WriteLine(s);
            }

            List<Book> MyBookList = new List<Book>();

            MyBookList.Add(new Book() { name = "MojaKnjiga", writer="Ja", year=2017});
            MyBookList.Add(new Book() { name = "Knjiga", writer = "a", year = 2010 });

            foreach (Book b in MyBookList)
            {
                Console.WriteLine(b.name+" "+b.year+" "+b.writer);
            }

            Console.ReadKey();
        }
    }
}
