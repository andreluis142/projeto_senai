namespace EmpedApp
{
    partial class FormPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfil));
            this.bntSair = new System.Windows.Forms.Button();
            this.bntMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.Transparent;
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.Location = new System.Drawing.Point(829, 584);
            this.bntSair.Margin = new System.Windows.Forms.Padding(2);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(163, 54);
            this.bntSair.TabIndex = 3;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntMenu
            // 
            this.bntMenu.BackColor = System.Drawing.Color.Transparent;
            this.bntMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMenu.ForeColor = System.Drawing.Color.White;
            this.bntMenu.Location = new System.Drawing.Point(72, 584);
            this.bntMenu.Margin = new System.Windows.Forms.Padding(2);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(160, 54);
            this.bntMenu.TabIndex = 4;
            this.bntMenu.Text = "Menu";
            this.bntMenu.UseVisualStyleBackColor = false;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 180);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(383, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntMenu);
            this.Controls.Add(this.bntSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPerfil";
            this.Load += new System.EventHandler(this.FormPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}