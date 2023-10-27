using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-BJ79796\SQLEXPRESS;Initial Catalog=QLBHDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void label2_Click(object sender, EventArgs e)
        {
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
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvUsers.DataSource = ds.Tables[0];


                Con.Close();

            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + txtUname.Text + "', '" + txtFname.Text + "', '" + txtPassword.Text + "', '" + txtPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void gvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvUsers.Rows[e.RowIndex];
                txtFname.Text = row.Cells[0].Value.ToString();
                txtUname.Text = row.Cells[2].Value.ToString();
                txtPassword.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
               
            }
            else if (e.RowIndex == -1 && gvUsers.Rows.Count > 0)
            {
                DataGridViewRow firstRow = gvUsers.Rows[0];
                txtFname.Text = firstRow.Cells[0].Value.ToString();
                txtUname.Text = firstRow.Cells[1].Value.ToString();
                txtPassword.Text = firstRow.Cells[1].Value.ToString();
                txtPhone.Text = firstRow.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "UPDATE UserTbl SET Uname = '" + txtUname.Text + "', Ufullname = '" + txtFname.Text + "', Upassword = '" + txtPassword.Text + "' WHERE Uphone = '" + txtPhone.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                txtFname.Text = "";
                txtUname.Text = "";
                txtPassword.Text = "";
                txtPhone.Text = "";
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            } try
            {
                Con.Open();
                string myquery = "UPDATE UserTbl SET Uname = '" + txtUname.Text + "', Ufullname = '" + txtFname.Text + "', Upassword = '" + txtPassword.Text + "' WHERE Uphone = '" + txtPhone.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                txtFname.Text = "";
                txtUname.Text = "";
                txtPassword.Text = "";
                txtPhone.Text = "";
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Nhap so dien thoai");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where Uphone='" + txtPhone.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
                txtFname.Text = "";
                txtUname.Text = "";
                txtPassword.Text = "";
                txtPhone.Text = "";
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
