using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
enum currency
{
    USD = 25400,//1
    EUR = 27200,//2
    JPY = 165,//3
    GBP = 32100,//4
};
enum StockStatus
{
    OutOfStock,
    LowStock,
    InStock,
    Discontinued,

}
enum VehicleType
{
    Motorbike = 5000,
    Car = 20000,
    Truck = 50000,

}
enum CustomerType
{
    Child = 1,
    Student = 2,
    Adult = 3,
    Senior = 4,
}
internal class homework
{
    static void bai1()
    {
        Console.WriteLine("Nhap chi so dien cu");
        decimal dienmoi;
        decimal diencu;
        do
        {
            string str1 = Console.ReadLine();
            decimal test;
            bool kiemtra = decimal.TryParse(str1, out test);
            if (kiemtra == true)
            {
                diencu = decimal.Parse(str1);
                Console.WriteLine("Nhap chi so moi");
                do
                {
                    string str2 = Console.ReadLine();
                    decimal test1;
                    bool kiemtra2 = decimal.TryParse(str2, out test1);
                    if (kiemtra2 == true && (dienmoi = decimal.Parse(str2)) > diencu)
                    {
                        dienmoi = decimal.Parse(str2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("nhap sai roi, nhap lai");
                    }
                } while (true);
                break;
            }
            else
            {
                Console.WriteLine("nhap sai roi, nhap lai");
            }

        } while (true);
        decimal tieuthu = dienmoi - diencu;
        decimal tienkothue;
        if (Math.Max(tieuthu, 50) == 50)
            tienkothue = tieuthu * 1806;
        else if (Math.Max(tieuthu, 100) == 100)
            tienkothue = (tieuthu - 50) * 1866 + 50 * 1806;
        else if (Math.Max(tieuthu, 200) == 200)
            tienkothue = (tieuthu - 100) * 2167 + 50 * (1806 + 1866);
        else if (Math.Max(tieuthu, 300) == 300)
            tienkothue = (tieuthu - 200) * 2729 + 50 * (2 * 2167 + 1866 + 1806);
        else
            tienkothue = (tieuthu - 300) * 3050 + 50 * (2 * (2729 + 2167) + 1866 + 1806);
        decimal thue = tienkothue * 8 / 100;
        Console.WriteLine(
            $@"So dien tieu thu {tieuthu}kWh
Tien dien chua thue: {tienkothue} VND
Thue VAT: {thue} VND
Tong thanh toan: {tienkothue + thue} VND");
        Console.ReadLine();
    }
    static void bai2()
    {
        Console.WriteLine("Nhap chieu cao (nhap so): ");
        double height;
        double weight;
        do
        {
            string str1 = Console.ReadLine();
            double test;
            bool kiemtra = double.TryParse(str1, out test);
            if (kiemtra == true)
            {
                height = double.Parse(str1);
                Console.WriteLine("Nhap can nang (chi so):");
                do
                {
                    string str2 = Console.ReadLine();
                    double test2;
                    bool kiemtra2 = double.TryParse(str2, out test2);
                    if (kiemtra2 == true)
                    {
                        weight = double.Parse(str2);
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
        double BMI = weight / Math.Pow(height, 2);
        Console.WriteLine($"Chi so BMI: {BMI:F2}");
        Console.Write("Phan loai suc khoe: ");
        if (BMI < 18.5)
            Console.WriteLine("Gay(thieu can)");
        else if (BMI >= 18.5 && BMI < 23)
            Console.WriteLine("Binh thuong (Ly tuong)");
        else if (BMI >= 23 && BMI < 25)
            Console.WriteLine("Thua can (tien beo phi)");
        else if (BMI >= 25)
            Console.WriteLine("beo phi");
        Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu {18.5 * Math.Pow(height, 2):F2} kg den {22.9 * Math.Pow(height, 2):F2}");
        Console.ReadKey();
    }
    static void bai3()
    {
        decimal tien;
        Console.WriteLine("Nhap so tien can quy doi (chi nhap so)");
        do
        {
            string str1 = Console.ReadLine();
            decimal test;
            bool kiemtra = decimal.TryParse(str1, out test);
            if (kiemtra == true)
            {
                tien = decimal.Parse(str1);
                break;
            }
            else
            {
                Console.WriteLine(" nhap sai roi, nhap lai");
            }
        } while (true);

        Console.WriteLine(@"chon dong tien quy doi:
1-USD
2-EUR
3-JPY
4-GBP");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine($"Phi dich vu (0.5%): {tien * 0.005m}");
        int rate;
        string a;
        switch (x)
        {
            case 1:
                rate = (int)currency.USD;
                a = "USD";
                break;
            case 2:
                rate = (int)currency.EUR;
                a = "EUR";
                break;
            case 3:
                rate = (int)currency.JPY;
                a = "JPY";
                break;
            default:
                rate = (int)currency.GBP;
                a = "GBP";
                break;
        }
        Console.WriteLine(@$"So tien VND tinh doi: {tien * 0.995m}
So tien {a} nhan duoc: {((tien * 0.995m) / rate):F2} {a}");
    }
    static void bai4()
    {
        Console.WriteLine("Nhap ngay sinh (dd/MM/yyyy):");
        string a = Console.ReadLine();
        DateTime birthday = DateTime.Parse(a);
        DateTime now = DateTime.Now;
        TimeSpan lifetime = now - birthday; // hàm tính khoảng thời gian
        double day = lifetime.TotalDays;
        int tuoi = (int)(day / 365.25d);
        Console.WriteLine($@"Tuoi hien tai: {tuoi}
Ban da song tong cong: {day:F0} ngay
Sinh nhat tiep theo con: {((tuoi + 1) * 365.35 - day):F0} ");
    }
    static void bai5()
    {
        Console.WriteLine("Dung dau phay de the hien so sau dau cham phay");
        Console.WriteLine("nhap diem C# (4 TC):");
        float C = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap diem toan (3 TC):");
        float toan = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap diem tieng anh (2 TC):");
        float anh = float.Parse(Console.ReadLine());
        float avg = (C * 4 + toan * 3 + anh * 2) / (2 + 3 + 4);
        char diem;
        float thang;
        string xeploai;
        if (avg >= 8.5)
        {
            diem = 'A';
            thang = 4.0f;
            xeploai = "Gioi";
        }
        else if (avg >= 7.0 && avg <= 8.4)
        {
            diem = 'B';
            thang = 3.0f;
            xeploai = "Kha";
        }
        else if (avg >= 5.5 && avg <= 6.9)
        {
            diem = 'C';
            thang = 2.0f;
            xeploai = "Trung binh";
        }
        else if (avg >= 4.0 && avg <= 5.4)
        {
            diem = 'D';
            thang = 1.0f;
            xeploai = "Yeu";
        }
        else
        {
            diem = 'F';
            thang = 0.0f;
            xeploai = "Kem(truot)";
        }
        Console.WriteLine($@"Diem TB thang 10: {avg:F2}
Diem chu quy doi: {diem}
Diem GPA thang 4: {thang}
Xep loai hoc luc: {xeploai}");

    }
    static void bai6()
    {
        Console.WriteLine("Nhap ho ten tho:");
        string hoten = Console.ReadLine();
        hoten = hoten.Trim();
        string[] lst = hoten.Split(" ");
        string hotentach = "";
        foreach (string x in lst)
        {
            //Console.WriteLine(x);
            foreach (char c in x)
            {
                if ((char.IsLetter(c) == true))
                {
                    hotentach += x + " ";
                    break;
                }
            }
        }
        hotentach = hotentach.Trim();
        hotentach = hotentach.ToLower();
        string[] lst2 = hotentach.Split(" ");
        string hotenchuan = "";
        foreach (string x in lst2)
        {
            string a = x.Substring(0, 1).ToUpper();
            string b = x.Substring(1);
            hotenchuan += a + b + " ";
        }
        hotenchuan = hotenchuan.Trim();
        string[] lst3 = hotenchuan.Split(" ");
        Console.WriteLine($"Ho ten chuan hoa: {hotenchuan}");
        Console.WriteLine($"Ho: {lst[0]} | Ten dem: {lst3[1]} | Ten: {lst3[2]}");
        Console.WriteLine($"Usernam tao tu dong: {lst2[2]}.{lst2[0]}{lst2[1]}");
        Console.WriteLine($"Email cap phat: {lst2[2]}.{lst2[0]}{lst2[1]}@company.edu.vn");
        Console.ReadKey();
    }
    static void bai7()
    {
        Console.WriteLine("Nhap khoang cach di chuyen (km):");
        double s = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap muc tieu thu nhien lieu (L/100km):");
        double per = double.Parse(Console.ReadLine());
        Console.WriteLine("Gia xang hien tai");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so nguoi di");
        int person = int.Parse(Console.ReadLine());
        double totalfuel = s * per / 100;
        decimal expense = (decimal)totalfuel * price;
        decimal expenseper = expense / person;
        Console.WriteLine($@"Tong nhien lieu tieu thu: {totalfuel:F2} Lit
Tong chi phi xang dau: {expense:F0} VND
Chi phi moi nguoi: {expenseper:F0} VND");
        Console.ReadLine();
    }
    static void bai8()
    {
        Random rnd = new Random();
        int OTP = rnd.Next(100000, 999999);
        DateTime CreationTime = DateTime.Now;
        Console.WriteLine($"Ma OTP cua ban tai {CreationTime}: \"{OTP}\" ");
        Console.WriteLine("Nhap ma OTP de xac thuc giao dich:");
        do
        {
            string str1 = Console.ReadLine();
            bool kiemtra;
            int authentic;
            int so = 0;
            kiemtra = int.TryParse(str1, out authentic);
            foreach (char c in str1)
            {
                if (char.IsDigit(c))
                {
                    so++;
                }
            }

            if (kiemtra == true)
            {
                authentic = Convert.ToInt32(str1);
                if (so == 6 && OTP == authentic)
                {
                    TimeSpan time = DateTime.Now - CreationTime;
                    if ((time.TotalMinutes) < 5)
                    {
                        Console.WriteLine("THANH CONG - giao dich duoc phe duyet");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ma OTP het han");
                        break;
                    }
                }
            }
            Console.WriteLine("Nhap sai roi, nhap lai");

        } while (true);

        Console.ReadKey();
    }
    static void bai9()
    {
        Console.WriteLine("Nhap luong Gross (VND):");
        decimal wage = decimal.Parse(Console.ReadLine());
        Console.WriteLine("So nguoi phu thuoc:");
        int person = int.Parse(Console.ReadLine());
        Console.WriteLine(@"Bao hiem xa hoi (BHXH): 8%
Bao hiem y te (BHYT): 1.5%
Bao hiem that nghiep (BHTP): 1%");
        decimal minus = wage * 0.105m;
        decimal tax = wage - minus - 11000000 - person * 4400000;
        decimal TNCN;
        if (tax < 0)
        {
            TNCN = 0;
        }
        else if (tax <= 5000000)
        {
            TNCN = tax * 0.05m;
        }
        else if (tax > 5000000 && tax <= 10000000)
        {
            TNCN = 5000000 * 0.05m + (tax - 5000000) * 0.1m;
        }
        else if ((tax > 10000000 && tax <= 18000000))
        {
            TNCN = 5000000 * (0.05m + 0.1m) + (tax - 10000000) * 0.15m;
        }
        else
        {
            TNCN = 5000000 * (0.05m + 0.1m) + 8000000 * 0.15m;
        }
        Console.WriteLine($@"Giam tru bao hiem: {minus:F0} VND
Thu nhap chiu thue: {tax:F0} VND
Thue TNCN phai nop: {TNCN:F0} VND VND
LUONG NET THUC NHAN: {(wage - minus - TNCN):F0} VND");
        Console.ReadKey();
    }
    static void bai10()
    {
        Console.WriteLine("Nhap ten san pham:");
        string sanpham = Console.ReadLine();
        Console.WriteLine("Nhap ma san pham:");
        string ma = Console.ReadLine();
        Console.WriteLine("So luong hang ton kho");
        string inputQuantity = Console.ReadLine();
        int? quantity = string.IsNullOrWhiteSpace(inputQuantity) ? null : int.Parse(inputQuantity);
        int minThreshold = 10;
        Console.WriteLine("Nhap Restock date (dd/MM/yyyy):");
        string inputDate = Console.ReadLine();
        DateTime? Restock = string.IsNullOrWhiteSpace(inputDate) ? null : DateTime.Parse(inputDate);
        string state;
        if (quantity == null || quantity == 0)
            state = StockStatus.OutOfStock.ToString();
        else if (quantity < minThreshold)
        {
            state = StockStatus.LowStock.ToString();
        }
        else
        {
            state = StockStatus.InStock.ToString();
        }
        int x = 0;
        int num = quantity ?? x;
        string a = "chua co lich nhap";
        string date = Restock?.ToString() ?? "chua co lich nhap";
        Console.WriteLine($@"So luong hien thi: {num}
Trang thai kho: {state}
Du kien nhap hang: {date}");
    }
    static void bai11()
    {
        Console.WriteLine("Nhap so tien gui ban dau:");
        decimal P = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Nhap lai suat nam (%/nam):");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Ky han gui (thang):");
        int n = int.Parse(Console.ReadLine());
        decimal laidon = P * ((decimal)r / 100) * (decimal)(n / 12.0);
        decimal A = (decimal)((double)P * Math.Pow(1 + (r / 100.0) / 12.0, n));
        Console.WriteLine($@"Tong tien lai (lai don): {laidon:F0} VND
Tong tien lai (lai kep): {A - P:F0} VND
Loi nhuan chenh lech: {A - P - laidon:F0} VND");
    }
    static void bai12()
    {
        Console.WriteLine("nhap van ban goc");
        string str1 = Console.ReadLine();
        Console.WriteLine("nhap khoa dich chuyen");
        int k = int.Parse(Console.ReadLine());
        char[] lst = str1.ToCharArray();
        int i = 0;
        foreach (char x in lst)
        {
            if (char.IsLetter(x))
            {
                int a = (int)x + k;
                lst[i] = (char)a;
            }
            i++;
        }
        string str2 = "";
        for (int y = 0; y < i; y++)
        {
            str2 += lst[y];
        }
        Console.WriteLine($"Van ban ma hoa: {str2}");
        Console.WriteLine($"Van ban giai ma: {str1}");
        Console.ReadLine();
    }
    static void bai13()
    {
        Console.WriteLine(@"Chon loai xe:
1. Motorbike
2. Car
3. Truck");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thoi gian xe vao (yyyy-MM-dd HH:mm)");
        string str1 = Console.ReadLine();
        DateTime checkin = DateTime.Parse(str1);
        Console.WriteLine("Nhap thoi gian xe ra (yyyy-MM-dd HH:mm)");
        string str2 = Console.ReadLine();
        DateTime checkout = DateTime.Parse(str2);
        TimeSpan time = checkout - checkin;
        Double time1 = time.TotalHours;
        int timetron = (int)time1;
        decimal phi2gio;
        decimal phinext;
        switch (a)
        {
            case 1:
                phi2gio = (decimal)VehicleType.Motorbike;
                phinext = 2000;
                break;
            case 2:
                phi2gio = (decimal)VehicleType.Car;
                phinext = 10000;
                break;
            default:
                phi2gio = (decimal)VehicleType.Truck;
                phinext = 25000;
                break;
        }
        string day2 = checkout.ToString("dd");
        string day1 = checkin.ToString("dd");
        int quadem = int.Parse(day2) - int.Parse(day1);
        decimal plus = 0;
        if (quadem > 0)
        {
            plus = 30000;
        }

        if (timetron + 1 < 2)
        {
            phi2gio = 0;

        }
        Console.WriteLine($@"Tong thoi gian do: {time1:F2} -> Tinh phi: {timetron + 1}
Phi 2 gio dau: {phi2gio} VND
Phi 4 gio tiep theo: {phinext * (timetron - 1)} VND
TONG PHI DO XE: {phi2gio + phinext * (timetron - 1) + plus} VND");
    }
    static void bai14()
    {
        Console.WriteLine("Nhap mot so bat ki:");
        int a;
        do
        {
            string str1 = Console.ReadLine();
            bool check = int.TryParse(str1, out a);
            if (check)
                a = int.Parse(str1);
            break;
            Console.WriteLine("Nhap sai roi, nhap lai");
        }
        while (true);
        short testshort;
        byte testbyte;
        bool kiemtra2 = short.TryParse(Convert.ToString(a), out testshort);
        bool kiemtra3 = byte.TryParse(Convert.ToString(a), out testbyte);
        Console.WriteLine($"Kiem tra Parse: Thanh cong! Gia tri int = {a}");
        if (kiemtra3)
        {
            Console.WriteLine("Phu hop kieu byte: CO (Vua van trong dai 0-255)");
        }
        else
        {
            Console.WriteLine("Phu hop kie byte: KHONG");
        }
        string str = Convert.ToString(a);
        int x = str.Length;
        int tong = 0;
        int p = 0;
        for (int i = 1; i <= x; i++)
        {
            int o = (int)(a % Math.Pow(10, i));
            int q = (int)((o - p) / Math.Pow(10, i - 1));
            p = o;
            tong += q;
        }
        char[] lst = str.ToCharArray();
        Console.Write($"Tong cac chu so: ");
        int y = 1;
        foreach (char c in lst)
        {
            if (y < x)
                Console.Write($"{c} + ");
            else
                Console.WriteLine($"{c} = {tong}");
            y++;
        }
        //while ( a!= 0)
        //{
        //    int k = a % 10;
        //    tong += k;
        //    a /= 10;
        //}
        Console.WriteLine("Kiem tra tran so: an toan trong pham vi Int32");
    }
    static void bai15()
    {
        decimal price = 100000;
        Console.WriteLine(@"Moi chon kieu khach hang:
1. Tre em
2. Hoc sinh, sinh vien
3. Nguoi truong thanh
4. Nguoi cao nien");
        int type = int.Parse(Console.ReadLine());
        Console.WriteLine("The sinh vien co hop le khong (1.true/2.falsez)");
        bool authentic = bool.Parse(Console.ReadLine());
        Console.WriteLine("Ngay xem phim la:");
        string str = Console.ReadLine();
        DateTime thu = DateTime.Parse(str);
        DayOfWeek thu2 = thu.DayOfWeek;
        int a = (int)thu2;
        int person;
        Console.WriteLine(a);
        switch (type)
        {
            case 1:
                person = (int)CustomerType.Child; break;
            case 2:
                person = (int)CustomerType.Student; break;
            case 3:
                person = (int)CustomerType.Adult; break;
            default:
                person = (int)CustomerType.Senior; break;
        }
        decimal discount = 0;
        decimal phuthu = 0;
        if (person == 2 && authentic == true && a > 0 && a < 4)
            discount = 30;
        if (person == 1 || person == 4)
            discount = 50;
        if (a == 3 && person == 3)
            discount = 20;
        if (a == 0 || a == 5 || a == 6)
            phuthu = 200000;
        Console.WriteLine($@"Gia ve goc: {price} VND
Giam gia ({discount}%): - {discount * price / 100} VND
Phu thu cuoi tuan: {phuthu} VND");
    }


    private static void Main1(string[] args)
    {
        //bai1 ();
        //bai2 ();
        //bai3 ();
        //bai4 ();
        //bai5 ();
        //bai6 ();
        //bai7 ();
        //bai8 ();
        //bai9 ();
        //bai10 ();
        //bai11 ();
        //bai12 ();
        //bai13 ();
        //bai14 (); 
        //bai15 ();
    }
}

