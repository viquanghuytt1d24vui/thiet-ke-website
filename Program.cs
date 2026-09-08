using System;
namespace Bai2{
class Program
{
    static int TongSoChan(int[] a)
    {
        int tong = 0;
        foreach (int x in a)
        {
            if (x % 2 == 0)
            {
                tong += x;
            }
        }
        return tong;
    }
    static int TimGiaTriLonNhat(int[] a)
    {
        int max = a[0];
        foreach (int x in a)
        {
            if (x > max)
            {
                max = x;
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                throw new FormatException();
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a["+i+"]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tong so chan: " + TongSoChan(a));
            Console.WriteLine("Gia tri lon nhat: " + TimGiaTriLonNhat(a));
        }
        catch (Exception ex)
        {
            Console.WriteLine("loi"+ex.Message);
        }
    }
}}
