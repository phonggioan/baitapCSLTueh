using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;


internal class FileName
{
    static void Bang9chap ()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 2; j < 10; j++)
            {
                Console.Write((j + " x " + i + " = " + (i * j)).PadRight(15));
            }
            Console.WriteLine();
        }
    }
    static void bai1 () 
        {
        Console.WriteLine("Nhap 3 canh a b c:");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        if (a == b && b == c)
            Console.WriteLine("tam giac deu");
        else if (a == c || b == c || a == b)
            Console.WriteLine("tam giac can");
        else
            Console.WriteLine("tam giac binh thuong");

    } 
    static void bai2()
    {
        Console.WriteLine("Moi ban nhap 10 so:");
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int tong = arr.Sum();
        double ava = tong / 10.0;
        Console.WriteLine("Tong 10 chu so do la " + tong);
        Console.WriteLine($"Trung binh 10 chu so la {ava:F1}");
    }
    static void bai3 ()
    {
        Console.WriteLine("Bang muon bang cuu chuong so may");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
    static void bai4() 
    {
        Console.WriteLine("Nhap so gioi han muon bieu dien: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        List<int> list = new List<int>();
        for (int i = 1; i <= num; i++) // in kieu tam giac vuong 
        {
            list.Add(i);
            foreach (int j in list)
            {
                Console.Write(j /*+"\t"*/ );
            }
            Console.WriteLine();
        }
        Console.WriteLine("nhap so gioi han muon lap:");
        int num2 = int.Parse(Console.ReadLine());
        int sospace = num2.ToString().Length;
        int lop = 0;
        int tong = 0;
        for (int i = 1; i < num2; i++)
        {
            tong += i;
            lop++;
            if ((num2 - tong) == 0)
                break;
            if ((num2 - tong) < 0)
                break;
        }
        int space = 1;
        int dem = 1;
        for (int i = lop - 1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }
            //Console.WriteLine(space);
            for (int j = 1; j <= space; j++)
            {
                Console.Write(dem);
                for (int k = 0; k <= (sospace - dem.ToString().Length); k++)
                    Console.Write(" ");
                if (dem == num2)
                    break;
                dem++;
            }
            Console.WriteLine();
            space++;
        }
    }
    static void Main1(string[] args)
    {
        bai4();


    }
}
        


