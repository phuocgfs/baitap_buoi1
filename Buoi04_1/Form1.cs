using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_1
{
    public partial class Form1 : Form
    {
        int rowchoose;
        string[] danhsachkhoa = { "CNTT", "Ke Toan", "Co khi", "Ngoai ngu"};
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgaysinh.MaxDate = DateTime.Now;
            loadKhoa();
        }
        private void loadKhoa()
        {
            cbKhoa.DataSource = danhsachkhoa;
            cbKhoa.SelectedItem = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMasv.Text.Length != 4)
                {
                    throw new Exception("Ma sinh vien khong hop le");
                }
                if (txtHoten.Text.Length < 2)
                {
                    throw new Exception("Ho ten it nhat 2 kt");
                }
                string masv = txtMasv.Text;
                string hoten = txtHoten.Text;
                string ngaysinh = dtpNgaysinh.Text;
                string khoa = cbKhoa.Text;
                int rowindex = dgvDanhsach.Rows.Add();
                dgvDanhsach.Rows[rowindex] .Cells["MaSV"].Value= masv;
                dgvDanhsach.Rows[rowindex].Cells["Hoten"].Value = hoten;
                dgvDanhsach.Rows[rowindex].Cells["Ngaysinh"].Value= ngaysinh;
                dgvDanhsach.Rows[rowindex].Cells["Khoa"].Value= khoa;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dgvDanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien");
                }

                  rowchoose = e.RowIndex;
                txtMasv.Text = dgvDanhsach.Rows[rowchoose].Cells["Masv"].Value.ToString();
                txtHoten.Text = dgvDanhsach.Rows[rowchoose].Cells["Hoten"].Value.ToString();
                dtpNgaysinh.Text = dgvDanhsach.Rows[rowchoose].Cells["Ngaysinh"].Value.ToString();
                cbKhoa.Text = dgvDanhsach.Rows[rowchoose].Cells["Khoa"].Value.ToString();
                btnCapnhat.Enabled = true;
                btnXoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if(rowchoose == -1 || rowchoose >= dgvDanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien can cap nhat");
                }
                if(txtMasv.Text.Length != 10)
                {
                    throw new Exception("Ma sinh vien dung 10 ky tu");
                }
                if(txtHoten.Text.Length < 2)
                {
                    throw new Exception("Ho ten khong hop le");
                }
                string masv = txtMasv.Text;
                string hoten = txtHoten.Text;
                string ngaysinh= dtpNgaysinh.Text;
                string khoa = cbKhoa.Text;
                dgvDanhsach.Rows[rowchoose].Cells["Masv"].Value = masv;
                dgvDanhsach.Rows[rowchoose].Cells["Hoten"].Value = hoten;
                dgvDanhsach.Rows[rowchoose].Cells["Ngaysinh"].Value = ngaysinh;
                dgvDanhsach.Rows[rowchoose].Cells["Khoa"].Value = khoa;

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien can xoa");
                }
                dgvDanhsach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ban muon thoat",
                "Thong bao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
