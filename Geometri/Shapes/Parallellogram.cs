// Tobias Skog .NET23
using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Parallellogram that inherits the Geometri class
    public class Parallellogram : Geometri
    {
        // The Parallellogram class requires the _Height and _BaseParallelLength attributes
        // The access modifier is set to protected to keep the attributes inside the class
        // and encapsulate them
        protected double _Height { get; set; }
        protected double _BaseParallelLength { get; set; }

        // The base constructor for the Rektangel class
        public Parallellogram()
        {
            // Assigning _Height to a default value
            _Height = 12;
            // Assigning _BaseParallelLength to a default value
            _BaseParallelLength = 18;
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

            // Assigning _Height to controlledHeight
            _Height = controlledHeight;
            // Assigning _BaseParallelLength to controlledBaseParallelLength
            _BaseParallelLength = controlledBaseParallelLength;

        }

        // Public int Height and BaseParallelLength is accessors for the user to be able to get  
        // the _Height and _BaseParallelLength of the Parallellogram object outside of the scope of the class
        public double Height
        {
            get { return _Height; }
        }
        public double BaseParallelLength
        {
            get { return _BaseParallelLength; }
        }


        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Parallellogram class
        public override double Area()
        {
            // Parallellogram Area Formula: Area = _Height * _BaseParallelLength
            // Creating a new double area and assigning it to the value 
            // of the Parallellogram Area Formula seen above
            double area = _Height * _BaseParallelLength;
            return area;
        }
    }
}
