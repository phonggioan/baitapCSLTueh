internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("C1");
        Console.WriteLine("Enter x");
        float x = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter y:");
        float y = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Tong =" +(x+y));
        Console.WriteLine("C2");
        (x, y) = (y, x);
        Console.WriteLine($"{x} {y}");
        Console.WriteLine("C3");
        Console.WriteLine("Tich =" + (x * y));
        Console.WriteLine("C4");
       const FttoMeter =


    }
}