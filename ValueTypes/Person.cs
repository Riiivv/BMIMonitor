using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIMonitor.ReferenceTypes
{
    public class Person
    {
        // Properties for personens data
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }  // Vægt i kg
        public double Height { get; set; }  // Højde i meter

        // BMI property, beregnet med Measurement struct
        public double BMI
        {
            get
            {
                // Brug Measurement struct uden using direkte ved at bruge fuldt navn
                var measurement = new BMIMonitor.ValueTypes.Measurement(Weight, Height);
                return measurement.BMI;
            }
        }
    }
}
