using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    // Lớp XeHoi kế thừa từ PhuongTien và hiện thực giao diện IThongTinThem
    public class XeHoi : PhuongTien, IThongTinThem
    {
        public XeHoi(string tenPhuongTien, string loaiNhienLieu)
            : base(tenPhuongTien, loaiNhienLieu) { }

        public override void DiChuyen()
        {
            Console.WriteLine($"{TenPhuongTien} di chuyen bang dong co xang hoac dau.");
        }

        // Hiện thực phương thức của giao diện
        public int TocDoToiDa()
        {
            return 200; // tốc độ tối đa là 200 km/h
        }

        public float MucTieuThuNhienLieu()
        {
            return 8.5f; // mức tiêu thụ nhiên liệu là 8.5 lít/100km
        }
    }

}
