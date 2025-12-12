using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace quizGame
{
    public partial class FormTaoDeThiTuFile : Form
    {
        private int selectRowIndex = -1;
        private DataTable dt;
        public FormTaoDeThiTuFile()
        {
            InitializeComponent();
        }

        private bool checkInput()
        {
            return !string.IsNullOrEmpty(txtCauhoi.Text) &&
                   !string.IsNullOrEmpty(txtA.Text) &&
                   !string.IsNullOrEmpty(txtB.Text) &&
                   !string.IsNullOrEmpty(txtC.Text) &&
                   !string.IsNullOrEmpty(txtD.Text); 

        }

        private void clearInput()
        {
            txtCauhoi.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = ""; 

        }

        private void btnChonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFile.Title = "Chọn một file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                txtBrowser.Text = filePath;
                btnImport.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormTaoDeThiTuFile_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Câu hỏi");
            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");
            dt.Columns.Add("D");

            dataGridView1.DataSource = dt;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBrowser.Text))
                {
                    dt.Clear();
                    using (StreamReader sr = new StreamReader(txtBrowser.Text))
                    {
                        string line;
                        string cauHoi = "";
                        string dapAnA = "";
                        string dapAnB = "";
                        string dapAnC = "";
                        string dapAnD = "";

                        while ((line = sr.ReadLine()) != null) {
                            line = line.Trim();
                            if (!string.IsNullOrEmpty(line) && Char.IsDigit(line[0]))
                            {
                                cauHoi = line;
                            }
                            else if (line.StartsWith("A. "))
                            {
                                dapAnA = line.Substring(3);
                            }
                            else if (line.StartsWith("B. "))
                            {
                                dapAnB = line.Substring(3);
                            }
                            else if (line.StartsWith("C. "))
                            {
                                dapAnC = line.Substring(3);
                            }
                            else if (line.StartsWith("D. "))
                            {
                                dapAnD = line.Substring(3);

                                dt.Rows.Add(cauHoi, dapAnA, dapAnB, dapAnC, dapAnD);
                                cauHoi = "";
                                dapAnA = "";
                                dapAnB = "";
                                dapAnC = "";
                                dapAnD = "";
                            }
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn file txt của bạn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập file: " + ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtCauhoi.Enabled = true;
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtC.Enabled = true;
            txtD.Enabled = true;
            txtCauhoi.Focus();
            if (checkInput())
            {
                dt.Rows.Add(txtCauhoi.Text, txtA.Text, txtB.Text, txtC.Text, txtD.Text);
                clearInput();
                txtCauhoi.Enabled = false;
                txtA.Enabled = false;
                txtB.Enabled = false;
                txtC.Enabled = false;
                txtD.Enabled = false;
            }
            else
            {
                MessageBox.Show("Làm ơn nhập đầy đủ!");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dt.Rows.Count)
            {
                selectRowIndex = e.RowIndex;
                //DataRow row = dt.Rows[selectRowIndex];
                txtCauhoi.Text = dataGridView1.Rows[e.RowIndex].Cells["Câu hỏi"].Value.ToString();
                txtA.Text = dataGridView1.Rows[e.RowIndex].Cells["A"].Value.ToString();
                txtB.Text = dataGridView1.Rows[e.RowIndex].Cells["B"].Value.ToString();
                txtC.Text = dataGridView1.Rows[e.RowIndex].Cells["C"].Value.ToString();
                txtD.Text = dataGridView1.Rows[e.RowIndex].Cells["D"].Value.ToString();
            } 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtCauhoi.Enabled = true;
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtC.Enabled = true;
            txtD.Enabled = true;
            //txtCauhoi.Focus();
            if (selectRowIndex >= 0 && checkInput())
            {
                //DataRow row = dt.Rows[selectRowIndex];
                //row["Câu hỏi"] = txtCauhoi.Text;
                //row["A"] = txtA.Text;
                //row["B"] = txtB.Text;
                //row["C"] = txtC.Text;
                //row["D"] = txtD.Text;

                dataGridView1.Rows[selectRowIndex].Cells["Câu hỏi"].Value = txtCauhoi.Text;
                dataGridView1.Rows[selectRowIndex].Cells["A"].Value = txtA.Text;
                dataGridView1.Rows[selectRowIndex].Cells["B"].Value = txtB.Text;
                dataGridView1.Rows[selectRowIndex].Cells["C"].Value = txtC.Text;
                dataGridView1.Rows[selectRowIndex].Cells["D"].Value = txtD.Text;

                clearInput();
                selectRowIndex = -1;
            } 
            else
            {
                MessageBox.Show("Chọn 1 dòng để sửa và nhập đầy đủ theo yêu cầu!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectRowIndex >= 0)
            {
                dt.Rows.RemoveAt(selectRowIndex);
                clearInput();
                selectRowIndex = -1;
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để xóa.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBrowser.Text))
            {
                using (StreamWriter sw =  new StreamWriter(txtBrowser.Text))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sw.WriteLine(row["Câu hỏi"].ToString());
                        sw.WriteLine("A. " + row["A"].ToString());
                        sw.WriteLine("B. " + row["B"].ToString());
                        sw.WriteLine("C. " + row["C"].ToString());
                        sw.WriteLine("D. " + row["D"].ToString());
                        //sw.WriteLine();
                    }
                }
                MessageBox.Show("Cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Lưu không thành công.");
            }
        }
    }
}
