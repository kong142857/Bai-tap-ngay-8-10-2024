using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách các phương tiện
            List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>
        {
            new XeHoi("Toyota Camry", "Xang"),
            new XeDap("Xe đap the thao")
        };

            // Hiển thị thông tin và gọi các phương thức
            foreach (var phuongTien in danhSachPhuongTien)
            {
                Console.WriteLine($"Ten phuong tien: {phuongTien.TenPhuongTien}");
                Console.WriteLine($"Loai nhien lieu: {phuongTien.LoaiNhienLieu}");
                phuongTien.DiChuyen();

                if (phuongTien is IThongTinThem thongTinThem)
                {
                    Console.WriteLine($"Toc đo toi da: {thongTinThem.TocDoToiDa()} km/h");
                    if (phuongTien is XeHoi)
                    {
                        Console.WriteLine($"Muc tieu thu nhien lieu: {thongTinThem.MucTieuThuNhienLieu()} lit/100km");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
