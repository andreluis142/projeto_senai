namespace EmpedApp
{
    partial class Form2
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntcad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.DeepPink;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.Color.White;
            this.textBoxNome.Location = new System.Drawing.Point(367, 283);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(331, 25);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(422, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira seu nome";
            // 
            // bntcad
            // 
            this.bntcad.BackColor = System.Drawing.Color.Transparent;
            this.bntcad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcad.ForeColor = System.Drawing.Color.Transparent;
            this.bntcad.Location = new System.Drawing.Point(478, 411);
            this.bntcad.Margin = new System.Windows.Forms.Padding(2);
            this.bntcad.Name = "bntcad";
            this.bntcad.Size = new System.Drawing.Size(109, 75);
            this.bntcad.TabIndex = 2;
            this.bntcad.UseVisualStyleBackColor = false;
            this.bntcad.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.bntcad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntcad;
    }
}