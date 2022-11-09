namespace EmpedApp
{
    partial class FormPgt3
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
            this.bntPgt3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBnt2
            // 
            this.radioBnt2.AutoSize = true;
            this.radioBnt2.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt2.Location = new System.Drawing.Point(424, 325);
            this.radioBnt2.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt2.Name = "radioBnt2";
            this.radioBnt2.Size = new System.Drawing.Size(214, 33);
            this.radioBnt2.TabIndex = 8;
            this.radioBnt2.TabStop = true;
            this.radioBnt2.Text = "Sou persistente";
            this.radioBnt2.UseVisualStyleBackColor = false;
            // 
            // radioBnt1
            // 
            this.radioBnt1.AutoSize = true;
            this.radioBnt1.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt1.Location = new System.Drawing.Point(424, 290);
            this.radioBnt1.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt1.Name = "radioBnt1";
            this.radioBnt1.Size = new System.Drawing.Size(196, 33);
            this.radioBnt1.TabIndex = 7;
            this.radioBnt1.TabStop = true;
            this.radioBnt1.Text = "Sou insistente";
            this.radioBnt1.UseVisualStyleBackColor = false;
            this.radioBnt1.CheckedChanged += new System.EventHandler(this.radioBnt1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Como você lida com medo?\r\n";
            // 
            // bntPgt3
            // 
            this.bntPgt3.BackColor = System.Drawing.Color.Transparent;
            this.bntPgt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntPgt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPgt3.Location = new System.Drawing.Point(479, 491);
            this.bntPgt3.Margin = new System.Windows.Forms.Padding(2);
            this.bntPgt3.Name = "bntPgt3";
            this.bntPgt3.Size = new System.Drawing.Size(106, 75);
            this.bntPgt3.TabIndex = 0;
            this.bntPgt3.UseVisualStyleBackColor = false;
            this.bntPgt3.Click += new System.EventHandler(this.bntPgt3_Click);
            // 
            // FormPgt3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.bntPgt3);
            this.Controls.Add(this.radioBnt2);
            this.Controls.Add(this.radioBnt1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPgt3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPgt3";
            this.Load += new System.EventHandler(this.FormPgt3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBnt2;
        private System.Windows.Forms.RadioButton radioBnt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntPgt3;
    }
}