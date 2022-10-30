namespace App_ShowTech
{
    partial class FrmFim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAcertos = new System.Windows.Forms.Label();
            this.labelErros = new System.Windows.Forms.Label();
            this.labelResul = new System.Windows.Forms.Label();
            this.labelAcer = new System.Windows.Forms.Label();
            this.labelErr = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.bntMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAcertos
            // 
            this.labelAcertos.AutoSize = true;
            this.labelAcertos.BackColor = System.Drawing.Color.Transparent;
            this.labelAcertos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAcertos.ForeColor = System.Drawing.Color.White;
            this.labelAcertos.Location = new System.Drawing.Point(401, 296);
            this.labelAcertos.Name = "labelAcertos";
            this.labelAcertos.Size = new System.Drawing.Size(117, 38);
            this.labelAcertos.TabIndex = 0;
            this.labelAcertos.Text = "Acertos";
            // 
            // labelErros
            // 
            this.labelErros.AutoSize = true;
            this.labelErros.BackColor = System.Drawing.Color.Transparent;
            this.labelErros.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErros.ForeColor = System.Drawing.Color.White;
            this.labelErros.Location = new System.Drawing.Point(401, 395);
            this.labelErros.Name = "labelErros";
            this.labelErros.Size = new System.Drawing.Size(83, 38);
            this.labelErros.TabIndex = 1;
            this.labelErros.Text = "Erros";
            // 
            // labelResul
            // 
            this.labelResul.AutoSize = true;
            this.labelResul.BackColor = System.Drawing.Color.Transparent;
            this.labelResul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResul.ForeColor = System.Drawing.Color.White;
            this.labelResul.Location = new System.Drawing.Point(401, 100);
            this.labelResul.Name = "labelResul";
            this.labelResul.Size = new System.Drawing.Size(174, 38);
            this.labelResul.TabIndex = 2;
            this.labelResul.Text = "RESULTADO";
            // 
            // labelAcer
            // 
            this.labelAcer.AutoSize = true;
            this.labelAcer.BackColor = System.Drawing.Color.Transparent;
            this.labelAcer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAcer.ForeColor = System.Drawing.Color.White;
            this.labelAcer.Location = new System.Drawing.Point(578, 296);
            this.labelAcer.Name = "labelAcer";
            this.labelAcer.Size = new System.Drawing.Size(33, 38);
            this.labelAcer.TabIndex = 3;
            this.labelAcer.Text = "0";
            this.labelAcer.Click += new System.EventHandler(this.labelAcer_Click);
            // 
            // labelErr
            // 
            this.labelErr.AutoSize = true;
            this.labelErr.BackColor = System.Drawing.Color.Transparent;
            this.labelErr.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErr.ForeColor = System.Drawing.Color.White;
            this.labelErr.Location = new System.Drawing.Point(578, 395);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(33, 38);
            this.labelErr.TabIndex = 4;
            this.labelErr.Text = "0";
            this.labelErr.Click += new System.EventHandler(this.labelErr_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(401, 198);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(33, 38);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "0";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // bntMenu
            // 
            this.bntMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntMenu.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bntMenu.Location = new System.Drawing.Point(421, 537);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(180, 45);
            this.bntMenu.TabIndex = 6;
            this.bntMenu.Text = "MENU";
            this.bntMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntMenu.UseVisualStyleBackColor = true;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // FrmFim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_ShowTech.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.bntMenu);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.labelAcer);
            this.Controls.Add(this.labelResul);
            this.Controls.Add(this.labelErros);
            this.Controls.Add(this.labelAcertos);
            this.DoubleBuffered = true;
            this.Name = "FrmFim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFim";
            this.Load += new System.EventHandler(this.FrmFim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAcertos;
        private Label labelErros;
        private Label labelResul;
        private Label labelAcer;
        private Label labelErr;
        private Label labelNome;
        private Button bntMenu;
    }
}