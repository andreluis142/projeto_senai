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
    public partial class Form2Cad : Form
    {
        public Form2Cad()
        {
            InitializeComponent();
        }

        private void bntProx_Click(object sender, EventArgs e)
        {
            OOP Obj = new OOP();   
            Obj.nome = textBoxNome.Text;

            if (Obj.nome == "")
            {
                MessageBox.Show("Inisra Seu Nome");
            }

            else
            {
                FrmPgt1 pgt1 = new FrmPgt1();
                pgt1.ShowDialog();
                this.Dispose();
            }
        }
    }
}
