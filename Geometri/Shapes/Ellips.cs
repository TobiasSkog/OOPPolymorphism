using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Ellips that inherits the Geometri class
    public class Ellips : Geometri
    {
        // The Ellips class requires the _MajorAxis and _MinorAxis attributes
        // The access modifier is set to protected to keep the attributes
        // inside the class and encapsulate them
        protected int _MajorAxis { get; set; }
        protected int _MinorAxis { get; set; }

        // The base constructor for the Ellips class
        public Ellips()
        {
            // Assigning _MajorAxis to a default value
            _MajorAxis = 9;
            // Assigning _MinorAxis to a default value
            _MinorAxis = 7;
        }

        // A overload constructor for the Ellips Class allowing the user
        // to pass in a radius and a height when creating the Ellips
        public Ellips(int majorAxis, int minorAxis)
        {
            // Creating two new int variables to recieve the return of the GetPositiveInt method wich
            // is a method in its own class designed to prompt the user for a new value
            // incase the original value passed in is not within the accepted range and 
            // could cause the program to crash when doing the Area calculation
            // The method will keep asking the user for a value until it recieves one
            // that is accepted, takes a int and a prompt as input
            int controlledMajorAxis = VerifiedUserInput.GetPositveInt(majorAxis,
                                   "Fel format på radien vid skapande av Ellips objektet\n" +
                                   "Ange radien med en positiv siffra: ");

            int controlledMinorAxis = VerifiedUserInput.GetPositveInt(minorAxis,
                                      "Fel format på radien vid skapande av Ellips objektet\n" +
                                      "Ange radien med en positiv siffra: ");

            // Assigning _MajorAxis to controlledMajorAxis
            _MajorAxis = controlledMajorAxis;
            // Assigning _MinorAxis to controlledMinorAxis
            _MinorAxis = controlledMinorAxis;
        }


        // Public int MajorAxis and MinorAxis is accessors for the user to be able to get  
        // the _MajorAxis and _MinorAxis of the Ellips object outside of the scope of the class
        public int MajorAxis
        {
            get { return _MajorAxis; }
        }
        public int MinorAxis
        {
            get { return _MinorAxis; }
        }

        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Ellips class
        public override double Area()
        {
            // Ellips Area Formula: Area = _PI * _MajorAxis/2 * _MinorAxis/2
            // Creating a new double area and assigning it to the value 
            // of the Ellips Area Formula seen above
            double area = _PI * _MajorAxis / 2 * _MinorAxis / 2;
            // returning the area
            return area;
        }
    }
}
