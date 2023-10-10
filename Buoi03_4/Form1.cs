using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_4
{
    public partial class Form1 : Form
    {
        private int chon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lbSinhVien.Items.Add("Nguyễn Văn An");
            lbSinhVien.Items.Add("Lê Văn Be");
            lbSinhVien.Items.Add("Trần Văn Chính");
            lbSinhVien.Items.Add("Mai Hữu Danh");
            lbSinhVien.Items.Add("Hồ Văn En");
            cbKhoa.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoten.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên chưa nhập");
                }
                string hoten = txtHoten.Text;
                lbSinhVien.Items.Add(hoten);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonSV_Click_Click(object sender, EventArgs e)
        {
            if (chon != -1)
            {
                string hoten = lbSinhVien.SelectedItem.ToString();
                string khoa = cbKhoa.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
                lbSinhVien.Items.RemoveAt(lbSinhVien.SelectedIndex);
                chon = -1;
            }
        }

        private void btnThemAll_Click_Click(object sender, EventArgs e)
        {
            int count = lbSinhVien.Items.Count;
            for (int vt = 0; vt < count; vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbSinhVien.Items[vt].ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
            }
            lbSinhVien.Items.Clear();
        }

        private void btnXoa1_Click_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLop.Items)
            {
                if (item.Selected)
                {
                    lvLop.Items.Remove(item);
                    lbSinhVien.Items.Add((item.Text));
                }
            }
        }

        private void btnXoaAll_Click_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLop.Items)
            {

                lvLop.Items.Remove(item);
                lbSinhVien.Items.Add((item.Text));

            }
        }

        private void lbSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            chon = 1;
        }
    }
}
