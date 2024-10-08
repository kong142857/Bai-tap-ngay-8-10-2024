using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    public abstract class PhuongTien
    {
        public string TenPhuongTien { get; set; }
        public string LoaiNhienLieu { get; set; }

        public PhuongTien(string tenPhuongTien, string loaiNhienLieu)
        {
            TenPhuongTien = tenPhuongTien;
            LoaiNhienLieu = loaiNhienLieu;
        }

        // Phương thức trừu tượng cần được hiện thực bởi lớp con
        public abstract void DiChuyen();
    }
}
