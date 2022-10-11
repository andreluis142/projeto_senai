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
    public partial class FormPG3 : Form
    {
        public FormPG3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void FormPG3_Load(object sender, EventArgs e)
        {
            FormPG2 For2 = new FormPG2();

            For2.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
