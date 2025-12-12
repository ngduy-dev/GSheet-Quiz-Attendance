using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class FormTaoMaQR : Form
    {
        public FormTaoMaQR()
        {
            InitializeComponent();
        }

        private string filePath = null;

        private void btnTaoQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCode qRCode = new QRCode(qRCodeGenerator.CreateQrCode(txtTaoQR.Text, QRCodeGenerator.ECCLevel.Q));
            pictureTaoQR.Image = qRCode.GetGraphic(2, Color.Blue, Color.White, false);
            qRCodeGenerator.Dispose();
            qRCode.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Vui lòng chọn file trước khi bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập thời gian lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int timeLeft = (int)numericUpDown1.Value;
            Form1 form1 = new Form1(filePath);
            form1.timeValue = timeLeft;
            form1.Show();
        }

        private void btnChonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFile.Title = "Chọn một file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                txtChonfile.Text = filePath;
            }
        }
    }
}
