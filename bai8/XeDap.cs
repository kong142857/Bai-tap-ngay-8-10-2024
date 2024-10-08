using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    // Lớp XeDap kế thừa từ PhuongTien và hiện thực một phần giao diện IThongTinThem
    public class XeDap : PhuongTien, IThongTinThem
    {
        public XeDap(string tenPhuongTien)
            : base(tenPhuongTien, "Khong su dung nhien lieu") { }

        public override void DiChuyen()
        {
            Console.WriteLine($"{TenPhuongTien} di chuyen bang suc đap cua con nguoi.");
        }

        // Hiện thực phương thức TocDoToiDa() của giao diện
        public int TocDoToiDa()
        {
            return 30; // tốc độ tối đa là 30 km/h
        }

        // Xe đạp không có nhiên liệu nên không cần hiện thực MucTieuThuNhienLieu()
        public float MucTieuThuNhienLieu()
        {
            return 0; // không tiêu thụ nhiên liệu
        }
    }

}
