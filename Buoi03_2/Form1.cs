using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_2
{
    public partial class Form1 : Form
    {
        private int stt = 1;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoten.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống");
                }

                string hoten = txtHoten.Text;
                string masv = txtMaSV.Text;
                string ngaysinh = txtNgaySinh.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;

                if (cbThethao.Checked)
                {
                    sothich += "Thể thao";
                }
                if (cbGame.Checked)
                {
                    sothich += "Game";
                }
                if (cbNhau.Checked)
                {
                    sothich += "Nhậu";
                }
                if (sothich != null)
                {
                    sothich = "Sở thích: " + sothich;
                }

                lblThongbao.Text += stt + ". Họ tên: " + hoten + ", Ngày sinh: " + ngaysinh + ", Giới tính: " + gioitinh + ", " + sothich + "\n"; stt++;
            }
            catch (Exception ex)
            {
                lblThongbao.Text = ex.Message;
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
