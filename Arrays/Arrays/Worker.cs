using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Worker
    {
        public Worker()
        {
            Work();

        }

        public void Work()
        {
            Person[] people = new Person[7];
            people[4] = new Person { Name = "Frodo" };
            Person person = people[4];

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }

        }

    }
}
