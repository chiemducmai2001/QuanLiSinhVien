using ChuongTrinhQuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLiSinhVien.ViewModel
{
    public class SinhVienModel
    {
        public long ID { get; set; }
        public string MaSinhVien { get; set; }
        public string HoDem { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string QueQuan { get; set; }

    }

}
