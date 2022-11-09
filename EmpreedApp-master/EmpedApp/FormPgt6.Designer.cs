namespace EmpedApp
{
    partial class FormPgt6
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
            this.bntPgt6 = new System.Windows.Forms.Button();
            this.radioBnt2 = new System.Windows.Forms.RadioButton();
            this.radioBnt1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntPgt6
            // 
            this.bntPgt6.BackColor = System.Drawing.Color.Transparent;
            this.bntPgt6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntPgt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPgt6.Location = new System.Drawing.Point(480, 491);
            this.bntPgt6.Margin = new System.Windows.Forms.Padding(2);
            this.bntPgt6.Name = "bntPgt6";
            this.bntPgt6.Size = new System.Drawing.Size(106, 75);
            this.bntPgt6.TabIndex = 0;
            this.bntPgt6.UseVisualStyleBackColor = false;
            this.bntPgt6.Click += new System.EventHandler(this.bntPgt6_Click);
            // 
            // radioBnt2
            // 
            this.radioBnt2.AutoSize = true;
            this.radioBnt2.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt2.Location = new System.Drawing.Point(490, 361);
            this.radioBnt2.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt2.Name = "radioBnt2";
            this.radioBnt2.Size = new System.Drawing.Size(79, 33);
            this.radioBnt2.TabIndex = 12;
            this.radioBnt2.TabStop = true;
            this.radioBnt2.Text = "Não";
            this.radioBnt2.UseVisualStyleBackColor = false;
            this.radioBnt2.CheckedChanged += new System.EventHandler(this.radioBnt2_CheckedChanged);
            // 
            // radioBnt1
            // 
            this.radioBnt1.AutoSize = true;
            this.radioBnt1.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt1.Location = new System.Drawing.Point(490, 325);
            this.radioBnt1.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt1.Name = "radioBnt1";
            this.radioBnt1.Size = new System.Drawing.Size(76, 33);
            this.radioBnt1.TabIndex = 11;
            this.radioBnt1.TabStop = true;
            this.radioBnt1.Text = "Sim";
            this.radioBnt1.UseVisualStyleBackColor = false;
            this.radioBnt1.CheckedChanged += new System.EventHandler(this.radioBnt1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Você voltaria no tempo para mudar algo?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPgt6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.bntPgt6);
            this.Controls.Add(this.radioBnt2);
            this.Controls.Add(this.radioBnt1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPgt6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPgt6";
            this.Load += new System.EventHandler(this.FormPgt6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntPgt6;
        private System.Windows.Forms.RadioButton radioBnt2;
        private System.Windows.Forms.RadioButton radioBnt1;
        private System.Windows.Forms.Label label1;
    }
}