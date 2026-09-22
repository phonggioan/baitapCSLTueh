using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;

namespace session7
{
    internal class Homework1
{
        static int[] NhapMang(int n)
        {
            Console.WriteLine("Enter number");
            int[] b = new int[n];
            for (int i = 0; i < n; i++) b[i] = int.Parse(Console.ReadLine());
            return b;
        }
        static float CalAvrg(int[] a)
        { int tong = 0;
            for (int i = 0; i < a.Length; i++) tong += a[i];
            return (float)tong / a.Length;
        }
        static bool FindValue(int[] a, int value)
        {
            bool x = false;
            for(int i = 0;i < a.Length;i++)
            {
                if (a[i] == value)
                {
                    x = true;
                    break;
                }
                else
                    x = false;
            }
            return x;
        }
        static int[] FindIndex (int[] a, int value)
        {
            string str = "";
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    str += i.ToString();
                    dem++;
                }
            }
            int[] b = new int[dem];
            if (dem == 0)
                return b;
            char[] c = str.ToCharArray();
            for (int i = 0; i < dem; i++)
            {
                string str1 = c[i].ToString();
                b[i] = Convert.ToInt32(str1);
            }
            return b;
            ;
        }
        static int[] Remove(int[] Organ, int[]locate, int value)
        {
            int[] a = new int[Organ.Length - locate.Length];
            int dem = 0;
            for(int i = 0;i < Organ.Length;i++)
            {
                if(Organ[i] != value)
                {
                    a[dem] = Organ[i];
                    dem++;
                }
            }
            return a;
        }
        static int[] MinMax (int[] organ)
        {
            int min = organ[0];
            for(int i = 0; i < organ.Length ; i++)
            {
                if (organ[i] < min)
                {
                    min = organ[i];
                }
            }
            int max = min;
            for (int i = 0; i < organ.Length; i++)
            {
                if (organ[i] > max)
                {
                    max = organ[i];
                }
            }
            int[] a = { min, max };
            return a;
        }
        static int[] Reverse (int[] a)
        {
            int[] b = new int[a.Length];
            for (int i = a.Length-1; i >= 0 ; i--)
            {
                b[i] = a[a.Length - 1 - i];
            }
            return b;
        }
        static int[] FindDuplicate(int[] a1)
        {
            int[] a = new int[a1.Length];
            for(int i = 0; i < a1.Length ; i++)
                a[i] = a1[i];
            int max = a[0];
            string str = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            for (int i = 0; i < a.Length;i++)
            {
                if (a[i] == max + 1)
                    continue;
                int dem1 = 0;
                for (int j = i +1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        a[j] = max + 1;
                        dem1++;
                    }
                }
                if(dem1 >0)
                {
                    str += a[i] + " ";
                }
            }
           str = str.Trim();
            string[] arr = str.Split(' ');
            int[] b = new int[arr.Length];
            int dem = 0;
            foreach(string i in arr)
            {
                b[dem] = int.Parse(i);
                dem++;
            }
            return b;

        }
        static int[] RemoveDuplicate(int[] a, int[] duplicate)
        {
            int max = a[0];
            for (int i =0; i < a.Length; i++)
            {
                if(a[i] > max)
                    max = a[i];
            }
            for(int i = 0; i < duplicate.Length;i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (duplicate[i] == a[j])
                    {
                        duplicate[i] = j;
                        break;
                    }
                }
            }
            int dem = 0;
            for (int i = 0;i < duplicate.Length;i++)
            {
                for(int j = duplicate[i] +1; j < a.Length; j++)
                {
                    if (a[duplicate[i]] == a[j])
                    {
                        a[j] = max + 1;
                        dem++;
                    }
                }    
            }
            int[] b = new int[a.Length - dem];
            dem = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != max + 1)
                {
                    b[dem] = a[i];
                    dem++;
                }
            }
            return b;
        }
        static int[] Sorting(int[] a)
        {
            int[] b = new int[a.Length];
            for(int i = 0; i < a.Length; i++)
                b[i] = a[i];
            for(int i = 0; i < b.Length -1; i++)
                for(int j = 0; j < b.Length -i - 1; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        int temp = b[j];
                        b[j] = b[j + 1];
                        b[j+ 1] = temp;
                    }
                }
            
            return b;
        }
        static string NhapChuoi()
        {
            string str = Console.ReadLine();
            return str;
        }
        static void CheckAppear(string str,string strkiem)
        {
            string[] arrstr = str.Split(' ');
            for (int i = 0; i < arrstr.Length; i++)
            {
                if (arrstr[i].Equals(strkiem))
                {
                    Console.WriteLine("yes");
                    break;
                }
                else if (i == arrstr.Length - 1)
                    Console.WriteLine("No");
            }
        }
        static void Main1 (string[] args)
        {
            Console.WriteLine("Enter length of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = NhapMang(n);
            float result = CalAvrg(arr);
            Console.WriteLine("average = " +result);
            Console.WriteLine();


            Console.WriteLine("Enter value you want to find");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua" + FindValue(arr, value));
            Console.WriteLine();


            int[] locate = FindIndex(arr, value);
            if (locate.Length != 0)
            {
                Console.WriteLine("Vi tri");
                foreach (int i in locate)
                {
                    Console.Write(i + " ");
                }
            }
            else
                Console.WriteLine("Not have");
            Console.WriteLine();


            int[] removed = Remove(arr, FindIndex(arr, value), value);
            Console.WriteLine(" array that it is removed");
            foreach (int i in removed)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            int[] minmax = MinMax(arr);
            Console.WriteLine("min " + minmax[0] + " max " + minmax[1]);
            Console.WriteLine();


            int[] reverse = Reverse(arr);
            Console.WriteLine("array that it is reversed");
            foreach (int i in reverse)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();


            int[] duplicate = FindDuplicate(arr);
            Console.WriteLine("number duplicated");
            foreach (int i in duplicate)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();


            int[] removeduplicate = RemoveDuplicate(arr, duplicate);
            foreach (int i in removeduplicate)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Enter length of array to sort");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = NhapMang(n1);

            int[] sorting = Sorting(arr1);
            foreach (int i in sorting) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enter sentence");
            string str = NhapChuoi();
            Console.WriteLine("Enter word");
            string strkiem = NhapChuoi();
            CheckAppear(str, strkiem);
         

            Console.ReadLine();
        }
}
}
