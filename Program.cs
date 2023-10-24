// Tobias Skog .NET23
using OOPPolymorphism.Geometri;

internal class Program
{

    static void Main(string[] args)
    {
        // List of type Geometri that will be our reference when writing out the information to console according to the assignment details
        // Instantiating the objects directly into the list since we will be using a reference to call them we do not need direct variable names
        // to our objects but will handle that in a for loop later
        // Creating 2 Rektangel objects where
        // The first Rektangel is using the default value defined in the constructor of the class
        // The second Rektangel gets the input 5, 8 > the constructor assigns the Width to 5 and Length to 8
        // Creating 2 Fyrkant objects where
        // The first Fyrkant is using the default value defined in the constructor of the class
        // The second Fyrkant gets the input 8 > the constructor assigns the SideLength to 8
        // Creating 2 Cirkel objects where
        // The first Cirkel is using the default value defined in the constructor of the class
        // The second Cirkel gets the input 5 > the constructor assigns the Radius to 5
        // Creating 2 Parallellogram Objects where
        // The first Parallellogram is using the default value defined in the constructor of the class
        // The second Parallellogram gets the input 5, 6 > the constructor assigns the Height to 5 and BaseParallelLength to 6
        // Creating 2 Ellips Objects where
        // The first Ellips is using the default value defined in the constructor of the class
        // The second Ellips gets the input 12, 8 > the constructor assigns the MajorAxis to 12 and MinorAxis to 8

        List<Geometri> referensLista = new(){
                   new Rektangel(), new Rektangel(5, 8),
                   new Fyrkant(), new Fyrkant(8),
                   new Cirkel(), new Cirkel(5),
                   new Parallellogram(), new Parallellogram(5, 6),
                   new Ellips(), new Ellips(12, 8)
            };

        // Using a foreach loop with a Geometri referens as our reference object looping thru our referensLista that contains all the shapes
        // Creating a string that will be our ouput to the user and depending on the shape we add that to the string and then write to the 
        // console what type of object and calling the method Area() with the refence object set as the specific type
        // Since we return variables of the type ´double´ I decided to limit the amount of decimals to two by using `:.##`
        // to limit the output to the console but not limiting the accuracy of the calculated results
        // By using `.##` instead of `.00` I only write out values to console IF there is a numerical value at that location of the string


        foreach (Geometri referens in referensLista)
        {
            string geometriForm = "Area ";
            if (referens is Rektangel)
            {
                geometriForm += "Rektangel";
            }
            else if (referens is Cirkel)
            {
                geometriForm += "Cirkel";
            }
            else if (referens is Fyrkant)
            {
                geometriForm += "Fyrkant";
            }
            else if (referens is Parallellogram)
            {
                geometriForm += "Parallellogram";
            }
            else
            {
                geometriForm += "Ellips";
            }
            Console.WriteLine(geometriForm + $": {referens.Area():.##}");
        }

        // Console.ReadKey() so the software doesn't instantly shut down
        Console.ReadKey();
    }
}
