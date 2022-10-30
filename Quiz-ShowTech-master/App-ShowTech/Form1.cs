namespace App_ShowTech
{
    public partial class Form1Inicio : Form
    {
        public Form1Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2Cad ForCad = new Form2Cad();
            ForCad.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}