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
    public partial class Form1 : Form
    {
        List<Question> questions = new List<Question>();

        public class Question
        {
            public string Text {  get; set; }   
            public List<string> options {  get; set; }
        }

        public Form1 ()
        {
            InitializeComponent();
        }
        public Form1(string filePath)
        {
            InitializeComponent();
            LoadQuestion(filePath);

            if (questions.Count > 0)
            {
                askQuestion(0);
            }
        }

        private void LoadQuestion(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            Question currentQuestion = null;

            foreach (string line in lines)
            {
                if (line.Length > 2 && char.IsDigit(line[0]) && line[1] == '.')
                {
                    if (currentQuestion != null)
                    {
                        questions.Add(currentQuestion);
                    }
                    currentQuestion = new Question();
                    currentQuestion.Text = line.Substring(3);
                    currentQuestion.options = new List<string>();
                }
                else if (line.StartsWith("A. ") || line.StartsWith("B. ") || line.StartsWith("C. ") || line.StartsWith("D. "))
                {
                    currentQuestion?.options.Add(line.Substring(3));
                }
            }

            if (currentQuestion != null)
            {
                questions.Add(currentQuestion);
            }
        }

        private void askQuestion(int qnum)
        {
            if (qnum < 0 || qnum >= questions.Count)
            {
                MessageBox.Show("Không hợp lệ");
            }

            var question = questions[qnum];
            lblQuestion.Text = question.Text;
            lblA.Text = question.options[0];
            lblB.Text = question.options[1];
            lblC.Text = question.options[2];
            lblD.Text = question.options[3];
        }

        private int totalQuestion = 0;
        private int timeLeft = 15;
        private void button1_Click(object sender, EventArgs e)
        {
            questionTimer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                totalQuestion++;
                if (totalQuestion >= questions.Count)
                {
                    questionTimer.Stop();
                    DialogResult result = MessageBox.Show(
                        "Đã kết thúc phần bài làm",
                        "End Quizz",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );
                    return;
                }
                askQuestion(totalQuestion);
                timeLeft = 15;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questionTimer.Interval = 1000;


            askQuestion(0);

            timeLeft = 15;
            lblTimer.Text = timeLeft.ToString();
            questionTimer.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            questionTimer.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát?",
                "Cảnh báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation
                );
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
