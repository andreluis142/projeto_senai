namespace EmpedApp
{
    partial class FormPgt5
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
            this.bntPgt5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBnt2
            // 
            this.radioBnt2.AutoSize = true;
            this.radioBnt2.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt2.Location = new System.Drawing.Point(322, 337);
            this.radioBnt2.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt2.Name = "radioBnt2";
            this.radioBnt2.Size = new System.Drawing.Size(440, 33);
            this.radioBnt2.TabIndex = 8;
            this.radioBnt2.TabStop = true;
            this.radioBnt2.Text = "Tem medo de arriscar e dar errado";
            this.radioBnt2.UseVisualStyleBackColor = false;
            // 
            // radioBnt1
            // 
            this.radioBnt1.AutoSize = true;
            this.radioBnt1.BackColor = System.Drawing.Color.Transparent;
            this.radioBnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBnt1.Location = new System.Drawing.Point(322, 301);
            this.radioBnt1.Margin = new System.Windows.Forms.Padding(2);
            this.radioBnt1.Name = "radioBnt1";
            this.radioBnt1.Size = new System.Drawing.Size(412, 33);
            this.radioBnt1.TabIndex = 7;
            this.radioBnt1.TabStop = true;
            this.radioBnt1.Text = "Vai atrás sem pensar duas vezes";
            this.radioBnt1.UseVisualStyleBackColor = false;
            this.radioBnt1.CheckedChanged += new System.EventHandler(this.radioBnt1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quando você se depara com uma oportunidade:";
            // 
            // bntPgt5
            // 
            this.bntPgt5.BackColor = System.Drawing.Color.Transparent;
            this.bntPgt5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntPgt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPgt5.Location = new System.Drawing.Point(479, 491);
            this.bntPgt5.Margin = new System.Windows.Forms.Padding(2);
            this.bntPgt5.Name = "bntPgt5";
            this.bntPgt5.Size = new System.Drawing.Size(108, 75);
            this.bntPgt5.TabIndex = 0;
            this.bntPgt5.UseVisualStyleBackColor = false;
            this.bntPgt5.Click += new System.EventHandler(this.bntPgt5_Click);
            // 
            // FormPgt5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.bntPgt5);
            this.Controls.Add(this.radioBnt2);
            this.Controls.Add(this.radioBnt1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPgt5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPgt5";
            this.Load += new System.EventHandler(this.FormPgt5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBnt2;
        private System.Windows.Forms.RadioButton radioBnt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntPgt5;
    }
}