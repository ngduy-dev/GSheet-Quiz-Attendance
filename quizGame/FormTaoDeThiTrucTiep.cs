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

namespace quizGame
{
    public partial class FormTaoDeThiTrucTiep : Form
    {
        int questionNumber = 1;
        public FormTaoDeThiTrucTiep()
        {
            InitializeComponent();
        }

        private string savedFilePath = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(savedFilePath))
            {
                saveFileDialog1.Title = "Chọn file";
                saveFileDialog1.Filter = "Text file (*.txt)|*.txt|Pdf file (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    savedFilePath = saveFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show("Bạn chưa lưu nội dung?");
                }
            }
            string allText = questionNumber.ToString() + ". " + richTextBox5.Text + Environment.NewLine +
                             "A. " + richTextBox1.Text + Environment.NewLine +
                             "B. " + richTextBox2.Text + Environment.NewLine +
                             "C. " + richTextBox3.Text + Environment.NewLine +
                             "D. " + richTextBox4.Text + Environment.NewLine;

            File.AppendAllText(saveFileDialog1.FileName, allText);
            DisplayDataInDataGridView(allText);
            questionNumber++;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
        }

        private void DisplayDataInDataGridView(string content)
        {
            string[] lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string question = "";
            string orderNumber = "";
            string answerA = "";
            string answerB = "";
            string answerC = "";
            string answerD = "";

            foreach (string line in lines)
            {
                if (line.Length > 2 && char.IsDigit(line[0]) && line[1] == '.')
                {
                    int dotIndex = line.IndexOf('.');
                    orderNumber = line.Substring(0, dotIndex).Trim();  
                    question = line.Substring(dotIndex + 1).Trim();  

                    //question = line.Substring(3).Trim(); // Loại bỏ số và dấu chấm, lấy câu hỏi
                }
                else if (line.StartsWith("A. "))  
                {
                    answerA = line.Substring(3).Trim();
                }
                else if (line.StartsWith("B. "))  
                {
                    answerB = line.Substring(3).Trim();
                }
                else if (line.StartsWith("C. "))  
                {
                    answerC = line.Substring(3).Trim();
                }
                else if (line.StartsWith("D. "))  
                {
                    answerD = line.Substring(3).Trim(); 
                }

                if (!string.IsNullOrEmpty(question) && !string.IsNullOrEmpty(answerA) &&
                    !string.IsNullOrEmpty(answerB) && !string.IsNullOrEmpty(answerC) && !string.IsNullOrEmpty(answerD))
                {
                    dataGridView1.Rows.Add(orderNumber, question, answerA, answerB, answerC, answerD);

                    question = "";
                    answerA = "";
                    answerB = "";
                    answerC = "";
                    answerD = "";
                }
                

                
            }
        }
        private void FormTaoDeThiTrucTiep_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("QuestionNumber", "Số thứ tự");
            dataGridView1.Columns.Add("Question", "Câu hỏi");
            dataGridView1.Columns.Add("AnswerA", "Đáp án A");
            dataGridView1.Columns.Add("AnswerB", "Đáp án B");
            dataGridView1.Columns.Add("AnswerC", "Đáp án C");
            dataGridView1.Columns.Add("AnswerD", "Đáp án D");
        }
    }
}
