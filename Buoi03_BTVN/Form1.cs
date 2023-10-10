using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Buoi03_BTVN
{
    public partial class Form1 : Form
    {
        private List<string> danhSachSach = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
            string maSach = txtMasach.Text;
            string tenSach = txtTensach.Text;
            string gia = txtGia.Text;
            string soLuong = txtSoluong.Text;

            string thongTinSach = $"Mã sách: {maSach}, Tên sách: {tenSach}, Giá: {gia}, Số lượng: {soLuong}";

        
            txtDanhsach.AppendText(thongTinSach + Environment.NewLine);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
         
            txtDanhsach.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }

        private void UpdateDanhSachTextBox()
        {
            
            txtDanhsach.Text = string.Join(Environment.NewLine, danhSachSach);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
        }
    }
}
