namespace AracKiralama
{
    partial class AracGuncelleme
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
            this.MarkaBox = new System.Windows.Forms.ComboBox();
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.CatBox = new System.Windows.Forms.ComboBox();
            this.YakitBox = new System.Windows.Forms.ComboBox();
            this.VitesBox = new System.Windows.Forms.ComboBox();
            this.UpdateCar_Btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kilometre_Textbox = new System.Windows.Forms.TextBox();
            this.Plaka_Textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Id_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MarkaBox
            // 
            this.MarkaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarkaBox.FormattingEnabled = true;
            this.MarkaBox.Items.AddRange(new object[] {
            "Renault",
            "Ford",
            "Audi",
            "BMW",
            "Chevrolet",
            "Citroen",
            "Dacia",
            "Fiat",
            "Honda",
            "Hyundai",
            "Mercedes",
            "Nissan",
            "Opel",
            "Peugeot",
            "Seat",
            "Skoda",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.MarkaBox.Location = new System.Drawing.Point(158, 12);
            this.MarkaBox.Name = "MarkaBox";
            this.MarkaBox.Size = new System.Drawing.Size(167, 32);
            this.MarkaBox.TabIndex = 36;
            this.MarkaBox.SelectedIndexChanged += new System.EventHandler(this.MarkaBox_SelectedIndexChanged);
            // 
            // ModelBox
            // 
            this.ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(158, 48);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(167, 32);
            this.ModelBox.TabIndex = 37;
            // 
            // CatBox
            // 
            this.CatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CatBox.FormattingEnabled = true;
            this.CatBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CatBox.Location = new System.Drawing.Point(158, 84);
            this.CatBox.Name = "CatBox";
            this.CatBox.Size = new System.Drawing.Size(167, 32);
            this.CatBox.TabIndex = 38;
            // 
            // YakitBox
            // 
            this.YakitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YakitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YakitBox.FormattingEnabled = true;
            this.YakitBox.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Elektrik",
            "Hibrit"});
            this.YakitBox.Location = new System.Drawing.Point(158, 120);
            this.YakitBox.Name = "YakitBox";
            this.YakitBox.Size = new System.Drawing.Size(167, 32);
            this.YakitBox.TabIndex = 39;
            // 
            // VitesBox
            // 
            this.VitesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VitesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VitesBox.FormattingEnabled = true;
            this.VitesBox.Items.AddRange(new object[] {
            "Manuel",
            "Yarı Otomatik",
            "Otomatik"});
            this.VitesBox.Location = new System.Drawing.Point(158, 156);
            this.VitesBox.Name = "VitesBox";
            this.VitesBox.Size = new System.Drawing.Size(167, 32);
            this.VitesBox.TabIndex = 40;
            // 
            // UpdateCar_Btn
            // 
            this.UpdateCar_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateCar_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateCar_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateCar_Btn.Location = new System.Drawing.Point(98, 324);
            this.UpdateCar_Btn.Name = "UpdateCar_Btn";
            this.UpdateCar_Btn.Size = new System.Drawing.Size(167, 54);
            this.UpdateCar_Btn.TabIndex = 43;
            this.UpdateCar_Btn.Text = "Araç Güncelle";
            this.UpdateCar_Btn.UseVisualStyleBackColor = false;
            this.UpdateCar_Btn.Click += new System.EventHandler(this.UpdateCar_Btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(27, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Kilometre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(27, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(27, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Vites Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Yakıt Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(27, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Marka";
            // 
            // Kilometre_Textbox
            // 
            this.Kilometre_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kilometre_Textbox.Location = new System.Drawing.Point(158, 228);
            this.Kilometre_Textbox.Name = "Kilometre_Textbox";
            this.Kilometre_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Kilometre_Textbox.TabIndex = 42;
            // 
            // Plaka_Textbox
            // 
            this.Plaka_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Plaka_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Plaka_Textbox.Location = new System.Drawing.Point(158, 192);
            this.Plaka_Textbox.MaxLength = 15;
            this.Plaka_Textbox.Name = "Plaka_Textbox";
            this.Plaka_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Plaka_Textbox.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(98, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 44;
            this.button1.Text = "İptal Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Id:";
            // 
            // Id_Label
            // 
            this.Id_Label.AutoSize = true;
            this.Id_Label.Location = new System.Drawing.Point(27, 425);
            this.Id_Label.Name = "Id_Label";
            this.Id_Label.Size = new System.Drawing.Size(16, 13);
            this.Id_Label.TabIndex = 52;
            this.Id_Label.Text = "...";
            // 
            // AracGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.Id_Label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MarkaBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.CatBox);
            this.Controls.Add(this.YakitBox);
            this.Controls.Add(this.VitesBox);
            this.Controls.Add(this.UpdateCar_Btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kilometre_Textbox);
            this.Controls.Add(this.Plaka_Textbox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracGuncelleme";
            this.Load += new System.EventHandler(this.AracGuncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MarkaBox;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.ComboBox CatBox;
        private System.Windows.Forms.ComboBox YakitBox;
        private System.Windows.Forms.ComboBox VitesBox;
        private System.Windows.Forms.Button UpdateCar_Btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kilometre_Textbox;
        private System.Windows.Forms.TextBox Plaka_Textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Id_Label;
    }
}