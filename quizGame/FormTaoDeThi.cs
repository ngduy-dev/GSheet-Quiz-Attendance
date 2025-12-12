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
    public partial class FormTaoDeThi : Form
    {
        public FormTaoDeThi()
        {
            InitializeComponent();
        }

        private void btnTructiep_Click(object sender, EventArgs e)
        {
            FormTaoDeThiTrucTiep form4 = new FormTaoDeThiTrucTiep();
            form4.Show();
        }

        private void btnGiantiep_Click(object sender, EventArgs e)
        {
            FormTaoDeThiTuFile form5 = new FormTaoDeThiTuFile();
            form5.Show();
        }
    }
}
