namespace EmpedApp
{
    partial class FormPgt1
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioBnt1 = new System.Windows.Forms.RadioButton();
            this.radioBnt2 = new System.Windows.Forms.RadioButton();
            this.bntPgt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você tem afinidade com a tecnologia?";
            // 
            // radioBnt1
            // 
            this.radioBnt1.AutoSize = true;
            this.radioBnt1.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt1.Location = new System.Drawing.Point(490, 316);
            this.radioBnt1.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt1.Name = "radioBnt1";
            this.radioBnt1.Size = new System.Drawing.Size(76, 33);
            this.radioBnt1.TabIndex = 1;
            this.radioBnt1.TabStop = true;
            this.radioBnt1.Text = "SIM";
            this.radioBnt1.UseVisualStyleBackColor = false;
            this.radioBnt1.CheckedChanged += new System.EventHandler(this.radioBnt1_CheckedChanged);
            // 
            // radioBnt2
            // 
            this.radioBnt2.AutoSize = true;
            this.radioBnt2.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt2.Location = new System.Drawing.Point(490, 353);
            this.radioBnt2.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt2.Name = "radioBnt2";
            this.radioBnt2.Size = new System.Drawing.Size(86, 33);
            this.radioBnt2.TabIndex = 2;
            this.radioBnt2.TabStop = true;
            this.radioBnt2.Text = "NÃO";
            this.radioBnt2.UseVisualStyleBackColor = false;
            this.radioBnt2.CheckedChanged += new System.EventHandler(this.radioBnt2_CheckedChanged);
            // 
            // bntPgt1
            // 
            this.bntPgt1.BackColor = System.Drawing.Color.Transparent;
            this.bntPgt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntPgt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPgt1.ForeColor = System.Drawing.Color.Transparent;
            this.bntPgt1.Location = new System.Drawing.Point(480, 491);
            this.bntPgt1.Margin = new System.Windows.Forms.Padding(2);
            this.bntPgt1.Name = "bntPgt1";
            this.bntPgt1.Size = new System.Drawing.Size(105, 75);
            this.bntPgt1.TabIndex = 0;
            this.bntPgt1.UseVisualStyleBackColor = false;
            this.bntPgt1.Click += new System.EventHandler(this.bntPgt1_Click);
            // 
            // FormPgt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.bntPgt1);
            this.Controls.Add(this.radioBnt2);
            this.Controls.Add(this.radioBnt1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPgt1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPgt1";
            this.Load += new System.EventHandler(this.FormPgt1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBnt1;
        private System.Windows.Forms.RadioButton radioBnt2;
        private System.Windows.Forms.Button bntPgt1;
    }
}