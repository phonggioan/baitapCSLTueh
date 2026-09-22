using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace session6
{
    internal class Homework1
    {
        static int TinhTong (int a, int b)
        {
            return a+ b;
        }
        static bool CheckEven (int n)
        {
            bool x;
            if (n % 2 == 0)
                x = true;
            else
                x = false;
            return x;
        }
        static long  TinhGiaiThua (int n)
        {
            int giaithua = 1;
            for (int i = 1; i <= n; i++)
                giaithua *= i;
            return giaithua;
        }
        static int Maxium(int a, int b, int c)
        {
            int n = Math.Max(Math.Max(a, b), c);
            return n;
        }
        static string DaoNguocChuoi (string str)
        {
            string str1 = "";
            char[] arr = str.ToCharArray();
            foreach (char c in arr)
                str1= c + str1;
            return str1;
        }
        static bool CheckPrime (int n)
        {
            bool x = true;
            if (n == 1 || n == 2)
                x = true;
            else
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    x = false;
            }
            return x;
        }
        static void ListFibonanci (int n)
        {
            int F1 = 0;
            int F2 = 1;
            int fibo = 0;
            if (n == 1)
                Console.WriteLine(F1);
            else if (n == 2)
                Console.WriteLine("0 1");
            else
            {
                Console.Write("0 1 ");
                for (int i = 3; i <= n; i++)
                {
                    fibo = F1 + F2;
                    F1 = F2;
                    F2 = fibo;
                    Console.Write(fibo + " ");
                }
            }
        }
        static int DemNguyenAm (string str)
        {
            int dem = 0;
            str = str.ToLower();
            char[] arr = { 'a', 'e', 'i', 'o', 'u' };
            char[] arr2 = str.ToCharArray();
            foreach (char c in arr2)
            {
                for(int i = 0;i < 5 ;i++)
                {
                    if (c == arr[i])
                        dem++;
                }    
            }
            return dem;
        }
        static double TinhLuyThua (double x, int y)
        {
            double ketqua = 1;
            for (int i = 1; i <= y; i++)
            {
                ketqua *= x;
            }  
            return ketqua;
        }
        static double TinhTrungBinh (params int[] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
                tong += arr[i];
            return tong*1.0 / arr.Length;
        }
        static bool CheckUnasymmetrical (string str)
        {
            char[] arr = str.ToCharArray();
            bool x = false;
            int dem = 0;
            for (int i = 0; i < arr.Length/2; i++) 
            {
                if (arr[i] == arr[arr.Length - 1 - i])
                    dem++;
            }
            if (dem == arr.Length / 2)
                x = true;
            return x;
        }
        static double TranMeasurement (double C)
        {
            double F;
            F = 1.8 * C + 32;
            return F;
        }
        static int TimMin (params int[] arr)
        {
            int min = arr[0];
            for (int i = 0;i < arr.Length;i++)
            {
                if ( arr[i] < min  ) min = arr[i];
            }    
            return min;
        }
        static int TongCacChuSo(int a)
        {
            int tong = 0;
            while (a > 0)
            {
                tong += a % 10;
                a /= 10;
            }
            return tong;
        }
        static void SapXepMang (params int[] arr)
        {
            arr.Sort();
            for(int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        static string XoaKytuTrungLap (string str)
        {
            string str1 = "";
            char[] arr = str.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
               for (int j = i +1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        arr[j] = ' ';
                }
            } 
            foreach(char c in arr)
            {
                if (char.IsLetter(c))
                    str1 += c;
            }
            return str1;
        }
        static int UCLN (int a, int b)
        {
            int r = 1;
            int temp;
            if (a < b)
            {
                temp =  a;
                a = b;
                b = temp;
            }
            while(true)
            {
                r = a % b;
                if (r == 0)
                    break;
                else
                {
                    a = b; b = r;
                }

            }
            return b;
        }
        static string DecimalToBinary (int n)
        {
            string str = "";
            while (n > 0)
            {
                str = (n%2).ToString() +str;
                n /= 2;
            }
            return str;
        }
        static bool CheckNhuan (int n)
        {
            bool x;
            if (n % 4 == 0 && n % 100 != 0)
                x = true;
            else if (n % 400 == 0)
                x = true;
            else
                x = false;
            return x;
        }
        static int DemSoTu (string str)
        {
            string[] arr = str.Split (' ');
            int num = arr.Length;
            return num; 
        }

                
            

        static void Main1(string[] args)
        {
            //int a = 1, b = 2;
            //Console.WriteLine(TinhTong(a, b));
            //Console.WriteLine();

            //int n = 2, n1 = 3;
            //Console.WriteLine(CheckEven(n));
            //Console.WriteLine(CheckEven(n1));
            //Console.WriteLine();

            //int a1 = 1, a2 = 2, a3 = 3;
            //Console.WriteLine(Maxium(a1, a2, a3));
            //Console.WriteLine();

            //int n3 = 4;
            //Console.WriteLine(TinhGiaiThua(n3));
            //Console.WriteLine();

            //string str = "123456789";
            //Console.WriteLine(DaoNguocChuoi(str));
            //Console.WriteLine();

            //int n2 = 13;
            //Console.WriteLine(CheckPrime(n));
            //Console.WriteLine();

            //int n4 = 6;
            //ListFibonanci(n4);
            //Console.WriteLine();
            //Console.WriteLine();

            //string str1 = "Hello Word";
            //Console.WriteLine(DemNguyenAm(str1));
            //Console.WriteLine();

            double x = 2; int y = 3;
            Console.WriteLine(TinhLuyThua(x, y));
            Console.WriteLine();

            int[] arr = { 4, 5, 6, 7 };
            Console.WriteLine(TinhTrungBinh(arr));
            Console.WriteLine();

            string str2 = "radar", str3 = "hello";
            Console.WriteLine(CheckUnasymmetrical(str2) + " " + CheckUnasymmetrical(str3));
            Console.WriteLine();

            double C = 25;
            Console.WriteLine(TranMeasurement(25));
            Console.WriteLine();

            int[] arr1 = { 10, 5, 8, 2, 9 };
            Console.WriteLine(TimMin(arr1));
            Console.WriteLine();

            int a4 = 1234;
            Console.WriteLine(TongCacChuSo(a4));
            Console.WriteLine();

            int[] arr2 = { 3, 1, 4, 2 };
            SapXepMang(arr2);
            Console.WriteLine();

            string str4 = "programming";
            Console.WriteLine(XoaKytuTrungLap(str4));
            Console.WriteLine();

            int x1 = 12, y1 = 18;
            Console.WriteLine(UCLN(x1, y1));
            Console.WriteLine();

            int n5 = 10;
            Console.WriteLine(DecimalToBinary(n5));
            Console.WriteLine();

            int x2 = 2024, x3 = 2023;
            Console.WriteLine(CheckNhuan(x2) + " " + CheckNhuan(x3));
            Console.WriteLine();

            string str5 = "Hoc Lap Trinh C# rat thu vi";
            Console.WriteLine(DemSoTu(str5));

            Console.ReadLine();
        }
    }


}
    