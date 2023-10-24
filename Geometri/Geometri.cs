// Tobias Skog .NET23
namespace OOPPolymorphism.Geometri
{
    // Creating an abstract class Geometri that will hold all the base functionality
    // that the subclasses will use
    public abstract class Geometri
    {
        // Making PI to a constant since it will always be the same no matter what
        // assigning it to the Math.PI value to be able to do more accurate calculations
        // than the suggested `_pi = 3.141f` 
        protected const double PI = Math.PI;

        // Creating the abstract method double Area() that all the subclasses must inherit
        // The method have a public access modifier so that it can be called
        // outside of the scope of the class
        public abstract double Area();
    }
}
