namespace AracKiralama.View.AdminView
{
    partial class A_Musteriler
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
            this.CustomersDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.DOB_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Licance_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ActiveRentals_Btn = new System.Windows.Forms.Button();
            this.CancelledRentals_Btn = new System.Windows.Forms.Button();
            this.RentalsDataGrid = new System.Windows.Forms.DataGridView();
            this.MarkaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KmTextBox = new System.Windows.Forms.TextBox();
            this.YakitTextBox = new System.Windows.Forms.TextBox();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ehliyetTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersDataGrid
            // 
            this.CustomersDataGrid.AllowUserToAddRows = false;
            this.CustomersDataGrid.AllowUserToDeleteRows = false;
            this.CustomersDataGrid.AllowUserToOrderColumns = true;
            this.CustomersDataGrid.AutoGenerateColumns = false;
            this.CustomersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.ehliyetTarihiDataGridViewTextBoxColumn});
            this.CustomersDataGrid.DataSource = this.kullaniciBindingSource;
            this.CustomersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.CustomersDataGrid.Name = "CustomersDataGrid";
            this.CustomersDataGrid.Size = new System.Drawing.Size(521, 618);
            this.CustomersDataGrid.TabIndex = 0;
            this.CustomersDataGrid.SelectionChanged += new System.EventHandler(this.CustomersDataGrid_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(633, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Username_Textbox.Location = new System.Drawing.Point(764, 3);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.ReadOnly = true;
            this.Username_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Username_Textbox.TabIndex = 13;
            // 
            // DOB_Textbox
            // 
            this.DOB_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DOB_Textbox.Location = new System.Drawing.Point(764, 39);
            this.DOB_Textbox.Name = "DOB_Textbox";
            this.DOB_Textbox.ReadOnly = true;
            this.DOB_Textbox.Size = new System.Drawing.Size(167, 30);
            this.DOB_Textbox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(633, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doğum Tarihi";
            // 
            // Licance_Textbox
            // 
            this.Licance_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Licance_Textbox.Location = new System.Drawing.Point(764, 75);
            this.Licance_Textbox.Name = "Licance_Textbox";
            this.Licance_Textbox.ReadOnly = true;
            this.Licance_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Licance_Textbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(633, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ehliyet Tarihi";
            // 
            // ActiveRentals_Btn
            // 
            this.ActiveRentals_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ActiveRentals_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ActiveRentals_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ActiveRentals_Btn.Location = new System.Drawing.Point(637, 121);
            this.ActiveRentals_Btn.Name = "ActiveRentals_Btn";
            this.ActiveRentals_Btn.Size = new System.Drawing.Size(294, 54);
            this.ActiveRentals_Btn.TabIndex = 15;
            this.ActiveRentals_Btn.Text = "Aktif Kiralamaları Göster";
            this.ActiveRentals_Btn.UseVisualStyleBackColor = false;
            this.ActiveRentals_Btn.Click += new System.EventHandler(this.ActiveRentals_Btn_Click);
            // 
            // CancelledRentals_Btn
            // 
            this.CancelledRentals_Btn.BackColor = System.Drawing.Color.SlateGray;
            this.CancelledRentals_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelledRentals_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelledRentals_Btn.Location = new System.Drawing.Point(637, 181);
            this.CancelledRentals_Btn.Name = "CancelledRentals_Btn";
            this.CancelledRentals_Btn.Size = new System.Drawing.Size(294, 54);
            this.CancelledRentals_Btn.TabIndex = 15;
            this.CancelledRentals_Btn.Text = "İptal Edilen Kiralamaları Göster";
            this.CancelledRentals_Btn.UseVisualStyleBackColor = false;
            this.CancelledRentals_Btn.Click += new System.EventHandler(this.CancelledRentals_Btn_Click);
            // 
            // RentalsDataGrid
            // 
            this.RentalsDataGrid.AllowUserToAddRows = false;
            this.RentalsDataGrid.AllowUserToDeleteRows = false;
            this.RentalsDataGrid.AutoGenerateColumns = false;
            this.RentalsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.aracIdDataGridViewTextBoxColumn,
            this.kullaniciIdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.RentalsDataGrid.DataSource = this.kiralamalarBindingSource;
            this.RentalsDataGrid.Location = new System.Drawing.Point(0, 3);
            this.RentalsDataGrid.Name = "RentalsDataGrid";
            this.RentalsDataGrid.ReadOnly = true;
            this.RentalsDataGrid.Size = new System.Drawing.Size(370, 382);
            this.RentalsDataGrid.TabIndex = 16;
            this.RentalsDataGrid.SelectionChanged += new System.EventHandler(this.RentalsDataGrid_SelectionChanged);
            // 
            // MarkaTextBox
            // 
            this.MarkaTextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarkaTextBox.Location = new System.Drawing.Point(376, 82);
            this.MarkaTextBox.Name = "MarkaTextBox";
            this.MarkaTextBox.ReadOnly = true;
            this.MarkaTextBox.Size = new System.Drawing.Size(179, 30);
            this.MarkaTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(405, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Araba Marka";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ModelTextBox.Location = new System.Drawing.Point(376, 146);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(179, 30);
            this.ModelTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(405, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Araba Model";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.KmTextBox);
            this.panel1.Controls.Add(this.RentalsDataGrid);
            this.panel1.Controls.Add(this.YakitTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ModelTextBox);
            this.panel1.Controls.Add(this.MarkaTextBox);
            this.panel1.Location = new System.Drawing.Point(527, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 379);
            this.panel1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(387, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Araba Kilometre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(409, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Araba Yakıt";
            // 
            // KmTextBox
            // 
            this.KmTextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KmTextBox.Location = new System.Drawing.Point(375, 274);
            this.KmTextBox.Name = "KmTextBox";
            this.KmTextBox.ReadOnly = true;
            this.KmTextBox.Size = new System.Drawing.Size(179, 30);
            this.KmTextBox.TabIndex = 13;
            // 
            // YakitTextBox
            // 
            this.YakitTextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YakitTextBox.Location = new System.Drawing.Point(375, 210);
            this.YakitTextBox.Name = "YakitTextBox";
            this.YakitTextBox.ReadOnly = true;
            this.YakitTextBox.Size = new System.Drawing.Size(179, 30);
            this.YakitTextBox.TabIndex = 13;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn1.Width = 30;
            // 
            // aracIdDataGridViewTextBoxColumn
            // 
            this.aracIdDataGridViewTextBoxColumn.DataPropertyName = "Arac_Id";
            this.aracIdDataGridViewTextBoxColumn.HeaderText = "Arac_Id";
            this.aracIdDataGridViewTextBoxColumn.Name = "aracIdDataGridViewTextBoxColumn";
            this.aracIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.aracIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // kullaniciIdDataGridViewTextBoxColumn
            // 
            this.kullaniciIdDataGridViewTextBoxColumn.DataPropertyName = "Kullanici_Id";
            this.kullaniciIdDataGridViewTextBoxColumn.HeaderText = "Kullanici_Id";
            this.kullaniciIdDataGridViewTextBoxColumn.Name = "kullaniciIdDataGridViewTextBoxColumn";
            this.kullaniciIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 70;
            // 
            // kiralamalarBindingSource
            // 
            this.kiralamalarBindingSource.DataSource = typeof(AracKiralama.Model.Kiralamalar);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Width = 50;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "Kullanici_Adi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 150;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "Dogum_Tarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ehliyetTarihiDataGridViewTextBoxColumn
            // 
            this.ehliyetTarihiDataGridViewTextBoxColumn.DataPropertyName = "Ehliyet_Tarihi";
            this.ehliyetTarihiDataGridViewTextBoxColumn.HeaderText = "Ehliyet Tarihi";
            this.ehliyetTarihiDataGridViewTextBoxColumn.Name = "ehliyetTarihiDataGridViewTextBoxColumn";
            this.ehliyetTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataSource = typeof(AracKiralama.Model.Kullanici);
            // 
            // A_Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelledRentals_Btn);
            this.Controls.Add(this.ActiveRentals_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Licance_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOB_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Controls.Add(this.CustomersDataGrid);
            this.Name = "A_Musteriler";
            this.Size = new System.Drawing.Size(1085, 624);
            this.Load += new System.EventHandler(this.A_Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.TextBox DOB_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Licance_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ActiveRentals_Btn;
        private System.Windows.Forms.Button CancelledRentals_Btn;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ehliyetTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView RentalsDataGrid;
        private System.Windows.Forms.BindingSource kiralamalarBindingSource;
        private System.Windows.Forms.TextBox MarkaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox YakitTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox KmTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}
