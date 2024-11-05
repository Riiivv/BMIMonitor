using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BMIMonitor.ValueTypes
{
    public struct Measurement
    {
        // Property for BMI-tallet
        public double BMI { get; private set; }

        // Constructor tager imod vægt og højde, og udregner BMI
        public Measurement(double weight, double height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Højde skal være større end nul.");
            }

            // Udregn BMI og tildel til BMI-property
            BMI = weight / (height * height);
        }
    }
}
