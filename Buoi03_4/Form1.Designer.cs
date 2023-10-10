using System;

namespace Buoi03_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSinhVien = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaAll_Click = new System.Windows.Forms.Button();
            this.btnThemAll_Click = new System.Windows.Forms.Button();
            this.btnChonSV_Click = new System.Windows.Forms.Button();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvLop = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa1_Click = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sinh viên";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(76, 33);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(366, 20);
            this.txtHoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(58, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach sinh vien";
            // 
            // lbSinhVien
            // 
            this.lbSinhVien.FormattingEnabled = true;
            this.lbSinhVien.Location = new System.Drawing.Point(25, 31);
            this.lbSinhVien.Name = "lbSinhVien";
            this.lbSinhVien.Size = new System.Drawing.Size(157, 251);
            this.lbSinhVien.TabIndex = 0;
            this.lbSinhVien.SelectedIndexChanged += new System.EventHandler(this.lbSinhVien_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa1_Click);
            this.groupBox3.Controls.Add(this.btnXoaAll_Click);
            this.groupBox3.Controls.Add(this.btnThemAll_Click);
            this.groupBox3.Controls.Add(this.btnChonSV_Click);
            this.groupBox3.Controls.Add(this.cbKhoa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(271, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoaAll_Click
            // 
            this.btnXoaAll_Click.Location = new System.Drawing.Point(19, 259);
            this.btnXoaAll_Click.Name = "btnXoaAll_Click";
            this.btnXoaAll_Click.Size = new System.Drawing.Size(132, 23);
            this.btnXoaAll_Click.TabIndex = 5;
            this.btnXoaAll_Click.Text = "<<";
            this.btnXoaAll_Click.UseVisualStyleBackColor = true;
            this.btnXoaAll_Click.Click += new System.EventHandler(this.btnXoaAll_Click_Click);
            // 
            // btnThemAll_Click
            // 
            this.btnThemAll_Click.Location = new System.Drawing.Point(19, 167);
            this.btnThemAll_Click.Name = "btnThemAll_Click";
            this.btnThemAll_Click.Size = new System.Drawing.Size(132, 23);
            this.btnThemAll_Click.TabIndex = 3;
            this.btnThemAll_Click.Text = ">>";
            this.btnThemAll_Click.UseVisualStyleBackColor = true;
            this.btnThemAll_Click.Click += new System.EventHandler(this.btnThemAll_Click_Click);
            // 
            // btnChonSV_Click
            // 
            this.btnChonSV_Click.Location = new System.Drawing.Point(19, 116);
            this.btnChonSV_Click.Name = "btnChonSV_Click";
            this.btnChonSV_Click.Size = new System.Drawing.Size(132, 23);
            this.btnChonSV_Click.TabIndex = 2;
            this.btnChonSV_Click.Text = ">";
            this.btnChonSV_Click.UseVisualStyleBackColor = true;
            this.btnChonSV_Click.Click += new System.EventHandler(this.btnChonSV_Click_Click);
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "CNTT",
            "Kế Toán",
            "Thực Phẩm",
            "May",
            "Cơ Khí"});
            this.cbKhoa.Location = new System.Drawing.Point(19, 63);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(132, 21);
            this.cbKhoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvLop);
            this.groupBox4.Location = new System.Drawing.Point(445, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 303);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinh viên được chọn";
            // 
            // lvLop
            // 
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLop.HideSelection = false;
            this.lvLop.Location = new System.Drawing.Point(25, 31);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(245, 251);
            this.lvLop.TabIndex = 0;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khoa";
            this.columnHeader2.Width = 120;
            // 
            // btnXoa1_Click
            // 
            this.btnXoa1_Click.Location = new System.Drawing.Point(19, 217);
            this.btnXoa1_Click.Name = "btnXoa1_Click";
            this.btnXoa1_Click.Size = new System.Drawing.Size(132, 23);
            this.btnXoa1_Click.TabIndex = 6;
            this.btnXoa1_Click.Text = "<";
            this.btnXoa1_Click.UseVisualStyleBackColor = true;
            this.btnXoa1_Click.Click += new System.EventHandler(this.btnXoa1_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "THÊM SINH VIÊN VÀO LỚP";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemAll_Click;
        private System.Windows.Forms.Button btnChonSV_Click;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnXoaAll_Click;
        private System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnXoa1_Click;
    }
}

