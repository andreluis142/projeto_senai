using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpedApp
{
    public partial class FormPgt7 : Form
    {
        public FormPgt7()
        {
            InitializeComponent();
        }

        private void bntPgt7_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                FormPgt8 pgt8 = new FormPgt8();
                pgt8.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaA = r.respostaA + 1;
            }

            else if (radioBnt2.Checked == true)
            {
                FormPgt8 pgt8 = new FormPgt8();
                pgt8.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaB = r.respostaB + 2;
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }

        private void radioBnt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBnt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPgt7_Load(object sender, EventArgs e)
        {

        }
    }
}
