using System;
class Program
{
    static double TinhLuong(double luongCoBan, int soNgayLam, double heSoThuong)
    {
        return luongCoBan/26*soNgayLam*heSoThuong;
    }
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Nhap luong co ban: ");
            double luongCoBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay: ");
            int soNgayLam = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so thuong: ");
            double heSoThuong = double.Parse(Console.ReadLine());
            if (soNgayLam == 0)
            {
                throw new Exception();
            }
            double luong = TinhLuong(luongCoBan,soNgayLam,heSoThuong);
            Console.WriteLine("luong nhan vien: "+ luong);
        }
        
        catch (FormatException ex)
        {
            Console.WriteLine("loi du lieu khong hop le"+ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("loi chia cho 0"+ ex.Message);
        }
        finally
        {
            Console.WriteLine("ket thuc");
        }
    }
}

