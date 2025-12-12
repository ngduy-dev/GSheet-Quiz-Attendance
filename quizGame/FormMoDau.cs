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
    public partial class FormMoDau : Form
    {
        public FormMoDau()
        {
            InitializeComponent();
        }


        private void FormMoDau_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateQR_Click(object sender, EventArgs e)
        {
            FormTaoMaQR form2 = new FormTaoMaQR();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTaoDeThi form3 = new FormTaoDeThi();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSheet form4 = new FormSheet();
            form4.Show();
        }
    }
}
