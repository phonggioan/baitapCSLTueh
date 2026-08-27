using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;


    internal class Exerciseonlop
{
    /*Write a C# Sharp program that takes two numbers as input and
performs an operation (+,-,*,x,/) on them and displays the result of that
operation*/
    static void bai1()
    {
        Console.WriteLine("nhap so a =");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap so b =");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} x {b} = {a * b}");
        Console.WriteLine($"{a} : {b} = {a / b}");
        Console.WriteLine($"{a} : {b} dư {a % b}");
        Console.ReadLine();
    }
    //Write a C# Sharp program to display certain values of the function x = y2
//+ 2y + 1 (using integer numbers for y, ranging from - 5 to + 5).
static void bai2() 
    {
        for (int y = -5; y <= 5; y++)
        {
            int x;
            x = y * y + 2 * y + 1;
            Console.WriteLine($"Khi y = {y} thi x = {x}");

        }
        Console.ReadKey();

    }
//    Write a C# Sharp program that takes distance and time (hours, minutes,
//seconds) as input and displays speed in kilometers per hour(km / h) and
//miles per hour(miles/h).
    static void bai3 ()
    {
        Console.WriteLine("nhap khoang cach ban di duoc (km):");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap thoi gian ban di (h):");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine($"van toc (km/h): {a/b}");
        Console.WriteLine($"van toc (milse/h): {a*0.6214f/b}");
        Console.ReadLine() ;
    }
//    Write a C# Sharp program that takes the radius of a sphere as input and
//calculates and displays the surface and volume of the sphere.V =
//4 / 3 * π * r^3
     static void bai4 ()
    {
        Console.WriteLine("nhap ban kinh:");
        double x = double.Parse(Console.ReadLine());
        const double Pi = Math.PI;
        Console.WriteLine($"The tich hinh cau {(double)4/3*(Pi*x*x*x)}");
        Console.ReadLine();
    }
//    Write a C# Sharp program that takes a character as input and checks if it
//is a vowel, a digit, or any other symbol.
static void bai5 ()
    {
        Console.WriteLine("Nhap mot 1 chu cai:");
        char c = char.Parse(Console.ReadLine());
        if (c == 'u' || c == 'e' || c == 'o' || c == 'a' || c == 'i')
            Console.WriteLine($"{c} la nguyen am");
        else if (char.IsDigit(c))
            Console.WriteLine($"{c} la so");
        else
            Console.WriteLine($"{c} la symbol");
        Console.ReadKey() ;
    }
    static void bai6 ()
    {
        {
            //Giải pt bậc 2 bằng câu lệnh if else
            Console.WriteLine("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm, x tùy ý");
                    }
                    else // b==0, c!=0
                    {
                        Console.WriteLine("vô lý");
                    }
                }
                else // b!=0
                {
                    double x = (double)(-c) / b;
                    Console.WriteLine($"Phương trình có nghiệm duy nhất: x = {x}");
                }
            }

            else //a!=0
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    double x = (double)(-b) / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
                }
                else if (delta > 0)
                {
                    double x1 = (double)(-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (double)(-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
            }
        }



    }

    static void Main1(string[] args)
    {
        //bai1();
        //bai2();
        //bai3();
        //bai4();
        //bai5();
        //bai6();
    }

}

