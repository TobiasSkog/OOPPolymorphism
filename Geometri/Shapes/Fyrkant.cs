// Tobias Skog .NET23
using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Fyrkant that inherits the Geometri class
    public class Fyrkant : Geometri
    {
        // The Fyrkant class requires the SideLength attribute
        // The access modifier is set to protected to keep the
        // attribute inside the class and encapsulate it
        public double SideLength { get; private set; }

        // The base constructor for the Fyrkant class
        public Fyrkant()
        {
            // Assigning SideLength to a default value
            SideLength = 4;
        }

        // A overload constructor for the Fyrkant Class allowing the user
        // to pass in a sideLength when creating the Fyrkant
        public Fyrkant(double sideLength)
        {
            // Creating a new double variable to recieve the return of the GetPositiveDouble method wich
            // is a method in its own class designed to prompt the user for a new value
            // incase the original value passed in is not within the accepted range and 
            // could cause the program to crash when doing the Area calculation
            // The method will keep asking the user for a value until it recieves one
            // that is accepted, takes a double and a prompt as input
            double controlledSideLength = VerifiedUserInput.GetPositiveDouble(sideLength,
                                   "Fel format på radien vid skapande av Fyrkant objektet\n" +
                                   "Ange sidolängden med ett positivt heltal: ");

            // Assigning SideLength to controlledSideLength
            SideLength = controlledSideLength;
        }
        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Fyrkant class
        public override double Area()
        {
            // Fyrkant Area Formula: Area = SideLength²
            // Creating a new double area and assigning it to the value 
            // of the Fyrkant Area Formula seen above
            // Using Math.Pow(Radius, 2) to calculate SideLength²
            double area = Math.Pow(SideLength, 2);
            // returning the area
            return area;
        }
    }
}
