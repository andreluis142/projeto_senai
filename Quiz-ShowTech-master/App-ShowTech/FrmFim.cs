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
    public partial class FrmFim : Form
    {
        public FrmFim()
        {
            InitializeComponent();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            Form1Inicio FrmInicio = new Form1Inicio();

            FrmInicio.ShowDialog();
            this.Dispose();
        }

        private void FrmFim_Load(object sender, EventArgs e)
        {
            Variaveis Var = new Variaveis();

            labelNome.Text = Var.Nome;

            labelAcer.Text = Var.Acertos.ToString();
            labelErr.Text = Var.Erros.ToString();
        }

        private void labelAcer_Click(object sender, EventArgs e)
        {
           
        }

        private void labelErr_Click(object sender, EventArgs e)
        {
            
        }

        private void labelNome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
