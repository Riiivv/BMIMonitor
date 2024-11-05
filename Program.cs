using BMIMonitor.ReferenceTypes;
using BMIMonitor.ValueTypes;

namespace BMIMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Weight = 70,  
                Height = 1.75 
            };

            // Output the person's calculated BMI
            Console.WriteLine($"Person: {person.FirstName} {person.LastName}");
            Console.WriteLine($"Weight: {person.Weight} kg, Height: {person.Height} m");
            Console.WriteLine($"Calculated BMI: {person.BMI:F2}");
            Console.ReadKey();
        }
    }
}
