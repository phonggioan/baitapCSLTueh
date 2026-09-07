using System;
using System.Collections.Generic;
using System.Text;
internal class homeworksession4

{
    //Write C# Sharp program to check whether a given number is even or odd
    static void bai1()
    {
        Console.WriteLine("nhap so ban muon kiem tra:");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
            Console.WriteLine($"{a} la so chan");
        else
            Console.WriteLine($"{a} la so le");
        Console.ReadLine();
    }
    //write a C# Sharp to find the largest of three numbers
    static void bai2()
    {
        Console.WriteLine("Nhap 3 so tu nhien:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.Write("So lon nhat la: ");
        if (a > b && a > c)
            Console.WriteLine(a);
        else if (b > c)
            Console.WriteLine(b);
        else Console.WriteLine(c);
        Console.ReadLine();
    }
    // write a C# sharp program to check wheter a triangle is Equilateral, Isosceles or Scalene
    static void bai3() 
    {
        Console.WriteLine("nhap cac canh cua tam giac:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.Write("day la tam giac ");
        if ( a == b && a == c )
            Console.WriteLine("deu");
        if ( a == b || b == c || a == c)
            Console.WriteLine("can");
        else
            Console.WriteLine("thuong");
        Console.ReadKey();

    }
    // Write a program to accept a coordinate point in an XY coordinate system
    // determine in which quadrant the coordinate point lies
    static void bai4() 
    {
        Console.WriteLine("Nhap toa do cua 1 diem (x,y)");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.Write("diem do thuoc goc phan tu thu ");
        if (x > 0 && y > 0)
            Console.WriteLine("I");
        else if (x < 0 && y > 0)
            Console.WriteLine("II");
        else if (x < 0) Console.WriteLine("III");
        else Console.WriteLine("IV");
        Console.ReadKey();
    }

    static void Main1(string[] args)
    {
        //bai1 ();
        //bai2 ();
        //bai3 ();
        //bai4 ();
    }
}

