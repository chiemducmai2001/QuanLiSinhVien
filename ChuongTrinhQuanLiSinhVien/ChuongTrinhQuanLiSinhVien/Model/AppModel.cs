using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ChuongTrinhQuanLiSinhVien.Model
{
    public partial class AppModel : DbContext
    {
        public AppModel()
            : base("name=AppModel")
        {
        }

        public virtual DbSet<DangKyHocPhan> DangKyHocPhans { get; set; }
        public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHocPhan>()
                .HasMany(e => e.DangKyHocPhans)
                .WithRequired(e => e.LopHocPhan)
                .HasForeignKey(e => e.IDLopHocPhan)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.LopHocPhans)
                .WithOptional(e => e.MonHoc)
                .HasForeignKey(e => e.IDMonHoc);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.DangKyHocPhans)
                .WithRequired(e => e.SinhVien)
                .HasForeignKey(e => e.IDSinhVien)
                .WillCascadeOnDelete(true);
        }
    }
}
