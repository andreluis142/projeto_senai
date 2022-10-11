using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ad_Invest_Prototipo
{
    public partial class FormPG2 : Form
    {
        private string nome;

        public string Nam1
        {
            get { return nome; }
            set { nome = value; }
        }
        public FormPG2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string nome;

            nome= textBox1.Text;

            if (nome == "Victor")
            {
                FormPG3 FPG3 = new FormPG3();

                FPG3.ShowDialog();
                this.Dispose();
            }
        }
    }
}
