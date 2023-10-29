using ChuongTrinhQuanLiSinhVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQuanLiSinhVien.Model;
using ChuongTrinhQuanLiSinhVien.ViewModel;

namespace ChuongTrinhQuanLiSinhVien
{
    public partial class frmCreateSinhVien : Form
    {
        public SinhVienModel sinhVienModel;
        public LopHocPhanModel lopHocPhanModel;
        public frmCreateSinhVien(SinhVienModel sinhVienModel = null, LopHocPhanModel lopHocPhanModel = null)
        {
            InitializeComponent();
            LoadSinhVien();
            this.sinhVienModel= sinhVienModel;
            this.lopHocPhanModel = lopHocPhanModel;
            if (this.sinhVienModel != null)
            {
                cmbMaSV.SelectedValue = this.sinhVienModel.ID;
                txtHoDem.ReadOnly = false;
                txtTen.ReadOnly = false;
                txtQueQuan.ReadOnly = false;
                txtNgaySinh.Enabled = true;
            }
            if (this.lopHocPhanModel != null)
                txtLopHP.Text = this.lopHocPhanModel.TenLopHocPhan;
            this.lopHocPhanModel = lopHocPhanModel;
        }
        void LoadSinhVien()
        {
            var db = new AppModel();
            var ls = db.SinhViens.ToList();
            cmbMaSV.DataSource = ls;
            cmbMaSV.DisplayMember = "MaSinhVien";
            cmbMaSV.ValueMember = "ID";
        }
        void LoadData()
        {
            txtHoDem.Text = selectedSinhVien.HoDem;
            txtTen.Text = selectedSinhVien.Ten;
            txtNgaySinh.Value = selectedSinhVien.NgaySinh.Value;
            txtQueQuan.Text = selectedSinhVien.QueQuan;
        }
        public SinhVien selectedSinhVien
        {
            get
            {
                return cmbMaSV.SelectedItem as SinhVien;
            }
        }

        private void frmCreateSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = new AppModel();
            if (sinhVienModel == null)
            {
                DangKyHocPhan p = new DangKyHocPhan
                {
                    IDLopHocPhan = lopHocPhanModel.ID,
                    IDSinhVien = selectedSinhVien.ID,
                    NgayDangKy = DateTime.Now
                };
                db.DangKyHocPhans.Add(p);
                Console.WriteLine(1);
                var q = db.LopHocPhans.Where(t => t.ID == lopHocPhanModel.ID).FirstOrDefault();
                if (q != null)
                    q.SoLuongSinhVienDaDangKy += 1;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var p = db.SinhViens.Where(t => t.ID == sinhVienModel.ID).FirstOrDefault();
                if (p != null)
                {
                    p.HoDem = txtHoDem.Text;
                    p.Ten = txtTen.Text;
                    p.QueQuan = txtQueQuan.Text;
                    p.NgaySinh = txtNgaySinh.Value;
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
