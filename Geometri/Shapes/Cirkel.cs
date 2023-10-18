// Tobias Skog .NET23
using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Cirkel that inherits the Geometri class
    public class Cirkel : Geometri
    {
        // The Cirkel class requires the _Radius attribute
        // The access modifier is set to protected to keep the
        // attribute inside the class and encapsulate it
        protected double _Radius { get; set; }

        // The base constructor for the Cirkel class
        public Cirkel()
        {
            // Assigning _Radius to a default value
            _Radius = 4;
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

            // Assigning _Radius to controlledRadius
            _Radius = controlledRadius;
        }

        // Public double Radius is a accessor for the user to be able to get 
        // the _Radius of the Cirkel object outside of the scope of the class
        public double Radius
        {
            get { return _Radius; }
        }

        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Cirkel class
        public override double Area()
        {
            // Cirkel Area Formula: Area = _PI ∗ _Radius²
            // Creating a new double area and assigning it to the value 
            // of the Cirkel Area Formula seen above
            // Using Math.Pow(_Radius, 2) to calculate _Radius²
            double area = Math.Pow(_Radius, 2) * _PI;
            // returning the area
            return area;
        }
    }
}
