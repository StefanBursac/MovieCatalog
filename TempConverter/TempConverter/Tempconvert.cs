using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    public class Tempconvert
    {

        public Tempconvert()
        {
          double fahrenhajt = 0;
        }



        public double CelsiusToFahrehajt(double tempCelsius)
        {
            double fahrenhajt = tempCelsius * 9 / 5;
            return fahrenhajt; 
        }
    }
}
