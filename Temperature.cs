using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Temperature
    {
        public double Fahrenheit { get; set; }
        public double Celsius { get; set; }

        public Temperature()
        {

        }

        public double ToCelsius( double Fahren)
        {
            return (Fahren - 32) * 5 / 9;
        }

        public double ToFahrenheit(double Celsius)
        {
            return (Celsius*9/5)+32;
        }
    }
}
