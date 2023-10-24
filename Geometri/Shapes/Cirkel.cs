// Tobias Skog .NET23
using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Cirkel that inherits the Geometri class
    public class Cirkel : Geometri
    {
        // The Cirkel class requires the Radius attribute
        // The access modifier is set to protected to keep the
        // attribute inside the class and encapsulate it
        public double Radius { get; private set; }

        // The base constructor for the Cirkel class
        public Cirkel()
        {
            // Assigning Radius to a default value
            Radius = 4;
        }

        // A overload constructor for the Cirkel Class allowing the user
        // to pass in a radius when creating the Cirkel
        public Cirkel(double radius)
        {
            // Creating a new double variable to recieve the return of the GetPositiveDouble method wich
            // is a method in its own class designed to prompt the user for a new value
            // incase the original value passed in is not within the accepted range and 
            // could cause the program to crash when doing the Area calculation
            // The method will keep asking the user for a value until it recieves one
            // that is accepted, takes a double and a prompt as input
            double controlledRadius = VerifiedUserInput.GetPositiveDouble(radius,
                                   "Fel format på radien vid skapande av Cirkel objektet\n" +
                                   "Ange radien med en positiv siffra: ");

            // Assigning Radius to controlledRadius
            Radius = controlledRadius;
        }

        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Cirkel class
        public override double Area()
        {
            // Cirkel Area Formula: Area = PI ∗ Radius²
            // Creating a new double area and assigning it to the value 
            // of the Cirkel Area Formula seen above
            // Using Math.Pow(Radius, 2) to calculate Radius²
            double area = Math.Pow(Radius, 2) * PI;
            // returning the area
            return area;
        }
    }
}
