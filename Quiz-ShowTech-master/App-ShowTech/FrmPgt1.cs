using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ShowTech
{
    public partial class FrmPgt1 : Form
    {
        public FrmPgt1()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntProx_Click(object sender, EventArgs e)
        {
            bntProx_Click(sender, e, radioBntC);
        }

        private void bntProx_Click(object sender, EventArgs e, RadioButton radioBntC)
        {
            if (radioBntC.Checked == true)
            {
                MessageBox.Show("Resposta Correta");

                OOP obj= new OOP();
                obj.acertos += 1;

                FrmPgt2 pgt2 = new FrmPgt2();
                pgt2.ShowDialog();
                this.Dispose();

            }

            else if (radioBntF.Checked || radioBntF2.Checked || radioBntF3.Checked)
            {
                MessageBox.Show("Resposta Inorreta");

                OOP obj = new OOP();
                obj.erros += 1;

                FrmPgt2 pgt2 = new FrmPgt2();
                pgt2.ShowDialog();
                this.Dispose();
            }      

            else
            {
                MessageBox.Show("Marque uma alternativa");
            }
            
        }

        private void FrmPgt1_Load(object sender, EventArgs e)
        {
            OOP obj = new OOP();
            obj.acertos = 0 ;
            obj.erros = 0 ;
        }

        private void radioBntC_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
