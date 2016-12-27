using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorVezba
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee(2,5);

            Employee emp2 = new Employee();
            emp2.YearsOfService = 2;
            emp2.Office = 5;

            Employee emp3 = new Employee()
            {
                YearsOfService = 2,
                Office = 5
            };





            Console.WriteLine("{0},{1}", emp.YearsOfService, emp.Office );
            Console.WriteLine("{0},{1}",emp2.YearsOfService, emp.Office);
            Console.WriteLine("{0},{1}", emp2.YearsOfService, emp3.Office);





            Programer programer = new Programer("Junior");
       
            Console.WriteLine(programer.NivoZnanja);







            Console.ReadKey();

        }
    }
}
