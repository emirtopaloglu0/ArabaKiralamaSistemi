namespace AracKiralama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.BrandName_Label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginPanel2 = new AracKiralama.View.LoginPanel();
            this.userPanel2 = new AracKiralama.View.UserPanel();
            this.adminPanel2 = new AracKiralama.View.AdminPanel();
            this.Zaman_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.BrandName_Label);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 70);
            this.panel1.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::AracKiralama.Properties.Resources.close;
            this.ExitButton.Location = new System.Drawing.Point(1273, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(63, 66);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BrandName_Label
            // 
            this.BrandName_Label.AutoSize = true;
            this.BrandName_Label.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandName_Label.Location = new System.Drawing.Point(106, 16);
            this.BrandName_Label.Name = "BrandName_Label";
            this.BrandName_Label.Size = new System.Drawing.Size(160, 39);
            this.BrandName_Label.TabIndex = 2;
            this.BrandName_Label.Text = "VASITAM.COM";
            this.BrandName_Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AracKiralama.Properties.Resources.rental_car;
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginPanel2);
            this.panel2.Controls.Add(this.userPanel2);
            this.panel2.Controls.Add(this.adminPanel2);
            this.panel2.Location = new System.Drawing.Point(3, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1343, 629);
            this.panel2.TabIndex = 3;
            // 
            // loginPanel2
            // 
            this.loginPanel2.Location = new System.Drawing.Point(0, 3);
            this.loginPanel2.Name = "loginPanel2";
            this.loginPanel2.Size = new System.Drawing.Size(1343, 626);
            this.loginPanel2.TabIndex = 2;
            // 
            // userPanel2
            // 
            this.userPanel2.Location = new System.Drawing.Point(0, 3);
            this.userPanel2.Name = "userPanel2";
            this.userPanel2.Size = new System.Drawing.Size(1343, 626);
            this.userPanel2.TabIndex = 1;
            // 
            // adminPanel2
            // 
            this.adminPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminPanel2.Location = new System.Drawing.Point(0, 3);
            this.adminPanel2.Name = "adminPanel2";
            this.adminPanel2.Size = new System.Drawing.Size(1343, 626);
            this.adminPanel2.TabIndex = 0;
            // 
            // Zaman_Label
            // 
            this.Zaman_Label.AutoSize = true;
            this.Zaman_Label.Font = new System.Drawing.Font("Figtree", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Zaman_Label.Location = new System.Drawing.Point(567, 723);
            this.Zaman_Label.Name = "Zaman_Label";
            this.Zaman_Label.Size = new System.Drawing.Size(209, 26);
            this.Zaman_Label.TabIndex = 1;
            this.Zaman_Label.Text = "19.03.2024 13:47:05";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 758);
            this.ControlBox = false;
            this.Controls.Add(this.Zaman_Label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Zaman_Label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label BrandName_Label;
        private View.UserPanel userPanel1;
        private View.LoginPanel loginPanel1;
        private View.AdminPanel adminPanel1;
        private View.LoginPanel loginPanel2;
        private View.UserPanel userPanel2;
        private View.AdminPanel adminPanel2;
    }
}

