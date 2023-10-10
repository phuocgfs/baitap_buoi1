namespace Buoi03_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGame = new System.Windows.Forms.CheckBox();
            this.cbNhau = new System.Windows.Forms.CheckBox();
            this.cbThethao = new System.Windows.Forms.CheckBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDanhSach = new System.Windows.Forms.GroupBox();
            this.lblThongbao = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.txtDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGame);
            this.groupBox1.Controls.Add(this.cbNhau);
            this.groupBox1.Controls.Add(this.cbThethao);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 330);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbGame
            // 
            this.cbGame.AutoSize = true;
            this.cbGame.Location = new System.Drawing.Point(100, 237);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(66, 20);
            this.cbGame.TabIndex = 13;
            this.cbGame.Text = "Game";
            this.cbGame.UseVisualStyleBackColor = true;
            // 
            // cbNhau
            // 
            this.cbNhau.AutoSize = true;
            this.cbNhau.Location = new System.Drawing.Point(100, 275);
            this.cbNhau.Name = "cbNhau";
            this.cbNhau.Size = new System.Drawing.Size(61, 20);
            this.cbNhau.TabIndex = 12;
            this.cbNhau.Text = "Nhậu";
            this.cbNhau.UseVisualStyleBackColor = true;
            // 
            // cbThethao
            // 
            this.cbThethao.AutoSize = true;
            this.cbThethao.Location = new System.Drawing.Point(100, 197);
            this.cbThethao.Name = "cbThethao";
            this.cbThethao.Size = new System.Drawing.Size(82, 20);
            this.cbThethao.TabIndex = 11;
            this.cbThethao.Text = "Thể thao";
            this.cbThethao.UseVisualStyleBackColor = true;
            this.cbThethao.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(180, 151);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 10;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(85, 151);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 9;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(95, 67);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(100, 22);
            this.txtHoten.TabIndex = 8;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(95, 104);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(100, 22);
            this.txtNgaySinh.TabIndex = 7;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(95, 27);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sở thích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(381, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Controls.Add(this.lblThongbao);
            this.txtDanhSach.Location = new System.Drawing.Point(381, 170);
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(390, 252);
            this.txtDanhSach.TabIndex = 4;
            this.txtDanhSach.TabStop = false;
            this.txtDanhSach.Text = "Danh sách";
            // 
            // lblThongbao
            // 
            this.lblThongbao.Location = new System.Drawing.Point(6, 21);
            this.lblThongbao.Multiline = true;
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(378, 225);
            this.lblThongbao.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDanhSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.txtDanhSach.ResumeLayout(false);
            this.txtDanhSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbGame;
        private System.Windows.Forms.CheckBox cbNhau;
        private System.Windows.Forms.CheckBox cbThethao;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox txtDanhSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox lblThongbao;
    }
}

