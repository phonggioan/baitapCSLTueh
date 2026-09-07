using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace session6
{
    internal class Homework
{
        static void max ( params int [] nums )
        {
            int max = 0;
            foreach ( int num in nums)
            {
                if (num > max)
                    max = num;
            }
            Console.WriteLine("maxium number: " +max);
        }
        static void factorial(int n)
        {
            int fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine("fraction of {0} = {1}", n, fac);
        }
        static void checkprime(int n)
        {
            if ( n == 1)
                Console.WriteLine("1 is prime number");
            if ( n == 2)
                Console.WriteLine("2 is prime number");
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($" {n} not a prime number");
                    break;
                }
                if (i == (int)Math.Sqrt(n) && n % i != 0)
                    Console.WriteLine($"{n} is prime number");
            }
        }
        static void listprime1 (int n)
        {
            if (n > 2)
            {
                Console.Write("1 2 ");
                for (int i = 2; i < n; i ++)
                    for (int j = 2; j <=  (int)Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            break;
                        }
                        if (j == (int)Math.Sqrt(i) && i % j != 0)
                            Console.Write($"{i} ");
                    }
                Console.WriteLine();
            }
            else if (n == 1)
                Console.WriteLine(1);
            else if ( n == 2)
                Console.WriteLine("1 2");
        }
        static void listprime2 (int n)
        {
            int dem = 0;
            int i = 3;
            if (n == 1)
                Console.WriteLine(1);
            else
            {
                Console.Write("1 2 ");
                while (dem < n - 2)
                {
                    for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                    {
                        if ((i % j == 0))
                            break;
                        if (j == (int)Math.Sqrt(i) && i % j != 0)
                        {
                            Console.Write($"{i} ");
                            dem++;
                        }
                    }
                    i++;
                }
            }
        }
        static bool checkperfect (int n)
        {
            int tong = 0;
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            bool x = (tong == n);
            return x;
        }
        static void listperfectunder1000()
        {
            for (int i = 1; i <= 1000; i++)
            {
                int tong = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        tong += j;
                    if (tong == i)
                    {
                        Console.Write($"{i} ");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
        static void checkpangram (string str)
        {
            char[] arr = str.ToCharArray();
            int dem = 0;
            for (int i = 97; i <= 122; i++)
            {
                foreach (char c in arr)
                {
                    if (char.IsLetter(c) && (int)c == i)
                    {
                        dem++;
                        break;
                    }
                }
            }
            if (dem == 122-96)
                Console.WriteLine(" this string is pangram");
            else
                Console.WriteLine("this is not pangram");
        }
    static void Main1(string[] args)
    {
            Console.WriteLine("Enter a,b,c to compare");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            max(a, b, c);
            Console.WriteLine();


            Console.WriteLine("Enter n to cal factorial");
            int n = int.Parse(Console.ReadLine());
            factorial(n);
            Console.WriteLine();


            Console.WriteLine("Enter n to check prime");
            int num = int.Parse(Console.ReadLine());
            checkprime(num);
            Console.WriteLine();


            Console.WriteLine("Enter number that you want to list prime number to");
            int prime = int.Parse(Console.ReadLine());
            listprime1(prime);
            Console.WriteLine();

            Console.WriteLine("How many prime number you want");
            int many = int.Parse(Console.ReadLine());
            listprime2(many);
            Console.WriteLine();

            Console.WriteLine("Enter number to check \"Perfect\"");
            int perfect = int.Parse(Console.ReadLine());
            bool check = checkperfect(perfect);
            Console.WriteLine(check);
            listperfectunder1000();
            Console.WriteLine();

            Console.WriteLine("Enter string to check pangram");
            string str = Console.ReadLine();
            checkpangram(str);
            Console.ReadLine();
        }
}
}
