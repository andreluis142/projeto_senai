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
    public partial class FormPgt2 : Form
    {
        public FormPgt2()
        {
            InitializeComponent();
        }

        private void bntPgt2_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                FormPgt3 pgt3 = new FormPgt3();
                pgt3.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaA = r.respostaA + 1;
            }

            else if (radioBnt2.Checked == true)
            {
                FormPgt3 pgt3 = new FormPgt3();
                pgt3.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaB = r.respostaB + 1;
            }
            
            else if (radioBnt3.Checked == true)
            {
                FormPgt3 pgt3 = new FormPgt3();
                pgt3.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaA = r.respostaA + 2;
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }

        private void FormPgt2_Load(object sender, EventArgs e)
        {

        }
    }
}
