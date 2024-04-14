namespace AracKiralama.View
{
    partial class UserPanel
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.u_AracKirala1 = new AracKiralama.View.UserView.U_AracKirala();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_Btn = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Settings_Btn = new System.Windows.Forms.Button();
            this.RentCar_Btn = new System.Windows.Forms.Button();
            this.MyRentals_Btn = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.u_Ayarlar1 = new AracKiralama.View.UserView.U_Ayarlar();
            this.u_Kiralamalarım1 = new AracKiralama.View.UserView.U_Kiralamalarım();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_Btn)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 620);
            this.panel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.u_Kiralamalarım1);
            this.panel4.Controls.Add(this.u_Ayarlar1);
            this.panel4.Controls.Add(this.u_AracKirala1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(247, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1090, 620);
            this.panel4.TabIndex = 1;
            // 
            // u_AracKirala1
            // 
            this.u_AracKirala1.Location = new System.Drawing.Point(6, 1);
            this.u_AracKirala1.Name = "u_AracKirala1";
            this.u_AracKirala1.Size = new System.Drawing.Size(1089, 619);
            this.u_AracKirala1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logout_Btn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.userLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 620);
            this.panel2.TabIndex = 0;
            // 
            // logout_Btn
            // 
            this.logout_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_Btn.Image = global::AracKiralama.Properties.Resources.logout1;
            this.logout_Btn.Location = new System.Drawing.Point(189, 3);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(52, 62);
            this.logout_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout_Btn.TabIndex = 17;
            this.logout_Btn.TabStop = false;
            this.logout_Btn.Click += new System.EventHandler(this.logOut_Btn);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Settings_Btn);
            this.panel3.Controls.Add(this.RentCar_Btn);
            this.panel3.Controls.Add(this.MyRentals_Btn);
            this.panel3.Location = new System.Drawing.Point(40, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 197);
            this.panel3.TabIndex = 16;
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.BackColor = System.Drawing.SystemColors.Info;
            this.Settings_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Settings_Btn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Settings_Btn.Location = new System.Drawing.Point(0, 134);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new System.Drawing.Size(167, 60);
            this.Settings_Btn.TabIndex = 15;
            this.Settings_Btn.Text = "Ayarlar";
            this.Settings_Btn.UseVisualStyleBackColor = false;
            // 
            // RentCar_Btn
            // 
            this.RentCar_Btn.BackColor = System.Drawing.SystemColors.Info;
            this.RentCar_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RentCar_Btn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RentCar_Btn.Location = new System.Drawing.Point(0, 8);
            this.RentCar_Btn.Name = "RentCar_Btn";
            this.RentCar_Btn.Size = new System.Drawing.Size(167, 54);
            this.RentCar_Btn.TabIndex = 15;
            this.RentCar_Btn.Text = "Araç Kirala";
            this.RentCar_Btn.UseVisualStyleBackColor = false;
            // 
            // MyRentals_Btn
            // 
            this.MyRentals_Btn.BackColor = System.Drawing.SystemColors.Info;
            this.MyRentals_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MyRentals_Btn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MyRentals_Btn.Location = new System.Drawing.Point(0, 68);
            this.MyRentals_Btn.Name = "MyRentals_Btn";
            this.MyRentals_Btn.Size = new System.Drawing.Size(167, 60);
            this.MyRentals_Btn.TabIndex = 15;
            this.MyRentals_Btn.Text = "Kiralamalarım";
            this.MyRentals_Btn.UseVisualStyleBackColor = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLabel.Location = new System.Drawing.Point(3, 42);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(25, 23);
            this.userLabel.TabIndex = 14;
            this.userLabel.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // u_Ayarlar1
            // 
            this.u_Ayarlar1.Location = new System.Drawing.Point(3, 1);
            this.u_Ayarlar1.Name = "u_Ayarlar1";
            this.u_Ayarlar1.Size = new System.Drawing.Size(1089, 619);
            this.u_Ayarlar1.TabIndex = 1;
            // 
            // u_Kiralamalarım1
            // 
            this.u_Kiralamalarım1.Location = new System.Drawing.Point(3, 0);
            this.u_Kiralamalarım1.Name = "u_Kiralamalarım1";
            this.u_Kiralamalarım1.Size = new System.Drawing.Size(1089, 619);
            this.u_Kiralamalarım1.TabIndex = 2;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(1343, 626);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_Btn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button RentCar_Btn;
        private System.Windows.Forms.Button MyRentals_Btn;
        private System.Windows.Forms.Button Settings_Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox logout_Btn;
        private UserView.U_AracKirala u_AracKirala1;
        private UserView.U_Kiralamalarım u_Kiralamalarım1;
        private UserView.U_Ayarlar u_Ayarlar1;
    }
}
