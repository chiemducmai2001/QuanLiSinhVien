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
    public partial class frmCreateLopHocPhan : Form
    {
        LopHocPhanModel LopHocPhanModel;
        private LopHocPhanModel p;

        public frmCreateLopHocPhan(LopHocPhanModel lopHocPhanModel = null)
        {

            InitializeComponent();
            LoadMonHoc();
            this.LopHocPhanModel = lopHocPhanModel;
            if (this.LopHocPhanModel != null)
            {
                txtTenHocPhan.Text = this.LopHocPhanModel.TenLopHocPhan;
                txtGiaoVienPhuTrach.Text = this.LopHocPhanModel.GiaoVienPhuTrach;
                numMin.Value = this.LopHocPhanModel.SoLuongSinhVienMin.Value;
                numMax.Value = this.LopHocPhanModel.SoLuongSinhVienMax.Value;
                cmbTenMonHoc.SelectedValue = this.LopHocPhanModel.IDMonHoc;
            }

        }
        public MonHoc selectedMonHoc
        {
            get
            {
                return cmbTenMonHoc.SelectedItem as MonHoc;
            }
        }
        void LoadMonHoc()
        {
            var db = new AppModel();
            var ls = db.MonHocs.ToList();
            cmbTenMonHoc.DataSource = ls;
            cmbTenMonHoc.DisplayMember = "TenMonHoc";
            cmbTenMonHoc.ValueMember = "ID";
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            var db = new AppModel();
            if (LopHocPhanModel == null)
            {
                LopHocPhan lhp = new LopHocPhan
                {
                    TenLopHocPhan = txtTenHocPhan.Text,
                    GiaoVienPhuTrach = txtGiaoVienPhuTrach.Text,
                    SoLuongSinhVienMax = (int)numMax.Value,
                    SoLuongSinhVienMin = (int)numMin.Value,
               
                    SoLuongSinhVienDaDangKy = 0

                };
                db.LopHocPhans.Add(lhp);
                db.SaveChanges();
                DialogResult = DialogResult.OK;

            }
            else
            {
                var p = db.LopHocPhans.Where(t => t.ID == LopHocPhanModel.ID).FirstOrDefault();
                if (p != null)
                {
                    p.TenLopHocPhan = txtTenHocPhan.Text;
                    p.GiaoVienPhuTrach = txtGiaoVienPhuTrach.Text;
                    p.SoLuongSinhVienMax = (int)numMax.Value;
                    p.SoLuongSinhVienMin = (int)numMin.Value;
                    p.SoLuongSinhVienDaDangKy = 0;
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
