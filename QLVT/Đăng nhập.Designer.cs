namespace QLVT
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
            this.gbSignIn = new System.Windows.Forms.GroupBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDN = new System.Windows.Forms.Button();
            this.ckbHide = new System.Windows.Forms.CheckBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSignIn
            // 
            this.gbSignIn.BackColor = System.Drawing.Color.Transparent;
            this.gbSignIn.Controls.Add(this.pictureBox4);
            this.gbSignIn.Controls.Add(this.pictureBox3);
            this.gbSignIn.Controls.Add(this.txtMK);
            this.gbSignIn.Controls.Add(this.label2);
            this.gbSignIn.Controls.Add(this.label1);
            this.gbSignIn.Controls.Add(this.pictureBox1);
            this.gbSignIn.Controls.Add(this.btnDN);
            this.gbSignIn.Controls.Add(this.ckbHide);
            this.gbSignIn.Controls.Add(this.txtTK);
            this.gbSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSignIn.Location = new System.Drawing.Point(386, 73);
            this.gbSignIn.Name = "gbSignIn";
            this.gbSignIn.Size = new System.Drawing.Size(639, 380);
            this.gbSignIn.TabIndex = 1;
            this.gbSignIn.TabStop = false;
            this.gbSignIn.Text = "Thông tin tài khoản";
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(179, 217);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '•';
            this.txtMK.ShortcutsEnabled = false;
            this.txtMK.Size = new System.Drawing.Size(411, 35);
            this.txtMK.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(179, 302);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(128, 48);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            // 
            // ckbHide
            // 
            this.ckbHide.AutoSize = true;
            this.ckbHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHide.Location = new System.Drawing.Point(467, 275);
            this.ckbHide.Name = "ckbHide";
            this.ckbHide.Size = new System.Drawing.Size(114, 20);
            this.ckbHide.TabIndex = 2;
            this.ckbHide.Text = "Hiện mật khẩu";
            this.ckbHide.UseVisualStyleBackColor = true;
            this.ckbHide.CheckedChanged += new System.EventHandler(this.ckbHide_CheckedChanged);
            this.ckbHide.CheckStateChanged += new System.EventHandler(this.ckbHide_CheckStateChanged);
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(179, 162);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(411, 36);
            this.txtTK.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLVT.Properties.Resources.Login2__1_;
            this.pictureBox2.Location = new System.Drawing.Point(6, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 484);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QLVT.Properties.Resources.Login_key_1_;
            this.pictureBox4.Location = new System.Drawing.Point(26, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLVT.Properties.Resources.Login_user__1_;
            this.pictureBox3.Location = new System.Drawing.Point(26, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVT.Properties.Resources.Login_QLVT_xoaphong;
            this.pictureBox1.Location = new System.Drawing.Point(271, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1064, 570);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gbSignIn);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.gbSignIn.ResumeLayout(false);
            this.gbSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignIn;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.CheckBox ckbHide;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

