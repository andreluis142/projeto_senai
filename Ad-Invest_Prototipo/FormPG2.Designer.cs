namespace Ad_Invest_Prototipo
{
    partial class FormPG2
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
            this.labelNome1 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNome1
            // 
            this.labelNome1.AutoSize = true;
            this.labelNome1.BackColor = System.Drawing.Color.Transparent;
            this.labelNome1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome1.ForeColor = System.Drawing.Color.White;
            this.labelNome1.Location = new System.Drawing.Point(269, 161);
            this.labelNome1.Name = "labelNome1";
            this.labelNome1.Size = new System.Drawing.Size(169, 25);
            this.labelNome1.TabIndex = 0;
            this.labelNome1.Text = "Insira seu nome";
            // 
            // buttonNext
            // 
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonNext.Location = new System.Drawing.Point(548, 385);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(109, 30);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Prosseguir";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(255, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormPG2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ad_Invest_Prototipo.Properties.Resources.Você___Eu__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelNome1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPG2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPG2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBox1;
    }
}