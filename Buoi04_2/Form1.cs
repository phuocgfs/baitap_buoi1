using System;
using System.Windows.Forms;

namespace Buoi04_2
{
    public partial class Form1 : Form
    {
        int rowindex = 1;
        string[] listKhoa = { "Công nghệ thông tin", "Kế toán", "Ngoại ngữ", "Điện tử" };

        public bool CheckMaSV(string masv)
        {
            if (dgvDanhsach.Rows.Count == 0)
            {
                return true;
            }

            for (int row = 0; row < dgvDanhsach.Rows.Count - 1; row++)
            {
                if (dgvDanhsach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
            dgvDanhsach.CellClick += dgvDanhsach_CellClick;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listKhoa;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (!txtMasv.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên phải có 10 ký tự");
                }

                if (!CheckMaSV(txtMasv.Text))
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }

                if (string.IsNullOrWhiteSpace(txtHoten.Text))
                {
                    throw new Exception("Họ tên không được để trống");
                }

                if (!double.TryParse(txtDiem.Text, out diemtb))
                {
                    throw new Exception("Điểm trung bình phải là số");
                }

                string masv = txtMasv.Text;
                string hoten = txtHoten.Text;
                string khoa = cbKhoa.Text;
                int row = dgvDanhsach.Rows.Add();
                dgvDanhsach.Rows[row].Cells["MaSV"].Value = masv;
                dgvDanhsach.Rows[row].Cells["Hoten"].Value = hoten;
                dgvDanhsach.Rows[row].Cells["DiemTB"].Value = diemtb;
                dgvDanhsach.Rows[row].Cells["Khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        private void dgvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhsach.Rows.Count - 1)
            {
                rowindex = e.RowIndex;
                txtMasv.Text = dgvDanhsach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoten.Text = dgvDanhsach.Rows[rowindex].Cells["Hoten"].Value.ToString();
                txtDiem.Text = dgvDanhsach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                string tenkhoa = dgvDanhsach.Rows[rowindex].Cells["Khoa"].Value.ToString();

                int i = 0;
                while (i < listKhoa.Length && listKhoa[i] != tenkhoa)
                {
                    i++;
                }
                cbKhoa.SelectedIndex = i;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần cập nhật");
                }
                if (!txtMasv.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên phải có 10 ký tự");
                }
                if (!CheckMaSV(txtMasv.Text) && txtMasv.Text != dgvDanhsach.Rows[rowindex].Cells["MaSV"].Value.ToString())
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }
                if (string.IsNullOrWhiteSpace(txtHoten.Text))
                {
                    throw new Exception("Họ tên không được để trống");
                }
                if (!double.TryParse(txtDiem.Text, out diemtb))
                {
                    throw new Exception("Điểm trung bình phải là số");
                }
                string masv = txtMasv.Text;
                string hoten = txtHoten.Text;
                string khoa = cbKhoa.Text;
                dgvDanhsach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhsach.Rows[rowindex].Cells["Hoten"].Value = hoten;
                dgvDanhsach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
                dgvDanhsach.Rows[rowindex].Cells["Khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xóa");
                }
                dgvDanhsach.Rows.RemoveAt(rowindex);
                rowindex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn muốn thoát",
                "Thông báo",
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
