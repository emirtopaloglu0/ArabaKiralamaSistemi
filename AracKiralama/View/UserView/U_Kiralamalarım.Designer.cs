namespace AracKiralama.View.UserView
{
    partial class U_Kiralamalarım
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
            this.components = new System.ComponentModel.Container();
            this.RentalsDataGrid = new System.Windows.Forms.DataGridView();
            this.kiralamalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentCar_Btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiyatTextBox = new System.Windows.Forms.TextBox();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kilometre_Textbox = new System.Windows.Forms.TextBox();
            this.Plaka_Textbox = new System.Windows.Forms.TextBox();
            this.Vites_Textbox = new System.Windows.Forms.TextBox();
            this.Yakit_Textbox = new System.Windows.Forms.TextBox();
            this.Kategori_Textbox = new System.Windows.Forms.TextBox();
            this.Model_Textbox = new System.Windows.Forms.TextBox();
            this.Marka_Textbox = new System.Windows.Forms.TextBox();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalsDataGrid
            // 
            this.RentalsDataGrid.AllowUserToAddRows = false;
            this.RentalsDataGrid.AllowUserToDeleteRows = false;
            this.RentalsDataGrid.AutoGenerateColumns = false;
            this.RentalsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.aracIdDataGridViewTextBoxColumn,
            this.kullaniciIdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.aktifMiDataGridViewCheckBoxColumn});
            this.RentalsDataGrid.DataSource = this.kiralamalarBindingSource;
            this.RentalsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.RentalsDataGrid.Name = "RentalsDataGrid";
            this.RentalsDataGrid.ReadOnly = true;
            this.RentalsDataGrid.Size = new System.Drawing.Size(548, 613);
            this.RentalsDataGrid.TabIndex = 0;
            this.RentalsDataGrid.SelectionChanged += new System.EventHandler(this.RentalsDataGrid_SelectionChanged);
            // 
            // kiralamalarBindingSource
            // 
            this.kiralamalarBindingSource.DataSource = typeof(AracKiralama.Model.Kiralamalar);
            // 
            // RentCar_Btn
            // 
            this.RentCar_Btn.BackColor = System.Drawing.Color.Wheat;
            this.RentCar_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RentCar_Btn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RentCar_Btn.Location = new System.Drawing.Point(674, 352);
            this.RentCar_Btn.Name = "RentCar_Btn";
            this.RentCar_Btn.Size = new System.Drawing.Size(294, 54);
            this.RentCar_Btn.TabIndex = 57;
            this.RentCar_Btn.Text = "Kiralamayı Sonlandır";
            this.RentCar_Btn.UseVisualStyleBackColor = false;
            this.RentCar_Btn.Click += new System.EventHandler(this.CancelRental_Btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(674, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(977, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Id";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(674, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Kilometre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(674, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(674, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Vites Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(674, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "Yakıt Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(674, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(674, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Model";
            // 
            // FiyatTextBox
            // 
            this.FiyatTextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FiyatTextBox.Location = new System.Drawing.Point(805, 255);
            this.FiyatTextBox.Name = "FiyatTextBox";
            this.FiyatTextBox.ReadOnly = true;
            this.FiyatTextBox.Size = new System.Drawing.Size(167, 30);
            this.FiyatTextBox.TabIndex = 39;
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Id_TextBox.Location = new System.Drawing.Point(1009, 586);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(77, 30);
            this.Id_TextBox.TabIndex = 40;
            this.Id_TextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(674, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Marka";
            // 
            // Kilometre_Textbox
            // 
            this.Kilometre_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kilometre_Textbox.Location = new System.Drawing.Point(805, 219);
            this.Kilometre_Textbox.Name = "Kilometre_Textbox";
            this.Kilometre_Textbox.ReadOnly = true;
            this.Kilometre_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Kilometre_Textbox.TabIndex = 41;
            // 
            // Plaka_Textbox
            // 
            this.Plaka_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Plaka_Textbox.Location = new System.Drawing.Point(805, 183);
            this.Plaka_Textbox.Name = "Plaka_Textbox";
            this.Plaka_Textbox.ReadOnly = true;
            this.Plaka_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Plaka_Textbox.TabIndex = 42;
            // 
            // Vites_Textbox
            // 
            this.Vites_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vites_Textbox.Location = new System.Drawing.Point(805, 147);
            this.Vites_Textbox.Name = "Vites_Textbox";
            this.Vites_Textbox.ReadOnly = true;
            this.Vites_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Vites_Textbox.TabIndex = 43;
            // 
            // Yakit_Textbox
            // 
            this.Yakit_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yakit_Textbox.Location = new System.Drawing.Point(805, 111);
            this.Yakit_Textbox.Name = "Yakit_Textbox";
            this.Yakit_Textbox.ReadOnly = true;
            this.Yakit_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Yakit_Textbox.TabIndex = 44;
            // 
            // Kategori_Textbox
            // 
            this.Kategori_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategori_Textbox.Location = new System.Drawing.Point(805, 75);
            this.Kategori_Textbox.Name = "Kategori_Textbox";
            this.Kategori_Textbox.ReadOnly = true;
            this.Kategori_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Kategori_Textbox.TabIndex = 45;
            // 
            // Model_Textbox
            // 
            this.Model_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Model_Textbox.Location = new System.Drawing.Point(805, 39);
            this.Model_Textbox.Name = "Model_Textbox";
            this.Model_Textbox.ReadOnly = true;
            this.Model_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Model_Textbox.TabIndex = 46;
            // 
            // Marka_Textbox
            // 
            this.Marka_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Marka_Textbox.Location = new System.Drawing.Point(805, 3);
            this.Marka_Textbox.Name = "Marka_Textbox";
            this.Marka_Textbox.ReadOnly = true;
            this.Marka_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Marka_Textbox.TabIndex = 47;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 40;
            // 
            // aracIdDataGridViewTextBoxColumn
            // 
            this.aracIdDataGridViewTextBoxColumn.DataPropertyName = "Arac_Id";
            this.aracIdDataGridViewTextBoxColumn.HeaderText = "Arac_Id";
            this.aracIdDataGridViewTextBoxColumn.Name = "aracIdDataGridViewTextBoxColumn";
            this.aracIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciIdDataGridViewTextBoxColumn
            // 
            this.kullaniciIdDataGridViewTextBoxColumn.DataPropertyName = "Kullanici_Id";
            this.kullaniciIdDataGridViewTextBoxColumn.HeaderText = "Kullanici_Id";
            this.kullaniciIdDataGridViewTextBoxColumn.Name = "kullaniciIdDataGridViewTextBoxColumn";
            this.kullaniciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            this.aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.HeaderText = "Aktif Mi";
            this.aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            this.aktifMiDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // U_Kiralamalarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RentCar_Btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiyatTextBox);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kilometre_Textbox);
            this.Controls.Add(this.Plaka_Textbox);
            this.Controls.Add(this.Vites_Textbox);
            this.Controls.Add(this.Yakit_Textbox);
            this.Controls.Add(this.Kategori_Textbox);
            this.Controls.Add(this.Model_Textbox);
            this.Controls.Add(this.Marka_Textbox);
            this.Controls.Add(this.RentalsDataGrid);
            this.Name = "U_Kiralamalarım";
            this.Size = new System.Drawing.Size(1089, 619);
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RentalsDataGrid;
        private System.Windows.Forms.BindingSource kiralamalarBindingSource;
        private System.Windows.Forms.Button RentCar_Btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox FiyatTextBox;
        public System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kilometre_Textbox;
        private System.Windows.Forms.TextBox Plaka_Textbox;
        private System.Windows.Forms.TextBox Vites_Textbox;
        private System.Windows.Forms.TextBox Yakit_Textbox;
        private System.Windows.Forms.TextBox Kategori_Textbox;
        private System.Windows.Forms.TextBox Model_Textbox;
        private System.Windows.Forms.TextBox Marka_Textbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
    }
}
