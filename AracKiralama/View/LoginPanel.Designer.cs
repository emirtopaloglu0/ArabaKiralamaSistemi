namespace AracKiralama.View
{
    partial class LoginPanel
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.Register_Btn);
            this.panel1.Controls.Add(this.Login_Btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Password_Textbox);
            this.panel1.Controls.Add(this.Username_Textbox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 620);
            this.panel1.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Figtree", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(761, 332);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Register_Btn
            // 
            this.Register_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Register_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Register_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Register_Btn.Location = new System.Drawing.Point(588, 431);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(167, 54);
            this.Register_Btn.TabIndex = 4;
            this.Register_Btn.Text = "Kayıt Ol";
            this.Register_Btn.UseVisualStyleBackColor = false;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_Btn.Location = new System.Drawing.Point(588, 371);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(167, 54);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "Giriş Yap";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(493, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(462, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Password_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Password_Textbox.Location = new System.Drawing.Point(588, 329);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.PasswordChar = '*';
            this.Password_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Password_Textbox.TabIndex = 2;
            this.Password_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_Textbox_KeyDown);
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Username_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Username_Textbox.Location = new System.Drawing.Point(588, 289);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Username_Textbox.TabIndex = 1;
            this.Username_Textbox.TextChanged += new System.EventHandler(this.Username_Textbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(612, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(1343, 626);
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
