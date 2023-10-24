// Tobias Skog .NET23
using OOPPolymorphism.DataVerification;

namespace OOPPolymorphism.Geometri
{
    // New class Rektangel that inherits the Geometri class
    public class Rektangel : Geometri
    {
        // The Rektangel class requires the Width and Length attributes
        // The access modifier is set to protected to keep the attributes
        // inside the class and encapsulate them
        public double Width { get; private set; }
        public double Length { get; private set; }


        // The base constructor for the Rektangel class
        public Rektangel()
        {
            // Assigning Width to a default value
            Width = 4;
            // Assigning Length to a default value
            Length = 4;
        }

        // A overload constructor for the Rektangel Class allowing the user
        // to pass in a width and a length when creating the Rektangel
        public Rektangel(double width, double length)
        {
            // Creating two new double variables to recieve the return of the GetPositiveInt method wich
            // is a method in its own class designed to prompt the user for a new value
            // incase the original value passed in is not within the accepted range and 
            // could cause the program to crash when doing the Area calculation
            // The method will keep asking the user for a value until it recieves one
            // that is accepted, takes a double and a prompt as input
            double controlledWidth = VerifiedUserInput.GetPositiveDouble(width,
                                  "Fel format på höjden vid skapande av Rektangel objektet\n" +
                                  "Ange bredden med en positiv siffra: ");

            double controlledLength = VerifiedUserInput.GetPositiveDouble(length,
                                   "Fel format på radien vid skapande av Rektangel objektet\n" +
                                   "Ange längden med en positiv siffra: ");

            // Assigning Width to controlledWidth
            Width = controlledWidth;
            // Assigning Length to controlledLength
            Length = controlledLength;
        }

        // The SuperClass method Area is being implemented here with the
        // `override` keyword to be able to define it for the Rektangel class
        public override double Area()
        {
            // Rektangel Area Formula: Area = Length * Width
            // Creating a new double area and assigning it to the value 
            // of the Rektangel Area Formula seen above
            double area = Length * Width;
            // returning the area
            return area;
        }
    }
}
