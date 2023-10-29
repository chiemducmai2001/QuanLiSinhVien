namespace ChuongTrinhQuanLiSinhVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHocPhan")]
    public partial class LopHocPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHocPhan()
        {
            DangKyHocPhans = new HashSet<DangKyHocPhan>();
        }

        public long ID { get; set; }

        [StringLength(50)]
        public string TenLopHocPhan { get; set; }

        [StringLength(50)]
        public string GiaoVienPhuTrach { get; set; }

        public int? SoLuongSinhVienMax { get; set; }

        public int? SoLuongSinhVienMin { get; set; }

        public int? SoLuongSinhVienDaDangKy { get; set; }

        public long? IDMonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
