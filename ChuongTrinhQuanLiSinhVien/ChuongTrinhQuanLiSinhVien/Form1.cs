using ChuongTrinhQuanLiSinhVien.Model;
using ChuongTrinhQuanLiSinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLiSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMonHoc();
        }
        void LoadMonHoc()
        {
            var db = new AppModel();
            var ls = db.MonHocs.ToList();
            cmbMonHoc.DataSource = ls;
            cmbMonHoc.DisplayMember = "TenMonHoc";

        }
        void LoadLopHocPhan()
        {
            if (selectedMonHoc != null)
            {
                var db = new AppModel();
                var ls = db.LopHocPhans.Where(e => e.IDMonHoc == selectedMonHoc.ID).Select(e => new LopHocPhanModel
                {

                    ID = e.ID,
                    TenLopHocPhan = e.TenLopHocPhan,
                    GiaoVienPhuTrach = e.GiaoVienPhuTrach,
                    SoLuongSinhVienDaDangKy = e.SoLuongSinhVienDaDangKy,
                    SoLuongSinhVienMax = e.SoLuongSinhVienMax,
                    SoLuongSinhVienMin = e.SoLuongSinhVienMin,
                    IDMonHoc = e.IDMonHoc

                }).ToList();
                lopHocPhanBindingSource.DataSource = ls;
                gridTenLopHocPhan.DataSource = lopHocPhanBindingSource;
            }
        }
        void LoadInfo()
        {
            var p = lopHocPhanBindingSource.Current as LopHocPhanModel;
            var db = new AppModel();
            var data = db.LopHocPhans.Where(t => t.ID == p.ID).FirstOrDefault();
            lblMaLopHocPhan.Text = $"{p.ID}";
            lblGiaoVienPhuTrach.Text = $"{p.GiaoVienPhuTrach}";
            lblMinMax.Text = $"{p.SoLuongSinhVienMin} / {p.SoLuongSinhVienMax}";
            lblSoLuong.Text = $"{data.SoLuongSinhVienDaDangKy}";
        }
        void LoadData()
        {
            var db = new AppModel();
            var p = lopHocPhanBindingSource.Current as LopHocPhanModel;
            var lssv =
                from hp in db.DangKyHocPhans
                join sv in db.SinhViens on hp.IDSinhVien equals sv.ID
                where hp.IDLopHocPhan == p.ID
                select new SinhVienModel
                {
                    ID = sv.ID,
                    MaSinhVien = sv.MaSinhVien,
                    HoDem = sv.HoDem,
                    Ten = sv.Ten,
                    NgaySinh = sv.NgaySinh,
                    QueQuan = sv.QueQuan
                };
            sinhVienBindingSource.DataSource = lssv.ToList();
            gridSinhVien.DataSource = sinhVienBindingSource;
        }
        public MonHoc selectedMonHoc
        {
            get
            {
                return cmbMonHoc.SelectedItem as MonHoc;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlisinhvienDataSet1.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanlisinhvienDataSet1.SinhVien);
            // TODO: This line of code loads data into the 'quanlisinhvienDataSet.LopHocPhan' table. You can move, or remove it, as needed.
            this.lopHocPhanTableAdapter.Fill(this.quanlisinhvienDataSet.LopHocPhan);

        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLopHocPhan();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gridSinhVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void gridTenLopHocPhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadInfo();
            LoadData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var f = new frmCreateLopHocPhan();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadLopHocPhan();
            };
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var sv = sinhVienBindingSource.Current as SinhVienModel;
            var lhp = lopHocPhanBindingSource.Current as LopHocPhanModel;
            var f = new frmCreateSinhVien(sv, lhp);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                LoadInfo();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var p = lopHocPhanBindingSource.Current as LopHocPhanModel;
                if (p != null)
                {
                    var db = new AppModel();
                    var lhp = db.LopHocPhans.Where(t => t.ID == p.ID).FirstOrDefault();
                    db.LopHocPhans.Remove(lhp);
                    db.SaveChanges();
                    LoadLopHocPhan();
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            var p = lopHocPhanBindingSource.Current as LopHocPhanModel;
            var f = new frmCreateLopHocPhan(p);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadLopHocPhan();
                LoadData();
                LoadInfo();
            };
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            var p = lopHocPhanBindingSource.Current as LopHocPhanModel;
            var f = new frmCreateLopHocPhan(p);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadLopHocPhan();
                LoadData();
                LoadInfo();
            };
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var q = lopHocPhanBindingSource.Current as LopHocPhanModel;
            var f = new frmCreateSinhVien(null, q);
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                LoadInfo();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var p = sinhVienBindingSource.Current as SinhVienModel;
                var q = lopHocPhanBindingSource.Current as LopHocPhanModel;
                if (p != null)
                {
                    var db = new AppModel();
                    var n = db.LopHocPhans.Where(t => t.ID == q.ID).FirstOrDefault();
                    if (n != null)
                        n.SoLuongSinhVienDaDangKy -= 1;
                    var sinhvien = db.DangKyHocPhans.Where(t => t.IDLopHocPhan == q.ID && t.IDSinhVien == p.ID).FirstOrDefault();
                    db.DangKyHocPhans.Remove(sinhvien);
                    db.SaveChanges();

                    LoadData();
                    LoadInfo();
                }
            }
        }
    }
}
