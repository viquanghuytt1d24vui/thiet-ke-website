using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap so nguyen thu nhat: ");
                int a = int.Parse(Console.ReadLine()!);
                Console.Write("Nhap so nguyen thu hai: ");
                int b = int.Parse(Console.ReadLine()!);
                Console.Write("Nhap so nguyen thu ba: ");
                int a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Tong cua 3 so : "+(a+b+c));
                Console.WriteLine("Tich cua 3 so : "+(a*b*c));
                double tb=(a+b+c)/3;
                Console.WriteLine("Trung binh cong cua 3 so: "+tb);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}
