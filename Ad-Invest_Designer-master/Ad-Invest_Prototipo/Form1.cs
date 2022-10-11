using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ad_Invest_Prototipo
{
    public partial class FormPG1 : Form
    {
        public FormPG1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormPG1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPG2 FormCAd = new FormPG2();

            FormCAd.ShowDialog();
            this.Dispose();
        }
    }
}
