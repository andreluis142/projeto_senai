namespace App_ShowTech
{
    partial class Form2Cad
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
            this.bntProx = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntProx
            // 
            this.bntProx.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntProx.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bntProx.Location = new System.Drawing.Point(440, 499);
            this.bntProx.Name = "bntProx";
            this.bntProx.Size = new System.Drawing.Size(180, 45);
            this.bntProx.TabIndex = 1;
            this.bntProx.Text = "Proximo";
            this.bntProx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntProx.UseVisualStyleBackColor = true;
            this.bntProx.Click += new System.EventHandler(this.bntProx_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(424, 269);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(224, 38);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Insira seu nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(424, 329);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(224, 39);
            this.textBoxNome.TabIndex = 3;
            // 
            // Form2Cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_ShowTech.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.bntProx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2Cad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2Cad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntProx;
        private Label labelNome;
        private TextBox textBoxNome;
    }
}