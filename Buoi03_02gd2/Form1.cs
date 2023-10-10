using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Buoi03_02gd2
{
    public partial class Form1 : Form
    {
        private List<string> foodMenu;
        private List<string> tableList;

        public Form1()
        {
            InitializeComponent();
            foodMenu = new List<string> { "STT", "Món", "Gia", "1. Cà phê 15000", "2. Cà đen 15000" };
            tableList = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                tableList.Add("Bàn " + i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string food in foodMenu)
            {
                lvDanhsachmon.Items.Add(food);
            }

            cbban.DataSource = tableList;
            lblSoluong.Text = "1";

            // Assign event handlers
            btnThem.Click += BtnThem_Click;
            btnHuy.Click += BtnHuy_Click;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (lvDanhsachmon.SelectedItems.Count > 0)
            {
                string selectedFood = lvDanhsachmon.SelectedItems[0].Text;
                string selectedTable = cbban.SelectedItem != null ? cbban.SelectedItem.ToString() : "";
                int quantity;
                if (int.TryParse(lblSoluong.Text, out quantity))
                {
                    ListViewItem newItem = new ListViewItem(new string[] { selectedFood, selectedTable, quantity.ToString() });
                    lvDanhsachdatmon.Items.Add(newItem);
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món từ danh sách món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            lvDanhsachdatmon.Items.Clear();
        }
    }
}
