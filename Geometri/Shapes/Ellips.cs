// Tobias Skog .NET23
using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Ellips that inherits the Geometri class
    public class Ellips : Geometri
    {
        // The Ellips class requires the MajorAxis and MinorAxis attributes
        // The access modifier is set to protected to keep the attributes
        // inside the class and encapsulate them
        public double MajorAxis { get; private set; }
        public double MinorAxis { get; private set; }

        // The base constructor for the Ellips class
        public Ellips()
        {
            // Assigning MajorAxis to a default value
            MajorAxis = 9;
            // Assigning MinorAxis to a default value
            MinorAxis = 7;
        }

        // A overload constructor for the Ellips Class allowing the user
        // to pass in a radius and a height when creating the Ellips
        public Ellips(double majorAxis, double minorAxis)
        {
            // Creating two new double variables to recieve the return of the GetPositiveDouble method wich
            // is a method in its own class designed to prompt the user for a new value
            // incase the original value passed in is not within the accepted range and 
            // could cause the program to crash when doing the Area calculation
            // The method will keep asking the user for a value until it recieves one
            // that is accepted, takes a double and a prompt as input
            double controlledMajorAxis = VerifiedUserInput.GetPositiveDouble(majorAxis,
                                   "Fel format på radien vid skapande av Ellips objektet\n" +
                                   "Ange radien med en positiv siffra: ");

            double controlledMinorAxis = VerifiedUserInput.GetPositiveDouble(minorAxis,
                                      "Fel format på radien vid skapande av Ellips objektet\n" +
                                      "Ange radien med en positiv siffra: ");

            // Assigning MajorAxis to controlledMajorAxis
            MajorAxis = controlledMajorAxis;
            // Assigning MinorAxis to controlledMinorAxis
            MinorAxis = controlledMinorAxis;
        }


        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Ellips class
        public override double Area()
        {
            // Ellips Area Formula: Area = PI * MajorAxis/2 * MinorAxis/2
            // Creating a new double area and assigning it to the value 
            // of the Ellips Area Formula seen above
            double area = PI * MajorAxis / 2 * MinorAxis / 2;
            // returning the area
            return area;
        }
    }
}
