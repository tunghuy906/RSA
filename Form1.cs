using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Math;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private RsaKeyParameters publicKey;
        private RsaKeyParameters privateKey;
        private BigInteger n, e, d, r, m, blindedMessage, blindedSignature, signature;
        private BigInteger eValue;

        public Form1(string idToken)
        {
            InitializeComponent();
            this.btnLoadMessage.Click += new System.EventHandler(this.btnLoadMessage_Click);
            this.btnSaveBlindedMessage.Click += new System.EventHandler(this.btnSaveBlindedMessage_Click);
            this.btnLoadBlindedMessage.Click += new System.EventHandler(this.btnLoadBlindedMessage_Click);
            this.btnSaveBlindedSignature.Click += new System.EventHandler(this.btnSaveBlindedSignature_Click);
            this.btnLoadBlindedSignature.Click += new System.EventHandler(this.btnLoadBlindedSignature_Click);
        }

        private AsymmetricCipherKeyPair GenerateRSAKeyPair()
        {
            var keyGenerationParameters = new KeyGenerationParameters(new SecureRandom(), 2048);
            var keyPairGenerator = new RsaKeyPairGenerator();
            keyPairGenerator.Init(keyGenerationParameters);
            return keyPairGenerator.GenerateKeyPair();
        }

        // Tạo cặp khóa công khai và khóa bí mật dùng thư viện
        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            var rsaKeyPair = GenerateRSAKeyPair();
            publicKey = (RsaKeyParameters)rsaKeyPair.Public;
            privateKey = (RsaKeyParameters)rsaKeyPair.Private;

            n = publicKey.Modulus;
            eValue = publicKey.Exponent;
            d = privateKey.Exponent;

            txtPublicKey.Text = $"Public Key (n, e): ({n}, {eValue})";
            txtPrivateKey.Text = $"Private Key (d): {d}";
        }

        // Tạo số r ngẫu nhiên bên phía người Bầu cử
        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                r = new BigInteger(n.BitLength, new SecureRandom());
            } while (r.Gcd(n).CompareTo(BigInteger.One) != 0);

            txtChoseR.Text = r.ToString();
        }

        // Tải văn bản phiếu bầu cử lên
        private void btnLoadMessage_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại mở tệp
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Chọn văn bản";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc nội dung tệp vào txtMessage
                    string messageContent = File.ReadAllText(openFileDialog.FileName);
                    txtMessage.Text = messageContent;
                    MessageBox.Show("Văn bản đã được tải thành công.");
                }
            }
        }

        // Hàm để băm văn bản
        private byte[] HashMessage(string message)
        {
            var sha256 = new Sha256Digest();
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            sha256.BlockUpdate(messageBytes, 0, messageBytes.Length);
            byte[] result = new byte[sha256.GetDigestSize()];
            sha256.DoFinal(result, 0);
            return result;
        }

        // Tiến hành làm mù văn bản
        private void btnBlindMessage_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            byte[] hash = HashMessage(message);
            m = new BigInteger(1, hash); // Tạo BigInteger từ byte array với giá trị dương

            // Giả sử r đã được chọn trước đó và hiển thị trong txtChoseR
            if (string.IsNullOrEmpty(txtChoseR.Text))
            {
                MessageBox.Show("Please choose r before blinding the message.");
                return;
            }

            r = new BigInteger(txtChoseR.Text);

            blindedMessage = m.Multiply(r.ModPow(eValue, n)).Mod(n);
            txtBlindedMessage.Text = blindedMessage.ToString();
        }

        // Lưu thông điệp đã được làm mù
        private void btnSaveBlindedMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBlindedMessage.Text))
            {
                MessageBox.Show("Vui lòng mù hóa thông điệp trước khi lưu.");
                return;
            }

            // Mở hộp thoại lưu tệp
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Lưu bản mù hóa";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu thông điệp bị mù hóa vào tệp đã chọn
                    File.WriteAllText(saveFileDialog.FileName, txtBlindedMessage.Text);
                    MessageBox.Show("Thông điệp bị mù hóa đã được lưu thành công.");
                }
            }
        }

        // Gửi thông điệp đã làm mù qua bên người ký
        private void btnSendBlind_Click(object sender, EventArgs e)
        {
            txtSendBlind.Text = txtBlindedMessage.Text;
        }

        // Chọn thông điệp đã làm mù từ bên phía người bầu cử
        private void btnLoadBlindedMessage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Chọn bản mù hóa";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc nội dung tệp vào txtSendBlind
                    string blindedMessageContent = File.ReadAllText(openFileDialog.FileName);
                    txtSendBlind.Text = blindedMessageContent;
                    MessageBox.Show("Bản mù hóa đã được tải thành công.");
                }
            }
        }

        // Ký thông điệp bị làm mù từ bên phía người bầu cử gửi
        private void btnSignBlindedMessage_Click(object sender, EventArgs e)
        {
            BigInteger blindedMsg = new BigInteger(txtSendBlind.Text);

            // Ký thông điệp bị làm mù
            blindedSignature = blindedMsg.ModPow(d, n);
            txtBlindedSignature.Text = blindedSignature.ToString();
        }

        // Lưu thông điệp đã ký mù do người ký ký
        private void btnSaveBlindedSignature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBlindedSignature.Text))
            {
                MessageBox.Show("Vui lòng ký mù văn bản trước khi lưu.");
                return;
            }

            // Mở hộp thoại lưu tệp
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Lưu chữ ký mù";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu chữ ký mù vào tệp đã chọn
                    File.WriteAllText(saveFileDialog.FileName, txtBlindedSignature.Text);
                    MessageBox.Show("Chữ ký mù đã được lưu thành công.");
                }
            }
        }

        // Gửi thông điệp làm mù đã được ký qua bên người bầu cử
        private void btnSendBlindedMessage_Click(object sender, EventArgs e)
        {
            txtBlindedMessageAuthority.Text = txtBlindedSignature.Text;
        }

        // Người bầu cử chọn Bản mù đã được ký từ phía người ký
        private void btnLoadBlindedSignature_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại mở tệp
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Chọn chữ ký mù";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc nội dung tệp vào txtSignature
                    string blindedSignatureContent = File.ReadAllText(openFileDialog.FileName);
                    txtBlindedMessageAuthority.Text = blindedSignatureContent;
                    MessageBox.Show("Chữ ký mù đã được tải thành công.");
                }
            }
        }

        // Người Bầu cử tiến hành gỡ mù từ bản mù đã được ký
        private void btnUnblindSignature_Click(object sender, EventArgs e)
        {
            BigInteger blindedSig = new BigInteger(txtBlindedSignature.Text);

            // Gỡ làm mù chữ ký
            BigInteger rInverse = r.ModInverse(n);
            signature = blindedSig.Multiply(rInverse).Mod(n);
            txtSignature.Text = signature.ToString();
        }

        // Xác thực thông tin
        private void btnVerifySignature_Click(object sender, EventArgs e)
        {
            // Tính toán giá trị băm từ chữ ký đã được giải mù
            BigInteger verifiedHash = signature.ModPow(eValue, n);

            // So sánh giá trị BigInteger của thông điệp gốc (đã băm) và thông điệp đã xác thực
            bool isValid = verifiedHash.Equals(m);

            // Nếu chữ ký hợp lệ, hiển thị văn bản gốc
            if (isValid)
            {
                txtVerifiedMessage.Text = BitConverter.ToString(verifiedHash.ToByteArray()).Replace("-", "");
                txtVanBanGoc.Text = txtMessage.Text;  // Hiển thị văn bản gốc (www)
                lblSignatureValid.Text = "Valid Signature";
            }
            else
            {
                txtVanBanGoc.Text = "Thông điệp trong phiếu bầu đã bị sửa đổi";
                txtVerifiedMessage.Text = BitConverter.ToString(verifiedHash.ToByteArray()).Replace("-", "");
                lblSignatureValid.Text = "Invalid Signature";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSignature_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPrivateKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendPublicKey_Click(object sender, EventArgs e)
        {
            txtSendedPublicKey.Text = txtPublicKey.Text;
        }

        private void txtPublicKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            txtVanBanGoc.Text = "";
            txtSHA256.Text = "";
            txtSendedPublicKey.Text = "";
            txtPublicKey.Text = "";
            txtPrivateKey.Text = "";
            txtChoseR.Text = "";
            txtMessage.Text = "";
            txtBlindedMessage.Text = "";
            txtSendBlind.Text = "";
            txtBlindedSignature.Text = "";
            txtBlindedMessageAuthority.Text = "";
            txtSignature.Text = "";
            txtVerifiedMessage.Text = "";
            lblSignatureValid.Text = "";

            // Reset all variables
            publicKey = null;
            privateKey = null;
            n = BigInteger.Zero;
            eValue = BigInteger.Zero;
            d = BigInteger.Zero;
            r = BigInteger.Zero;
            m = BigInteger.Zero;
            blindedMessage = BigInteger.Zero;
            blindedSignature = BigInteger.Zero;
            signature = BigInteger.Zero;
            eValue = BigInteger.Zero;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSendedPublicKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            byte[] hash = HashMessage(message);
            string hashString = BitConverter.ToString(hash).Replace("-", "");
            txtSHA256.Text = hashString;
        }

        private void txtVanBanGoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtChoseR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSignatureValid_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMessageAndSignature_Click(object sender, EventArgs e)
        {
            txtChuKyGoMu.Text = txtSignature.Text;
            txtThongDiepGoc.Text = txtMessage.Text;
            txtBamSHA.Text=txtSHA256.Text;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void txtSendBlind_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void txtThongDiepGoc_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtChuKyGoMu_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtBamSHA_TextChanged(object sender, EventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void txtKeys_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVerifiedMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBlindedSignature_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBlindedSignature_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSignature_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
