using System;
using System.Collections.Generic;
using System.Text;

internal class Excerciselop
{
    static void bai1 ()
    {
        float C;
        Console.WriteLine("Nhap nhiet do theo thang celsius:");
        do
        {
            string str1 = Console.ReadLine();
            float x;
            bool a = float.TryParse(str1, out x);
            if (a == true)
            {
                C = float.Parse(str1);
                break;
            }
            else
            {
                Console.WriteLine(" nhap sai roi, nhap lai");
            }
        } while (true);
        float K = C + 273;
        float F = C * 18 / 10 + 32;
        int F1 = (int)F;
        Console.WriteLine($"Nhiet do theo thang kelvin la {K} va thang fahrenheit {F1}");
        Console.ReadLine();

    }
    static void bai2()
    {
        float R;
        Console.WriteLine("Nhap ban kinh hinh cau:");
        do
        {
            string str1 = Console.ReadLine();
            float x;
            bool a = float.TryParse(str1, out x);
            if (a == true)
            {
                R = float.Parse(str1);
                break;
            }
            else
            {
                Console.WriteLine(" nhap sai roi, nhap lai");
            }
        } while (true);
        double S = 4 * Math.PI * R * R;
        int chia = 4 / 3;
        double V = (Math.PI * R * R * R) * chia;
        Console.WriteLine($"dien tich hinh cau la {Math.Round(S, 2)}, the tich la {Math.Ceiling(V * 10.0) / 10.0}");
        Console.ReadLine();
    }
    static void bai3 ()
    {
        int x;
        int y;
        Console.WriteLine("Nhap x:");
        do
        {
            string str1 = Console.ReadLine();
            int test;
            bool a = int.TryParse(str1, out test);
            if (a == true)
            {
                x = int.Parse(str1);
                Console.WriteLine("nhap y:");
                do
                {
                    string str2 = Console.ReadLine();
                    int test2;
                    bool b = int.TryParse(str2, out test2);
                    if (b == true)
                    {
                        y = int.Parse(str2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" nhap sai roi, nhap lai");
                    }
                } while (true);
                break;
            }
            else
            {
                Console.WriteLine(" nhap sai roi, nhap lai");
            }
        } while (true);
        int tong = x + y;
        int hieu = x - y;
        int tich = x * y;
        int thuong = x % y;
        Console.WriteLine($"tong = {tong}, hieu = {hieu}, tich = {tich}, thuong = {thuong}");
        Console.ReadKey();
    }
    private static void Main1(string[] args)
    {
        //bai1();
        //bai2();
        //bai3();
    }
}

   
 

