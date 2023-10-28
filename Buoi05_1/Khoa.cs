using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_1
{
    internal class Khoa
    {
        public string MaKhoa {  get; set; }
        public string TenKhoa { get; set; }
        public string GhiChu {  get; set; }
        public Khoa() { }
        public Khoa(string makhoa, string tenkhoa, string ghichu)
        {
            this.MaKhoa = makhoa;
            this.TenKhoa = tenkhoa;
            this.GhiChu = ghichu;
        }
    }
}
