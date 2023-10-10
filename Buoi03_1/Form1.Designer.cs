namespace Buoi03_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TOÁN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số B";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cộng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Trừ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(374, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nhân";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(494, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 41);
            this.button4.TabIndex = 6;
            this.button4.Text = "Chia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(620, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả";
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(209, 117);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(420, 28);
            this.txtSoA.TabIndex = 10;
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(209, 162);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(420, 28);
            this.txtSoB.TabIndex = 11;
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(209, 333);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(420, 28);
            this.txtKetQua.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

