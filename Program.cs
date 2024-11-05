using BMIMonitor.ReferenceTypes;
using BMIMonitor.ValueTypes;

namespace BMIMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a Person object using object initializer
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Weight = 70,  // Weight in kilograms
                Height = 1.75  // Height in meters
            };

            // Output the person's calculated BMI
            Console.WriteLine($"Person: {person.FirstName} {person.LastName}");
            Console.WriteLine($"Weight: {person.Weight} kg, Height: {person.Height} m");
            Console.WriteLine($"Calculated BMI: {person.BMI:F2}");
            Console.ReadKey();
        }
    }
}
