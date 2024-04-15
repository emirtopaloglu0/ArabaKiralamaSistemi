namespace AracKiralama.View
{
    partial class AdminPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddCar_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_Btn = new System.Windows.Forms.PictureBox();
            this.a_Musteriler1 = new AracKiralama.View.AdminView.A_Musteriler();
            this.a_Araclar1 = new AracKiralama.View.AdminView.A_Araclar();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logout_Btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 626);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.AddCar_Btn);
            this.panel3.Location = new System.Drawing.Point(45, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 130);
            this.panel3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Müşteriler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Customers_Btn_Click);
            // 
            // AddCar_Btn
            // 
            this.AddCar_Btn.BackColor = System.Drawing.Color.Gainsboro;
            this.AddCar_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCar_Btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddCar_Btn.Location = new System.Drawing.Point(0, 8);
            this.AddCar_Btn.Name = "AddCar_Btn";
            this.AddCar_Btn.Size = new System.Drawing.Size(167, 54);
            this.AddCar_Btn.TabIndex = 15;
            this.AddCar_Btn.Text = "Araçlar";
            this.AddCar_Btn.UseVisualStyleBackColor = false;
            this.AddCar_Btn.Click += new System.EventHandler(this.Cars_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.a_Musteriler1);
            this.panel2.Controls.Add(this.a_Araclar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 626);
            this.panel2.TabIndex = 1;
            // 
            // logout_Btn
            // 
            this.logout_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_Btn.Image = global::AracKiralama.Properties.Resources.logout1;
            this.logout_Btn.Location = new System.Drawing.Point(3, 580);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(46, 43);
            this.logout_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout_Btn.TabIndex = 18;
            this.logout_Btn.TabStop = false;
            this.logout_Btn.Click += new System.EventHandler(this.logout_Btn_Click);
            // 
            // a_Musteriler1
            // 
            this.a_Musteriler1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.a_Musteriler1.Location = new System.Drawing.Point(3, 2);
            this.a_Musteriler1.Name = "a_Musteriler1";
            this.a_Musteriler1.Size = new System.Drawing.Size(1085, 624);
            this.a_Musteriler1.TabIndex = 1;
            // 
            // a_Araclar1
            // 
            this.a_Araclar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.a_Araclar1.Location = new System.Drawing.Point(2, 3);
            this.a_Araclar1.Name = "a_Araclar1";
            this.a_Araclar1.Size = new System.Drawing.Size(1085, 624);
            this.a_Araclar1.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(1343, 626);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logout_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddCar_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private AdminView.A_Araclar a_Araclar1;
        private AdminView.A_Musteriler a_Musteriler1;
        private System.Windows.Forms.PictureBox logout_Btn;
    }
}
