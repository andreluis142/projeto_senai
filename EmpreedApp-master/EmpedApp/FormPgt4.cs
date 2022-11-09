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
    public partial class FormPgt4 : Form
    {
        public FormPgt4()
        {
            InitializeComponent();
        }

        private void bntPgt4_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                FormPgt5 pgt5 = new FormPgt5();
                pgt5.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaA = r.respostaA + 1;
            }

            else if (radioBnt2.Checked == true)
            {
                FormPgt5 pgt5 = new FormPgt5();
                pgt5.ShowDialog();
                this.Dispose();
                perfil r = new perfil();
                r.respostaB = r.respostaB + 2;
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }

        private void FormPgt4_Load(object sender, EventArgs e)
        {

        }
    }
}
