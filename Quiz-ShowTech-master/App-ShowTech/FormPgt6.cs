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
    public partial class FormPgt6 : Form
    {
        public FormPgt6()
        {
            InitializeComponent();
        }

        private void bntProx_Click(object sender, EventArgs e)
        {
            if (radioBntF2.Checked == true)
            {
                MessageBox.Show("Resposta Correta");

                OOP obj = new OOP();
                obj.acertos += 1;

                FrmPgt2 pgt2 = new FrmPgt2();
                pgt2.ShowDialog();
                this.Dispose();

            }

            else if (radioBntF.Checked || radioBntC.Checked || radioBntF3.Checked)
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

        private void FormPgt6_Load(object sender, EventArgs e)
        {
            OOP obj = new OOP();
            obj.acertos = 0;
            obj.erros = 0;
        }
    }
}
