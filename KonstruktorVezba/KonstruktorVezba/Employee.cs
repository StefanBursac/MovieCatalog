using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorVezba
{
    public class Employee
    {

        public int YearsOfService { get; set; }
        public int Office { get; set; }


        public Employee() { }


        public Employee(int yearsOfService, int office)
        {
            YearsOfService = yearsOfService;
            Office = office;
        }

        


    }
}
