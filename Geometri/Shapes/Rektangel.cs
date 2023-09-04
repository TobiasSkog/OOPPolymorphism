using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Rektangel that inherits the Geometri class
    public class Rektangel : Geometri
    {
        // The Rektangel class requires the _Width and _Length attributes
        // The access modifier is set to protected to keep the attributes
        // inside the class and encapsulate them
        protected int _Width { get; set; }
        protected int _Length { get; set; }


        // The base constructor for the Rektangel class
        public Rektangel()
        {
            // Assigning _Width to a default value
            _Width = 4;
            // Assigning _Length to a default value
            _Length = 4;
        }

        // A overload constructor for the Rektangel Class allowing the user
        // to pass in a width and a length when creating the Rektangel
        public Rektangel(int width, int length)
        {
            // Creating two new int variables to recieve the return of the GetPositiveInt method wich
            // is a method in its own class designed to prompt the user for a new value
            // incase the original value passed in is not within the accepted range and 
            // could cause the program to crash when doing the Area calculation
            // The method will keep asking the user for a value until it recieves one
            // that is accepted, takes a int and a prompt as input
            int controlledWidth = VerifiedUserInput.GetPositveInt(width,
                                  "Fel format på höjden vid skapande av Rektangel objektet\n" +
                                  "Ange bredden med ett positivt heltal: ");

            int controlledLength = VerifiedUserInput.GetPositveInt(length,
                                   "Fel format på radien vid skapande av Rektangel objektet\n" +
                                   "Ange längden med ett positivt heltal: ");

            // Assigning _Width to controlledWidth
            _Width = controlledWidth;
            // Assigning _Length to controlledLength
            _Length = controlledLength;
        }
        // Public int Width and Length is accessors for the user to be able to get the 
        // _Width and _Length of the Rektangel object outside of the scope of the class
        public int Width
        {
            get { return _Width; }
        }
        public int Length
        {
            get { return _Length; }
        }

        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Rektangel class
        public override double Area()
        {
            // Rektangel Area Formula: Area = _Length * _Width
            // Creating a new double area and assigning it to the value 
            // of the Rektangel Area Formula seen above
            double area = _Length * _Width;
            // returning the area
            return area;
        }
    }
}
