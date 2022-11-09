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
    public partial class FormPgt3 : Form
    {
        public FormPgt3()
        {
            InitializeComponent();
        }

        private void radioBnt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bntPgt3_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                FormPgt4 pgt4 = new FormPgt4();
                pgt4.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaA = r.respostaA + 1;
            }

            else if (radioBnt2.Checked == true)
            { 
                FormPgt4 pgt4 = new FormPgt4();
                pgt4.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaB = r.respostaB + 2;
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }

        private void FormPgt3_Load(object sender, EventArgs e)
        {

        }
    }
}
