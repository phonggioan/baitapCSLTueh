using Microsoft.VisualBasic;

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
        float temp;
        temp = x;
        x = y; y =temp;
        Console.WriteLine($"{x} {y}");
        Console.WriteLine("C3");
        Console.WriteLine("Tich =" + (x * y));
        Console.WriteLine("C4");
        Console.WriteLine("Convert Feet to meter: ");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($" {a} feet = {a*0.3048} meter");

        Console.WriteLine("C5");
        Console.WriteLine("Convert C to F");
        float C = Convert.ToSingle(Console.ReadLine());
        float F = (C - 32) * 5 / 9;
        Console.WriteLine($"{C} C = {F} F");

        Console.WriteLine("C6");
        Console.WriteLine($"size of date double type {sizeof(double)}");
        Console.WriteLine($"size of date double type {sizeof(int)}");
        Console.WriteLine("C7");
        Console.WriteLine("enter a character: ");
        int c = Console.Read();
        Console.WriteLine($" ASCII of {(char)c} is {c}");
        
        Console.ReadLine();
        Console.WriteLine("C8");
        Console.WriteLine("Enter radius:");
        float r = Convert.ToSingle(Console.ReadLine());
        const float Pi = 3.14f;
        float Sc =  r *r* Pi;
        Console.WriteLine($"Area of circle = {Sc}");
        Console.WriteLine("C9");
        Console.WriteLine("Enter edge:");
        float canh = Convert.ToSingle(Console.ReadLine());
        float Sv = canh * canh;
        Console.WriteLine($"Area of square = {canh}");
        Console.WriteLine("C10");
        Console.WriteLine(" Enter your day number: ");
        int day = Console.Read();
        int year = day / 365;
        int week = (day - 365*year) / 7;
        int day1 = day - year * 365 - week * 7;
        Console.WriteLine($"{day} = {year} year {week} week {day1} day");
        Console.ReadKey();



    }
}