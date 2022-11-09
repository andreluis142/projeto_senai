namespace EmpedApp
{
    partial class FormPgt2
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
            this.radioBnt2 = new System.Windows.Forms.RadioButton();
            this.radioBnt1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBnt3 = new System.Windows.Forms.RadioButton();
            this.bntPgt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBnt2
            // 
            this.radioBnt2.AutoSize = true;
            this.radioBnt2.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt2.Location = new System.Drawing.Point(431, 349);
            this.radioBnt2.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt2.Name = "radioBnt2";
            this.radioBnt2.Size = new System.Drawing.Size(199, 33);
            this.radioBnt2.TabIndex = 5;
            this.radioBnt2.TabStop = true;
            this.radioBnt2.Text = "ANTISSOCIAL";
            this.radioBnt2.UseVisualStyleBackColor = false;
            // 
            // radioBnt1
            // 
            this.radioBnt1.AutoSize = true;
            this.radioBnt1.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt1.Location = new System.Drawing.Point(431, 314);
            this.radioBnt1.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt1.Name = "radioBnt1";
            this.radioBnt1.Size = new System.Drawing.Size(156, 33);
            this.radioBnt1.TabIndex = 4;
            this.radioBnt1.TabStop = true;
            this.radioBnt1.Text = "SOCIÁVEL";
            this.radioBnt1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Na pauta relacionamento, você se cosidera:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioBnt3
            // 
            this.radioBnt3.AutoSize = true;
            this.radioBnt3.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt3.Location = new System.Drawing.Point(431, 382);
            this.radioBnt3.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt3.Name = "radioBnt3";
            this.radioBnt3.Size = new System.Drawing.Size(256, 33);
            this.radioBnt3.TabIndex = 6;
            this.radioBnt3.TabStop = true;
            this.radioBnt3.Text = "POUCO SOCIÁVEL";
            this.radioBnt3.UseVisualStyleBackColor = false;
            // 
            // bntPgt2
            // 
            this.bntPgt2.BackColor = System.Drawing.Color.Transparent;
            this.bntPgt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntPgt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPgt2.Location = new System.Drawing.Point(478, 492);
            this.bntPgt2.Margin = new System.Windows.Forms.Padding(2);
            this.bntPgt2.Name = "bntPgt2";
            this.bntPgt2.Size = new System.Drawing.Size(109, 73);
            this.bntPgt2.TabIndex = 0;
            this.bntPgt2.UseVisualStyleBackColor = false;
            this.bntPgt2.Click += new System.EventHandler(this.bntPgt2_Click);
            // 
            // FormPgt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.bntPgt2);
            this.Controls.Add(this.radioBnt3);
            this.Controls.Add(this.radioBnt2);
            this.Controls.Add(this.radioBnt1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPgt2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPgt2";
            this.Load += new System.EventHandler(this.FormPgt2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBnt2;
        private System.Windows.Forms.RadioButton radioBnt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBnt3;
        private System.Windows.Forms.Button bntPgt2;
    }
}