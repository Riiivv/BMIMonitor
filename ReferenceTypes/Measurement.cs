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
        public double BMI { get; private set; }

        public Measurement(double weight, double height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Højde skal være større end nul.");
            }

            BMI = weight / (height * height);
        }
    }
}
