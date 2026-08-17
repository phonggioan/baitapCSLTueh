internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your YOB: ");
        int birth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nEnter number: ");
        float num = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"{name}, {birth}, {num}");
        Console.ReadKey();
    }
}