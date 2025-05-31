namespace WindowsFormsApp2
{
    partial class Form2
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblToken = new System.Windows.Forms.Label();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.txtMaDinhDanh = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(56, 66);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(304, 58);
			this.txtEmail.TabIndex = 0;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(56, 170);
			this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPhoneNumber.Multiline = true;
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(304, 55);
			this.txtPhoneNumber.TabIndex = 1;
			this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(116, 245);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(164, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "Xác minh danh tính";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblToken
			// 
			this.lblToken.AutoSize = true;
			this.lblToken.Location = new System.Drawing.Point(123, 299);
			this.lblToken.Name = "lblToken";
			this.lblToken.Size = new System.Drawing.Size(0, 16);
			this.lblToken.TabIndex = 3;
			this.lblToken.Click += new System.EventHandler(this.lblToken_Click);
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Location = new System.Drawing.Point(468, 245);
			this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(148, 40);
			this.btnDangNhap.TabIndex = 4;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// txtMaDinhDanh
			// 
			this.txtMaDinhDanh.Location = new System.Drawing.Point(476, 182);
			this.txtMaDinhDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMaDinhDanh.Multiline = true;
			this.txtMaDinhDanh.Name = "txtMaDinhDanh";
			this.txtMaDinhDanh.Size = new System.Drawing.Size(125, 33);
			this.txtMaDinhDanh.TabIndex = 5;
			this.txtMaDinhDanh.TextChanged += new System.EventHandler(this.txtMaDinhDanh_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nhập email :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nhập số điện thoại:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(473, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nhập mã định danh:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(136, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(387, 31);
			this.label4.TabIndex = 9;
			this.label4.Text = "Trang gửi và xác thực dữ liệu";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(711, 360);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMaDinhDanh);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.lblToken);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtEmail);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMaDinhDanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}