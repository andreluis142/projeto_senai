namespace App_ShowTech
{
    partial class Form1Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntStart = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntStart
            // 
            this.bntStart.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntStart.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bntStart.Location = new System.Drawing.Point(440, 499);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(180, 45);
            this.bntStart.TabIndex = 0;
            this.bntStart.Text = "START";
            this.bntStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.Red;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntExit.Location = new System.Drawing.Point(470, 571);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(120, 45);
            this.bntExit.TabIndex = 1;
            this.bntExit.Text = "EXIT";
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_ShowTech.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntStart);
            this.DoubleBuffered = true;
            this.Name = "Form1Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Tech";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bntStart;
        private Button bntExit;
    }
}