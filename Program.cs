using System;
namespace TinhToan
{
    class Program
    {
        static string xeploai(double diem)
        {
            if (diem < 0 || diem > 10)
                return "nhap diem tu 0 toi 10";
            else
            {
                string xep_loai = "";

                if (diem >= 9.0)
                    xep_loai = "xuat sac";
                else if (diem >= 8.0)
                    xep_loai = "Gioi";
                else if (diem >= 6.5)
                    xep_loai = "Kha";
                else if (diem >= 5.0)
                    xep_loai = "Trung binh";
                else
                    xep_loai = "Yeu";

                return xep_loai;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap diem: ");
                double d = double.Parse(Console.ReadLine()!);

                Console.WriteLine(xeploai(d));

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}
