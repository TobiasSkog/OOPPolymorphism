// Tobias Skog .NET23
using OOPPolymorphism.Geometri;
internal class Program
{

    static void Main(string[] args)
    {

        // Creating 2 Rektangel objects where
        // Rektangel a is using the default value defined in the constructor of the class
        // Rektangel b gets the input 5, 8 > the constructor assigns the _Width to 5 and _Length to 8
        Rektangel r_a = new();
        Rektangel r_b = new(5, 8);

        // Creating 2 Fyrkant objects where
        // Fyrkant a is using the default value defined in the constructor of the class
        // Fyrkant b gets the input 8 > the constructor assigns the _SideLength to 8
        Fyrkant f_a = new();
        Fyrkant f_b = new(8);

        // Creating 2 Cirkel objects where
        // Cirkel a is using the default value defined in the constructor of the class
        // Cirkel b gets the input 5 > the constructor assigns the _Radius to 5
        Cirkel c_a = new();
        Cirkel c_b = new(5);

        // Creating 2 Parallellogram Objects where
        // Parallellogram a is using the default value defined in the constructor of the class
        // Parallellogram b gets the input 5, 6 > the constructor assigns the _Height to 5 and _BaseParallelLength to 6
        Parallellogram p_a = new();
        Parallellogram p_b = new(5, 6);

        // Creating 2 Ellips Objects where
        // Ellips a is using the default value defined in the constructor of the class
        // Ellips b gets the input 12, 8 > the constructor assigns the _MajorAxis to 12 and _MinorAxis to 8
        Ellips e_a = new();
        Ellips e_b = new(12, 8);

        // Writing to the console with the value returns of the method in the classes of
        // (Rektangel A & B), (Fyrkant A & B), (Cirkel A & B), (Parallellogram A & B), (Ellips A & B)
        // Since we return variables of the type ´double´ I decided to limit the amount of decimals to two by using `:#.##`
        // to limit the output to the console but not limiting the accuracy of the calculated results
        // By using `#.##` instead of `0.00` I only write out values to console IF there is a numerical value at that location of the string
        Console.WriteLine($"Rektangel A har en bredd på: {r_a.Width:#.##} och längd på: {r_a.Length:#.##}.");
        Console.WriteLine($"Rektangel A har arean: {r_a.Area():#.##}."); ;
        Console.WriteLine();

        Console.WriteLine($"Rektangel B har en bredd på: {r_b.Width:#.##} och längd på: {r_b.Length:#.##}.");
        Console.WriteLine($"Rektangel B har arean: {r_b.Area():#.##}.");
        Console.WriteLine();

        Console.WriteLine($"Fyrkant A har en sidolängd på: {f_a.SideLength:#.##}.");
        Console.WriteLine($"Fyrkant A har arean: {f_a.Area():#.##}."); ;
        Console.WriteLine();
        Console.WriteLine($"Fyrkant B har en sidolängd på: {f_b.SideLength:#.##}.");
        Console.WriteLine($"Fyrkant B har arean: {f_b.Area():#.##}."); ;
        Console.WriteLine();

        Console.WriteLine($"Cirkel A har en radie på: {c_a.Radius:#.##}.");
        Console.WriteLine($"Cirkel A har arean: {c_a.Area():#.##}.");
        Console.WriteLine();
        Console.WriteLine($"Cirkel B har en radie på: {c_b.Radius:#.##}.");
        Console.WriteLine($"Cirkel B har arean: {c_b.Area():#.##}.");
        Console.WriteLine();

        Console.WriteLine($"Parallellogram A har en höjd på: {p_a.Height:#.##} och bas parallell-längd på: {p_a.BaseParallelLength:#.##}.");
        Console.WriteLine($"Parallellogram A har arean: {p_a.Area():#.##}"); ;
        Console.WriteLine();
        Console.WriteLine($"Parallellogram B har en höjd på: {p_b.Height:#.##} och bas parallell-längd på: {p_b.BaseParallelLength:#.##}.");
        Console.WriteLine($"Parallellogram B har arean: {p_b.Area():#.##}."); ;
        Console.WriteLine();

        Console.WriteLine($"Ellips A har en major axis på: {e_a.MajorAxis:#.##} och minor axis på: {e_a.MinorAxis:#.##}.");
        Console.WriteLine($"Ellips A har arean: {e_a.Area():#.##}.");
        Console.WriteLine();
        Console.WriteLine($"Ellips B har en major axis på: {e_b.MajorAxis:#.##} och minor axis på: {e_b.MinorAxis:#.##}.");
        Console.WriteLine($"Ellips B har arean: {e_b.Area():#.##}.");

        // Console.ReadKey() so the software doesnt instantly shut down
        Console.ReadKey();
    }
}
