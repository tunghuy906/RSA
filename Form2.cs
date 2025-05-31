using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            // Kiểm tra xem hai trường nhập liệu có được điền đầy đủ hay không
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Email và Số điện thoại.");
                return;
            }

            // Kiểm tra hợp lệ của email và số điện thoại (ở đây chỉ kiểm tra đơn giản)
            // Bạn có thể thêm các kiểm tra phức tạp hơn tùy vào yêu cầu của ứng dụng

            // Nếu thông tin hợp lệ, tạo mã token
            string token = GenerateToken();

            // Hiển thị mã token lên Label
            lblToken.Text = "Mã định danh của bạn là: " + token;
        }
        private string GenerateToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Các ký tự sử dụng để sinh mã định danh
            const int length = 8; // Độ dài của chuỗi mã định danh

            // Sinh chuỗi ngẫu nhiên
            byte[] data = new byte[length];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(data);
            }

            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[data[i] % chars.Length]);
            }

            return sb.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string inputIdToken = txtMaDinhDanh.Text.Trim();

            // Lấy mã định danh đã được tạo từ sự kiện button1_Click
            string idToken = lblToken.Text.Replace("Mã định danh của bạn là: ", "").Trim();

            // Kiểm tra xem mã định danh nhập vào có trùng với mã được tạo hay không
            if (inputIdToken == idToken)
            {
                // Nếu trùng, cho phép đăng nhập vào Form1 và truyền mã định danh
                Form1 form1 = new Form1(inputIdToken);
                form1.Show();
                this.Hide(); // Ẩn Form2 sau khi đăng nhập thành công
            }
            else
            {
                // Nếu không trùng, hiển thị thông báo lỗi
                MessageBox.Show("Mã định danh không đúng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDinhDanh.Focus(); // Đưa con trỏ vào TextBox để người dùng nhập lại
            }
        }

        private void txtMaDinhDanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblToken_Click(object sender, EventArgs e)
        {

        }
    }
}
