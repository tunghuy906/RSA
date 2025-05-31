namespace WindowsFormsApp2
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
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtBlindedMessage = new System.Windows.Forms.TextBox();
			this.txtBlindedSignature = new System.Windows.Forms.TextBox();
			this.txtBlindedMessageAuthority = new System.Windows.Forms.TextBox();
			this.txtSignature = new System.Windows.Forms.TextBox();
			this.txtVerifiedMessage = new System.Windows.Forms.TextBox();
			this.lblSignatureValid = new System.Windows.Forms.Label();
			this.btnGenerateKeys = new System.Windows.Forms.Button();
			this.btnBlindMessage = new System.Windows.Forms.Button();
			this.btnSignBlindedMessage = new System.Windows.Forms.Button();
			this.btnSendBlindedMessage = new System.Windows.Forms.Button();
			this.btnUnblindSignature = new System.Windows.Forms.Button();
			this.btnVerifySignature = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSendBlind = new System.Windows.Forms.Button();
			this.txtSendBlind = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtChoseR = new System.Windows.Forms.TextBox();
			this.txtPublicKey = new System.Windows.Forms.TextBox();
			this.txtPrivateKey = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnSaveBlindedMessage = new System.Windows.Forms.Button();
			this.btnLoadBlindedMessage = new System.Windows.Forms.Button();
			this.btnSaveBlindedSignature = new System.Windows.Forms.Button();
			this.btnLoadBlindedSignature = new System.Windows.Forms.Button();
			this.btnLoadMessage = new System.Windows.Forms.Button();
			this.btnSendPublicKey = new System.Windows.Forms.Button();
			this.txtSendedPublicKey = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtSHA256 = new System.Windows.Forms.TextBox();
			this.btnHash = new System.Windows.Forms.Button();
			this.txtVanBanGoc = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btnSendMessageAndSignature = new System.Windows.Forms.Button();
			this.txtThongDiepGoc = new System.Windows.Forms.TextBox();
			this.txtChuKyGoMu = new System.Windows.Forms.TextBox();
			this.txtBamSHA = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(533, 217);
			this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(337, 64);
			this.txtMessage.TabIndex = 1;
			this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
			// 
			// txtBlindedMessage
			// 
			this.txtBlindedMessage.Location = new System.Drawing.Point(900, 236);
			this.txtBlindedMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBlindedMessage.Multiline = true;
			this.txtBlindedMessage.Name = "txtBlindedMessage";
			this.txtBlindedMessage.Size = new System.Drawing.Size(314, 143);
			this.txtBlindedMessage.TabIndex = 2;
			this.txtBlindedMessage.TextChanged += new System.EventHandler(this.txtBlindedSignature_TextChanged);
			// 
			// txtBlindedSignature
			// 
			this.txtBlindedSignature.Location = new System.Drawing.Point(22, 650);
			this.txtBlindedSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBlindedSignature.Multiline = true;
			this.txtBlindedSignature.Name = "txtBlindedSignature";
			this.txtBlindedSignature.Size = new System.Drawing.Size(450, 119);
			this.txtBlindedSignature.TabIndex = 3;
			this.txtBlindedSignature.TextChanged += new System.EventHandler(this.txtBlindedSignature_TextChanged_1);
			// 
			// txtBlindedMessageAuthority
			// 
			this.txtBlindedMessageAuthority.Location = new System.Drawing.Point(533, 447);
			this.txtBlindedMessageAuthority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBlindedMessageAuthority.Multiline = true;
			this.txtBlindedMessageAuthority.Name = "txtBlindedMessageAuthority";
			this.txtBlindedMessageAuthority.Size = new System.Drawing.Size(680, 127);
			this.txtBlindedMessageAuthority.TabIndex = 4;
			this.txtBlindedMessageAuthority.TextChanged += new System.EventHandler(this.txtSignature_TextChanged);
			// 
			// txtSignature
			// 
			this.txtSignature.Location = new System.Drawing.Point(533, 648);
			this.txtSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSignature.Multiline = true;
			this.txtSignature.Name = "txtSignature";
			this.txtSignature.Size = new System.Drawing.Size(680, 121);
			this.txtSignature.TabIndex = 5;
			this.txtSignature.TextChanged += new System.EventHandler(this.txtSignature_TextChanged_1);
			// 
			// txtVerifiedMessage
			// 
			this.txtVerifiedMessage.Location = new System.Drawing.Point(1287, 648);
			this.txtVerifiedMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtVerifiedMessage.Multiline = true;
			this.txtVerifiedMessage.Name = "txtVerifiedMessage";
			this.txtVerifiedMessage.Size = new System.Drawing.Size(271, 69);
			this.txtVerifiedMessage.TabIndex = 6;
			this.txtVerifiedMessage.TextChanged += new System.EventHandler(this.txtVerifiedMessage_TextChanged);
			// 
			// lblSignatureValid
			// 
			this.lblSignatureValid.AutoSize = true;
			this.lblSignatureValid.ForeColor = System.Drawing.Color.Red;
			this.lblSignatureValid.Location = new System.Drawing.Point(1348, 614);
			this.lblSignatureValid.Name = "lblSignatureValid";
			this.lblSignatureValid.Size = new System.Drawing.Size(124, 16);
			this.lblSignatureValid.TabIndex = 7;
			this.lblSignatureValid.Text = "Thông báo xác thực";
			this.lblSignatureValid.Click += new System.EventHandler(this.lblSignatureValid_Click);
			// 
			// btnGenerateKeys
			// 
			this.btnGenerateKeys.Location = new System.Drawing.Point(22, 389);
			this.btnGenerateKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGenerateKeys.Name = "btnGenerateKeys";
			this.btnGenerateKeys.Size = new System.Drawing.Size(88, 32);
			this.btnGenerateKeys.TabIndex = 8;
			this.btnGenerateKeys.Text = "Tạo khóa";
			this.btnGenerateKeys.UseVisualStyleBackColor = true;
			this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
			// 
			// btnBlindMessage
			// 
			this.btnBlindMessage.Location = new System.Drawing.Point(659, 383);
			this.btnBlindMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBlindMessage.Name = "btnBlindMessage";
			this.btnBlindMessage.Size = new System.Drawing.Size(88, 36);
			this.btnBlindMessage.TabIndex = 9;
			this.btnBlindMessage.Text = "Ký dữ liệu";
			this.btnBlindMessage.UseVisualStyleBackColor = true;
			this.btnBlindMessage.Click += new System.EventHandler(this.btnBlindMessage_Click);
			// 
			// btnSignBlindedMessage
			// 
			this.btnSignBlindedMessage.Location = new System.Drawing.Point(22, 580);
			this.btnSignBlindedMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSignBlindedMessage.Name = "btnSignBlindedMessage";
			this.btnSignBlindedMessage.Size = new System.Drawing.Size(88, 36);
			this.btnSignBlindedMessage.TabIndex = 10;
			this.btnSignBlindedMessage.Text = "Ký dữ liệu";
			this.btnSignBlindedMessage.UseVisualStyleBackColor = true;
			this.btnSignBlindedMessage.Click += new System.EventHandler(this.btnSignBlindedMessage_Click);
			// 
			// btnSendBlindedMessage
			// 
			this.btnSendBlindedMessage.Location = new System.Drawing.Point(22, 773);
			this.btnSendBlindedMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSendBlindedMessage.Name = "btnSendBlindedMessage";
			this.btnSendBlindedMessage.Size = new System.Drawing.Size(88, 36);
			this.btnSendBlindedMessage.TabIndex = 11;
			this.btnSendBlindedMessage.Text = "Gửi dữ liệu";
			this.btnSendBlindedMessage.UseVisualStyleBackColor = true;
			this.btnSendBlindedMessage.Click += new System.EventHandler(this.btnSendBlindedMessage_Click);
			// 
			// btnUnblindSignature
			// 
			this.btnUnblindSignature.Location = new System.Drawing.Point(533, 578);
			this.btnUnblindSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUnblindSignature.Name = "btnUnblindSignature";
			this.btnUnblindSignature.Size = new System.Drawing.Size(88, 36);
			this.btnUnblindSignature.TabIndex = 12;
			this.btnUnblindSignature.Text = " Kiểm tra chữ ký";
			this.btnUnblindSignature.UseVisualStyleBackColor = true;
			this.btnUnblindSignature.Click += new System.EventHandler(this.btnUnblindSignature_Click);
			// 
			// btnVerifySignature
			// 
			this.btnVerifySignature.Location = new System.Drawing.Point(1287, 554);
			this.btnVerifySignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVerifySignature.Name = "btnVerifySignature";
			this.btnVerifySignature.Size = new System.Drawing.Size(88, 36);
			this.btnVerifySignature.TabIndex = 13;
			this.btnVerifySignature.Text = "Xác minh toàn vẹn";
			this.btnVerifySignature.UseVisualStyleBackColor = true;
			this.btnVerifySignature.Click += new System.EventHandler(this.btnVerifySignature_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(417, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 31);
			this.label1.TabIndex = 14;
			this.label1.Text = "Người gửi dữ liệu";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnSendBlind
			// 
			this.btnSendBlind.Location = new System.Drawing.Point(900, 388);
			this.btnSendBlind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSendBlind.Name = "btnSendBlind";
			this.btnSendBlind.Size = new System.Drawing.Size(145, 34);
			this.btnSendBlind.TabIndex = 15;
			this.btnSendBlind.Text = "Gửi dữ liệu";
			this.btnSendBlind.UseVisualStyleBackColor = true;
			this.btnSendBlind.Click += new System.EventHandler(this.btnSendBlind_Click);
			// 
			// txtSendBlind
			// 
			this.txtSendBlind.Location = new System.Drawing.Point(22, 449);
			this.txtSendBlind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSendBlind.Multiline = true;
			this.txtSendBlind.Name = "txtSendBlind";
			this.txtSendBlind.Size = new System.Drawing.Size(450, 127);
			this.txtSendBlind.TabIndex = 16;
			this.txtSendBlind.TextChanged += new System.EventHandler(this.txtSendBlind_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(533, 157);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 39);
			this.button1.TabIndex = 17;
			this.button1.Text = "Chọn r ngẫu nhiên";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtChoseR
			// 
			this.txtChoseR.Location = new System.Drawing.Point(717, 157);
			this.txtChoseR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtChoseR.Multiline = true;
			this.txtChoseR.Name = "txtChoseR";
			this.txtChoseR.Size = new System.Drawing.Size(153, 40);
			this.txtChoseR.TabIndex = 18;
			this.txtChoseR.TextChanged += new System.EventHandler(this.txtChoseR_TextChanged);
			// 
			// txtPublicKey
			// 
			this.txtPublicKey.Location = new System.Drawing.Point(188, 158);
			this.txtPublicKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPublicKey.Multiline = true;
			this.txtPublicKey.Name = "txtPublicKey";
			this.txtPublicKey.Size = new System.Drawing.Size(284, 97);
			this.txtPublicKey.TabIndex = 19;
			this.txtPublicKey.TextChanged += new System.EventHandler(this.txtPublicKey_TextChanged);
			// 
			// txtPrivateKey
			// 
			this.txtPrivateKey.Location = new System.Drawing.Point(188, 277);
			this.txtPrivateKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrivateKey.Multiline = true;
			this.txtPrivateKey.Name = "txtPrivateKey";
			this.txtPrivateKey.Size = new System.Drawing.Size(284, 104);
			this.txtPrivateKey.TabIndex = 20;
			this.txtPrivateKey.TextChanged += new System.EventHandler(this.txtPrivateKey_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(19, 314);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 21;
			this.label3.Text = "Khóa bí mật:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(19, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Khóa công khai:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(533, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 16);
			this.label5.TabIndex = 22;
			this.label5.Text = "\tNhập nội dung dữ liệu cần gửi";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(896, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 16);
			this.label6.TabIndex = 23;
			this.label6.Text = "Dữ liệu đã được ký:";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(533, 429);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 16);
			this.label7.TabIndex = 24;
			this.label7.Text = "Dữ liệu đã được ký";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(533, 630);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(154, 16);
			this.label8.TabIndex = 25;
			this.label8.Text = "Dữ liệu gốc sau xác minh";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(19, 430);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 16);
			this.label9.TabIndex = 26;
			this.label9.Text = "Dữ liệu gốc";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(19, 631);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 16);
			this.label10.TabIndex = 27;
			this.label10.Text = "Chữ ký số đã tạo:";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label11.Location = new System.Drawing.Point(69, 26);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(1481, 42);
			this.label11.TabIndex = 28;
			this.label11.Text = "CHƯƠNG TRÌNH DEMO CHỮ KÝ SỐ RSA TRONG KIỂM TRA TOÀN VẸN DỮ LIỆU";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// btnSaveBlindedMessage
			// 
			this.btnSaveBlindedMessage.Location = new System.Drawing.Point(1067, 385);
			this.btnSaveBlindedMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSaveBlindedMessage.Name = "btnSaveBlindedMessage";
			this.btnSaveBlindedMessage.Size = new System.Drawing.Size(133, 34);
			this.btnSaveBlindedMessage.TabIndex = 29;
			this.btnSaveBlindedMessage.Text = "Lưu chữ ký";
			this.btnSaveBlindedMessage.UseVisualStyleBackColor = true;
			this.btnSaveBlindedMessage.Click += new System.EventHandler(this.btnSaveBlindedMessage_Click);
			// 
			// btnLoadBlindedMessage
			// 
			this.btnLoadBlindedMessage.Location = new System.Drawing.Point(130, 580);
			this.btnLoadBlindedMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLoadBlindedMessage.Name = "btnLoadBlindedMessage";
			this.btnLoadBlindedMessage.Size = new System.Drawing.Size(141, 36);
			this.btnLoadBlindedMessage.TabIndex = 30;
			this.btnLoadBlindedMessage.Text = "Chọn file";
			this.btnLoadBlindedMessage.UseVisualStyleBackColor = true;
			this.btnLoadBlindedMessage.Click += new System.EventHandler(this.btnLoadBlindedMessage_Click);
			// 
			// btnSaveBlindedSignature
			// 
			this.btnSaveBlindedSignature.Location = new System.Drawing.Point(145, 774);
			this.btnSaveBlindedSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSaveBlindedSignature.Name = "btnSaveBlindedSignature";
			this.btnSaveBlindedSignature.Size = new System.Drawing.Size(136, 35);
			this.btnSaveBlindedSignature.TabIndex = 31;
			this.btnSaveBlindedSignature.Text = "Lưu chữ ký";
			this.btnSaveBlindedSignature.UseVisualStyleBackColor = true;
			this.btnSaveBlindedSignature.Click += new System.EventHandler(this.btnSaveBlindedSignature_Click);
			// 
			// btnLoadBlindedSignature
			// 
			this.btnLoadBlindedSignature.Location = new System.Drawing.Point(650, 579);
			this.btnLoadBlindedSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLoadBlindedSignature.Name = "btnLoadBlindedSignature";
			this.btnLoadBlindedSignature.Size = new System.Drawing.Size(129, 35);
			this.btnLoadBlindedSignature.TabIndex = 32;
			this.btnLoadBlindedSignature.Text = "Chọn chữ ký từ file";
			this.btnLoadBlindedSignature.UseVisualStyleBackColor = true;
			this.btnLoadBlindedSignature.Click += new System.EventHandler(this.btnLoadBlindedSignature_Click);
			// 
			// btnLoadMessage
			// 
			this.btnLoadMessage.Location = new System.Drawing.Point(744, 285);
			this.btnLoadMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLoadMessage.Name = "btnLoadMessage";
			this.btnLoadMessage.Size = new System.Drawing.Size(126, 36);
			this.btnLoadMessage.TabIndex = 33;
			this.btnLoadMessage.Text = "Tải phiếu bầu";
			this.btnLoadMessage.UseVisualStyleBackColor = true;
			this.btnLoadMessage.Click += new System.EventHandler(this.btnLoadMessage_Click);
			// 
			// btnSendPublicKey
			// 
			this.btnSendPublicKey.Location = new System.Drawing.Point(188, 389);
			this.btnSendPublicKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSendPublicKey.Name = "btnSendPublicKey";
			this.btnSendPublicKey.Size = new System.Drawing.Size(171, 32);
			this.btnSendPublicKey.TabIndex = 34;
			this.btnSendPublicKey.Text = "Gửi khóa công khai";
			this.btnSendPublicKey.UseVisualStyleBackColor = true;
			this.btnSendPublicKey.Click += new System.EventHandler(this.btnSendPublicKey_Click);
			// 
			// txtSendedPublicKey
			// 
			this.txtSendedPublicKey.Location = new System.Drawing.Point(898, 158);
			this.txtSendedPublicKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSendedPublicKey.Multiline = true;
			this.txtSendedPublicKey.Name = "txtSendedPublicKey";
			this.txtSendedPublicKey.Size = new System.Drawing.Size(316, 38);
			this.txtSendedPublicKey.TabIndex = 35;
			this.txtSendedPublicKey.TextChanged += new System.EventHandler(this.txtSendedPublicKey_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.Brown;
			this.label12.Location = new System.Drawing.Point(896, 140);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 16);
			this.label12.TabIndex = 36;
			this.label12.Text = "Public Key:";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnReset.Location = new System.Drawing.Point(1287, 772);
			this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(132, 42);
			this.btnReset.TabIndex = 37;
			this.btnReset.Text = "RESET";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnExit.Location = new System.Drawing.Point(1424, 772);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(133, 43);
			this.btnExit.TabIndex = 38;
			this.btnExit.Text = "THOÁT";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtSHA256
			// 
			this.txtSHA256.Location = new System.Drawing.Point(533, 334);
			this.txtSHA256.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSHA256.Multiline = true;
			this.txtSHA256.Name = "txtSHA256";
			this.txtSHA256.Size = new System.Drawing.Size(337, 46);
			this.txtSHA256.TabIndex = 40;
			this.txtSHA256.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnHash
			// 
			this.btnHash.Location = new System.Drawing.Point(533, 384);
			this.btnHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnHash.Name = "btnHash";
			this.btnHash.Size = new System.Drawing.Size(109, 36);
			this.btnHash.TabIndex = 41;
			this.btnHash.Text = "Băm dữ liệu";
			this.btnHash.UseVisualStyleBackColor = true;
			this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
			// 
			// txtVanBanGoc
			// 
			this.txtVanBanGoc.ForeColor = System.Drawing.Color.Red;
			this.txtVanBanGoc.Location = new System.Drawing.Point(1287, 730);
			this.txtVanBanGoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtVanBanGoc.Multiline = true;
			this.txtVanBanGoc.Name = "txtVanBanGoc";
			this.txtVanBanGoc.Size = new System.Drawing.Size(271, 37);
			this.txtVanBanGoc.TabIndex = 42;
			this.txtVanBanGoc.TextChanged += new System.EventHandler(this.txtVanBanGoc_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(533, 315);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(59, 16);
			this.label13.TabIndex = 43;
			this.label13.Text = "Mã băm:";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label14.Location = new System.Drawing.Point(1292, 104);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(211, 29);
			this.label14.TabIndex = 44;
			this.label14.Text = "Cơ quan xác thực";
			this.label14.Click += new System.EventHandler(this.label14_Click);
			// 
			// btnSendMessageAndSignature
			// 
			this.btnSendMessageAndSignature.Location = new System.Drawing.Point(533, 776);
			this.btnSendMessageAndSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSendMessageAndSignature.Name = "btnSendMessageAndSignature";
			this.btnSendMessageAndSignature.Size = new System.Drawing.Size(244, 36);
			this.btnSendMessageAndSignature.TabIndex = 45;
			this.btnSendMessageAndSignature.Text = "Gửi dữ liệu và chữ ký";
			this.btnSendMessageAndSignature.UseVisualStyleBackColor = true;
			this.btnSendMessageAndSignature.Click += new System.EventHandler(this.btnSendMessageAndSignature_Click);
			// 
			// txtThongDiepGoc
			// 
			this.txtThongDiepGoc.Location = new System.Drawing.Point(1287, 158);
			this.txtThongDiepGoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtThongDiepGoc.Multiline = true;
			this.txtThongDiepGoc.Name = "txtThongDiepGoc";
			this.txtThongDiepGoc.Size = new System.Drawing.Size(265, 97);
			this.txtThongDiepGoc.TabIndex = 46;
			this.txtThongDiepGoc.TextChanged += new System.EventHandler(this.txtThongDiepGoc_TextChanged);
			// 
			// txtChuKyGoMu
			// 
			this.txtChuKyGoMu.Location = new System.Drawing.Point(1287, 430);
			this.txtChuKyGoMu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtChuKyGoMu.Multiline = true;
			this.txtChuKyGoMu.Name = "txtChuKyGoMu";
			this.txtChuKyGoMu.Size = new System.Drawing.Size(265, 109);
			this.txtChuKyGoMu.TabIndex = 47;
			this.txtChuKyGoMu.TextChanged += new System.EventHandler(this.txtChuKyGoMu_TextChanged);
			// 
			// txtBamSHA
			// 
			this.txtBamSHA.Location = new System.Drawing.Point(1287, 288);
			this.txtBamSHA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBamSHA.Multiline = true;
			this.txtBamSHA.Name = "txtBamSHA";
			this.txtBamSHA.Size = new System.Drawing.Size(265, 93);
			this.txtBamSHA.TabIndex = 48;
			this.txtBamSHA.TextChanged += new System.EventHandler(this.txtBamSHA_TextChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(1284, 140);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(105, 16);
			this.label15.TabIndex = 49;
			this.label15.Text = "Thông điệp gốc ";
			this.label15.Click += new System.EventHandler(this.label15_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.ForeColor = System.Drawing.Color.Red;
			this.label16.Location = new System.Drawing.Point(1284, 270);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(59, 16);
			this.label16.TabIndex = 50;
			this.label16.Text = "Mã băm:";
			this.label16.Click += new System.EventHandler(this.label16_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(1284, 412);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(68, 16);
			this.label17.TabIndex = 51;
			this.label17.Text = "Chữ ký số:";
			this.label17.Click += new System.EventHandler(this.label17_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1588, 840);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtBamSHA);
			this.Controls.Add(this.txtChuKyGoMu);
			this.Controls.Add(this.txtThongDiepGoc);
			this.Controls.Add(this.btnSendMessageAndSignature);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtVanBanGoc);
			this.Controls.Add(this.btnHash);
			this.Controls.Add(this.txtSHA256);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtSendedPublicKey);
			this.Controls.Add(this.btnSendPublicKey);
			this.Controls.Add(this.btnLoadMessage);
			this.Controls.Add(this.btnLoadBlindedSignature);
			this.Controls.Add(this.btnSaveBlindedSignature);
			this.Controls.Add(this.btnLoadBlindedMessage);
			this.Controls.Add(this.btnSaveBlindedMessage);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPrivateKey);
			this.Controls.Add(this.txtPublicKey);
			this.Controls.Add(this.txtChoseR);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtSendBlind);
			this.Controls.Add(this.btnSendBlind);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVerifySignature);
			this.Controls.Add(this.btnUnblindSignature);
			this.Controls.Add(this.btnSendBlindedMessage);
			this.Controls.Add(this.btnSignBlindedMessage);
			this.Controls.Add(this.btnBlindMessage);
			this.Controls.Add(this.btnGenerateKeys);
			this.Controls.Add(this.lblSignatureValid);
			this.Controls.Add(this.txtVerifiedMessage);
			this.Controls.Add(this.txtSignature);
			this.Controls.Add(this.txtBlindedMessageAuthority);
			this.Controls.Add(this.txtBlindedSignature);
			this.Controls.Add(this.txtBlindedMessage);
			this.Controls.Add(this.txtMessage);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtBlindedMessage;
        private System.Windows.Forms.TextBox txtBlindedSignature;
        private System.Windows.Forms.TextBox txtBlindedMessageAuthority;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.TextBox txtVerifiedMessage;
        private System.Windows.Forms.Label lblSignatureValid;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnBlindMessage;
        private System.Windows.Forms.Button btnSignBlindedMessage;
        private System.Windows.Forms.Button btnSendBlindedMessage;
        private System.Windows.Forms.Button btnUnblindSignature;
        private System.Windows.Forms.Button btnVerifySignature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendBlind;
        private System.Windows.Forms.TextBox txtSendBlind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChoseR;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveBlindedMessage;
        private System.Windows.Forms.Button btnLoadBlindedMessage;
        private System.Windows.Forms.Button btnSaveBlindedSignature;
        private System.Windows.Forms.Button btnLoadBlindedSignature;
        private System.Windows.Forms.Button btnLoadMessage;
        private System.Windows.Forms.Button btnSendPublicKey;
        private System.Windows.Forms.TextBox txtSendedPublicKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.TextBox txtVanBanGoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSendMessageAndSignature;
        private System.Windows.Forms.TextBox txtThongDiepGoc;
        private System.Windows.Forms.TextBox txtChuKyGoMu;
        private System.Windows.Forms.TextBox txtBamSHA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

