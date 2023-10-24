// Tobias Skog .NET23
using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Parallellogram that inherits the Geometri class
    public class Parallellogram : Geometri
    {
        // The Parallellogram class requires the Height and BaseParallelLength attributes
        // The access modifier is set to protected to keep the attributes inside the class
        // and encapsulate them
        public double Height { get; private set; }
        public double BaseParallelLength { get; private set; }

        // The base constructor for the Rektangel class
        public Parallellogram()
        {
            // Assigning Height to a default value
            Height = 12;
            // Assigning BaseParallelLength to a default value
            BaseParallelLength = 18;
        }
        // A overload constructor for the Parallellogram Class allowing the user
        // to pass in a height and a baseParallelLength when creating the Parallellogram
        public Parallellogram(double height, double baseParallelLength)
        {
            // Creating two new double variables to recieve the return of the GetPositiveInt method wich
            // is a method in its own class designed to prompt the user for a new value
            // incase the original value passed in is not within the accepted range and 
            // could cause the program to crash when doing the Area calculation
            // The method will keep asking the user for a value until it recieves one
            // that is accepted, takes a double and a prompt as input
            double controlledHeight = VerifiedUserInput.GetPositiveDouble(height,
                                      "Fel format på höjden vid skapande av Triangel objektet\n" +
                                      "Ange höjden med ett positivt heltal: ");
            double controlledBaseParallelLength = VerifiedUserInput.GetPositiveDouble(baseParallelLength,
                                               "Fel format på basbredden vid skapande av Triangel objektet\n" +
                                               "Ange baslängden med ett positivt heltal: ");

            // Assigning Height to controlledHeight
            Height = controlledHeight;
            // Assigning BaseParallelLength to controlledBaseParallelLength
            BaseParallelLength = controlledBaseParallelLength;

        }

        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Parallellogram class
        public override double Area()
        {
            // Parallellogram Area Formula: Area = Height * BaseParallelLength
            // Creating a new double area and assigning it to the value 
            // of the Parallellogram Area Formula seen above
            double area = Height * BaseParallelLength;
            return area;
        }
    }
}
