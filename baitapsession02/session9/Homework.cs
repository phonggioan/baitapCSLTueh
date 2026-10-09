using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bhomework9

{
    internal class Homework
{
        static void PrintStructureOfFolder(string path)
        {
            string[] Thumucs = Directory.GetDirectories(path);
            string[] Files = Directory.GetFiles(path);
            foreach (string File in Files)
            {
                Console.WriteLine(File);
            }
            foreach (string tm in Thumucs)
            {
                Console.WriteLine(tm);
                PrintStructureOfFolder(tm);
            }
        }
        static void Main(string[] args)
        {
            //1 tạo file trống
            FileStream fs = new FileStream("filemoi.txt", FileMode.Create, FileAccess.ReadWrite);


            //2 xóa file
            //File.Delete(path);


            //3.Creat a file and add some text
            FileStream fs1 = new FileStream("data1.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter swriter = new StreamWriter(fs1);
            swriter.Write("Xin chao UEH");
            swriter.Flush();
            swriter.Close();


            //4.Create a file an read it
            fs1 = new FileStream("data1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sread = new StreamReader(fs1);
            string text = sread.ReadToEnd();
            Console.WriteLine(text);

            //5.Creat a file and write an array of strings to the file
            string path = "data2.txt";
            string str = "hi ueh, minh la sinh vien nam nhat";
            File.WriteAllText(path, str);

            //6.Append
            string[] noidung3 = { "haha", "kkk", "hehe" };
            File.AppendAllLines(path, noidung3);

            //7.copy
            string path1 = "data2_copy.txt";
            File.Copy(path, path1);

            //8 move
            string path2 = @"thumuc\data2.txt";
            File.Move(path, path2);

            
            string[] arrND = File.ReadAllLines(path);
            //9+10
            Console.WriteLine($"first line and last : {arrND[0]} {arrND[arrND.Length-1]}");
            //11
            Console.WriteLine("Nhap n line");
            int a = int.Parse(Console.ReadLine());
            for(int i = arrND.Length-1;i>= arrND.Length-a;i--)
                Console.WriteLine(arrND[i]);

            //12
            Console.WriteLine("nhap line muon doc");
            int n = int.Parse(Console.ReadLine());
            if(n < 0 && n > arrND.Length)
                Console.WriteLine("so dong khong ton tai");
            else
                Console.WriteLine(arrND[n-1]);
            //13
            int number = arrND.Length;
            Console.WriteLine(number);

            //14
            PrintStructureOfFolder(@"C:\Users");

            //15
            string text1 = File.ReadAllText(path);
            int[,] bang = new int[256, 2];
            for (int i = 0; i < 256; i++)
            {
                bang[i, 0] = i; 
                bang[i, 1] = 0; 
            }
            foreach (char c in text)
            {
                if ((int)c < 256)
                {
                    bang[(int)c, 1]++;
                }
            }
            Console.WriteLine("--- BẢNG THỐNG KÊ KÝ TỰ VÀ CHỮ SỐ ---");
            for (int i = 0; i < 256; i++)
            {
                if (bang[i, 1] > 0)
                {
                    char ch = (char)bang[i, 0];
                    if (char.IsLetterOrDigit(ch))
                    {
                        Console.WriteLine($"Ký tự '{ch}': {bang[i, 1]} lần");
                    }
                }
            }
        }
    }
}
