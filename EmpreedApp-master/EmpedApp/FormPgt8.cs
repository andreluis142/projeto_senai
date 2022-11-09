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
    public partial class FormPgt8 : Form
    {
        public FormPgt8()
        {
            InitializeComponent();
        }

        private void bntPgt8_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                FormPgt9 pgt9 = new FormPgt9();
                pgt9.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaA = r.respostaA + 1;
            }

            else if (radioBnt2.Checked == true)
            {
                FormPgt9 pgt9 = new FormPgt9();
                pgt9.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaB = r.respostaB + 2;
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }

        private void FormPgt8_Load(object sender, EventArgs e)
        {

        }
    }
}
