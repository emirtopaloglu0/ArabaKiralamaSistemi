namespace AracKiralama.View.UserView
{
    partial class U_AracKirala
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
            this.KiralamaDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kilometre_Textbox = new System.Windows.Forms.TextBox();
            this.Plaka_Textbox = new System.Windows.Forms.TextBox();
            this.Vites_Textbox = new System.Windows.Forms.TextBox();
            this.Yakit_Textbox = new System.Windows.Forms.TextBox();
            this.Kategori_Textbox = new System.Windows.Forms.TextBox();
            this.Model_Textbox = new System.Windows.Forms.TextBox();
            this.Marka_Textbox = new System.Windows.Forms.TextBox();
            this.RentCar_Btn = new System.Windows.Forms.Button();
            this.FiyatTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KiralamaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KiralamaDataGrid
            // 
            this.KiralamaDataGrid.AllowUserToAddRows = false;
            this.KiralamaDataGrid.AllowUserToDeleteRows = false;
            this.KiralamaDataGrid.AutoGenerateColumns = false;
            this.KiralamaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KiralamaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.yakitTuruDataGridViewTextBoxColumn,
            this.vitesTuruDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.kilometreDataGridViewTextBoxColumn});
            this.KiralamaDataGrid.DataSource = this.arabaBindingSource;
            this.KiralamaDataGrid.Location = new System.Drawing.Point(3, 3);
            this.KiralamaDataGrid.Name = "KiralamaDataGrid";
            this.KiralamaDataGrid.ReadOnly = true;
            this.KiralamaDataGrid.Size = new System.Drawing.Size(779, 593);
            this.KiralamaDataGrid.TabIndex = 0;
            this.KiralamaDataGrid.SelectionChanged += new System.EventHandler(this.KiralamaDataGrid_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(977, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Id";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(788, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Kilometre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(788, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(788, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Vites Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(788, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Yakıt Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(788, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(788, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Model";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Id_TextBox.Location = new System.Drawing.Point(1009, 586);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(77, 30);
            this.Id_TextBox.TabIndex = 22;
            this.Id_TextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(788, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Marka";
            // 
            // Kilometre_Textbox
            // 
            this.Kilometre_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kilometre_Textbox.Location = new System.Drawing.Point(919, 219);
            this.Kilometre_Textbox.Name = "Kilometre_Textbox";
            this.Kilometre_Textbox.ReadOnly = true;
            this.Kilometre_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Kilometre_Textbox.TabIndex = 23;
            // 
            // Plaka_Textbox
            // 
            this.Plaka_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Plaka_Textbox.Location = new System.Drawing.Point(919, 183);
            this.Plaka_Textbox.Name = "Plaka_Textbox";
            this.Plaka_Textbox.ReadOnly = true;
            this.Plaka_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Plaka_Textbox.TabIndex = 24;
            // 
            // Vites_Textbox
            // 
            this.Vites_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vites_Textbox.Location = new System.Drawing.Point(919, 147);
            this.Vites_Textbox.Name = "Vites_Textbox";
            this.Vites_Textbox.ReadOnly = true;
            this.Vites_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Vites_Textbox.TabIndex = 25;
            // 
            // Yakit_Textbox
            // 
            this.Yakit_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yakit_Textbox.Location = new System.Drawing.Point(919, 111);
            this.Yakit_Textbox.Name = "Yakit_Textbox";
            this.Yakit_Textbox.ReadOnly = true;
            this.Yakit_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Yakit_Textbox.TabIndex = 26;
            // 
            // Kategori_Textbox
            // 
            this.Kategori_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategori_Textbox.Location = new System.Drawing.Point(919, 75);
            this.Kategori_Textbox.Name = "Kategori_Textbox";
            this.Kategori_Textbox.ReadOnly = true;
            this.Kategori_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Kategori_Textbox.TabIndex = 27;
            // 
            // Model_Textbox
            // 
            this.Model_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Model_Textbox.Location = new System.Drawing.Point(919, 39);
            this.Model_Textbox.Name = "Model_Textbox";
            this.Model_Textbox.ReadOnly = true;
            this.Model_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Model_Textbox.TabIndex = 28;
            // 
            // Marka_Textbox
            // 
            this.Marka_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Marka_Textbox.Location = new System.Drawing.Point(919, 3);
            this.Marka_Textbox.Name = "Marka_Textbox";
            this.Marka_Textbox.ReadOnly = true;
            this.Marka_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Marka_Textbox.TabIndex = 29;
            // 
            // RentCar_Btn
            // 
            this.RentCar_Btn.BackColor = System.Drawing.Color.Wheat;
            this.RentCar_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RentCar_Btn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RentCar_Btn.Location = new System.Drawing.Point(788, 352);
            this.RentCar_Btn.Name = "RentCar_Btn";
            this.RentCar_Btn.Size = new System.Drawing.Size(294, 54);
            this.RentCar_Btn.TabIndex = 38;
            this.RentCar_Btn.Text = "Kirala";
            this.RentCar_Btn.UseVisualStyleBackColor = false;
            this.RentCar_Btn.Click += new System.EventHandler(this.RentCar_Btn_Click);
            // 
            // FiyatTextBox
            // 
            this.FiyatTextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FiyatTextBox.Location = new System.Drawing.Point(919, 255);
            this.FiyatTextBox.Name = "FiyatTextBox";
            this.FiyatTextBox.ReadOnly = true;
            this.FiyatTextBox.Size = new System.Drawing.Size(167, 30);
            this.FiyatTextBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(788, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Fiyat";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 30;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yakitTuruDataGridViewTextBoxColumn
            // 
            this.yakitTuruDataGridViewTextBoxColumn.DataPropertyName = "Yakit_Turu";
            this.yakitTuruDataGridViewTextBoxColumn.HeaderText = "Yakit_Turu";
            this.yakitTuruDataGridViewTextBoxColumn.Name = "yakitTuruDataGridViewTextBoxColumn";
            this.yakitTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vitesTuruDataGridViewTextBoxColumn
            // 
            this.vitesTuruDataGridViewTextBoxColumn.DataPropertyName = "Vites_Turu";
            this.vitesTuruDataGridViewTextBoxColumn.HeaderText = "Vites_Turu";
            this.vitesTuruDataGridViewTextBoxColumn.Name = "vitesTuruDataGridViewTextBoxColumn";
            this.vitesTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilometreDataGridViewTextBoxColumn
            // 
            this.kilometreDataGridViewTextBoxColumn.DataPropertyName = "Kilometre";
            this.kilometreDataGridViewTextBoxColumn.HeaderText = "Kilometre";
            this.kilometreDataGridViewTextBoxColumn.Name = "kilometreDataGridViewTextBoxColumn";
            this.kilometreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arabaBindingSource
            // 
            this.arabaBindingSource.DataSource = typeof(AracKiralama.Model.Araba);
            // 
            // U_AracKirala
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
            this.Controls.Add(this.KiralamaDataGrid);
            this.Name = "U_AracKirala";
            this.Size = new System.Drawing.Size(1089, 619);
            ((System.ComponentModel.ISupportInitialize)(this.KiralamaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView KiralamaDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource arabaBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kilometre_Textbox;
        private System.Windows.Forms.TextBox Plaka_Textbox;
        private System.Windows.Forms.TextBox Vites_Textbox;
        private System.Windows.Forms.TextBox Yakit_Textbox;
        private System.Windows.Forms.TextBox Kategori_Textbox;
        private System.Windows.Forms.TextBox Model_Textbox;
        private System.Windows.Forms.TextBox Marka_Textbox;
        private System.Windows.Forms.Button RentCar_Btn;
        public System.Windows.Forms.TextBox FiyatTextBox;
        private System.Windows.Forms.Label label9;
    }
}
