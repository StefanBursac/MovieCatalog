using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbaSaListama
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Stefan", LastName = "Bursac", Age = 31, Sex = "Male"});
            people.Add(new Person() { Name = "Nafets", LastName = "Casrub", Age = 31, Sex = "Female" });

            foreach (Person person in people)
            {
                Console.WriteLine(person.Name+person.LastName+person.Age+person.Sex);
            }













            Console.ReadLine();
        }

    }
}
