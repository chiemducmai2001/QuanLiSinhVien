using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLiSinhVien.ViewModel
{
    public class LopHocPhanModel
    {
        public long ID { get; set; }
        public string TenLopHocPhan { get; set; }
        public int? SoLuongSinhVienDaDangKy { get; set; }
        public int? SoLuongSinhVienMax { get; set; }
        public int? SoLuongSinhVienMin { get; set; }
        public long? IDMonHoc { get; set; }
        public string GiaoVienPhuTrach { get; set; }


    }
}
