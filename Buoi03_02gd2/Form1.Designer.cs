namespace Buoi03_02gd2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;

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
            this.lblSoluong = new System.Windows.Forms.TextBox();
            this.cbban = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lvDanhsachdatmon = new System.Windows.Forms.ListView();
            this.lvDanhsachmon = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý đặt món";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.lblSoluong);
            this.groupBox1.Controls.Add(this.cbban);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(319, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn món";
            // 
            // lblSoluong
            // 
            this.lblSoluong.Location = new System.Drawing.Point(25, 127);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(125, 22);
            this.lblSoluong.TabIndex = 5;
            // 
            // cbban
            // 
            this.cbban.FormattingEnabled = true;
            this.cbban.Location = new System.Drawing.Point(9, 53);
            this.cbban.Name = "cbban";
            this.cbban.Size = new System.Drawing.Size(121, 24);
            this.cbban.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bàn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDanhsachdatmon);
            this.groupBox2.Location = new System.Drawing.Point(527, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 384);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đặt món";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvDanhsachmon);
            this.groupBox3.Location = new System.Drawing.Point(12, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 389);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách món";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(49, 229);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 51);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // lvDanhsachdatmon
            // 
            this.lvDanhsachdatmon.HideSelection = false;
            this.lvDanhsachdatmon.Location = new System.Drawing.Point(8, 21);
            this.lvDanhsachdatmon.Name = "lvDanhsachdatmon";
            this.lvDanhsachdatmon.Size = new System.Drawing.Size(247, 357);
            this.lvDanhsachdatmon.TabIndex = 1;
            this.lvDanhsachdatmon.UseCompatibleStateImageBehavior = false;
            // 
            // lvDanhsachmon
            // 
            this.lvDanhsachmon.HideSelection = false;
            this.lvDanhsachmon.Location = new System.Drawing.Point(6, 26);
            this.lvDanhsachmon.Name = "lvDanhsachmon";
            this.lvDanhsachmon.Size = new System.Drawing.Size(280, 357);
            this.lvDanhsachmon.TabIndex = 0;
            this.lvDanhsachmon.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbban;
        private System.Windows.Forms.TextBox lblSoluong;
        private System.Windows.Forms.ListView lvDanhsachdatmon;
        private System.Windows.Forms.ListView lvDanhsachmon;
    }
}

