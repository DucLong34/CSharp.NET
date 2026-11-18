using System;

namespace bai1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.Write("Nhập mã nhân viên : ");
            string InputMaNhanVien = Console.ReadLine();
            int MaNhanVien = int.Parse(InputMaNhanVien);

            Console.Write("Nhập họ và tên nhân viên : ");
            string Hoten = Console.ReadLine();

            Console.Write("Nhập ngày sinh : ");
            string NgaySinh = Console.ReadLine();

            Console.Write("Nhập địa chỉ : ");
            string DiaChi = Console.ReadLine();

            Console.Write("Nhập số điện thoại : ");
            string Inputsdt = Console.ReadLine();
            int? SoDienThoai = int.Parse(Inputsdt);

            Console.Write("Nhập Email : ");
            string Email = Console.ReadLine();


            Console.WriteLine("--------- ---------");
            Console.WriteLine(" ĐÃ TÌM THẤY NHÂN VIÊN ");
            Console.WriteLine($" mã nhân viên : {MaNhanVien} ");
            Console.WriteLine($" họ và tên  : {Hoten}");
            Console.WriteLine($" ngày sinh : {NgaySinh} ");
            Console.WriteLine($" địa chỉ : {DiaChi} ");
            Console.WriteLine($" số điện thoại : {SoDienThoai} ");
            Console.WriteLine($" Email : {Email} ");
        }
    }
}