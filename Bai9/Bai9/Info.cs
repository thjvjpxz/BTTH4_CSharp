using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Info
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public Info(string hoTen, DateTime ngaySinh, string dienThoai, string diaChi)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DienThoai = dienThoai;
            DiaChi = diaChi;
        }
    }
}
