namespace AracKiralama.View.AdminView
{
    partial class A_Araclar
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
            this.AddCar_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ArabalarDataGrid = new System.Windows.Forms.DataGridView();
            this.Marka_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Model_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kategori_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yakit_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Vites_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Plaka_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Kilometre_Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bostaMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kiralamalarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.arabaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArabalarDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCar_Btn
            // 
            this.AddCar_Btn.BackColor = System.Drawing.Color.Gainsboro;
            this.AddCar_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCar_Btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddCar_Btn.Location = new System.Drawing.Point(822, 433);
            this.AddCar_Btn.Name = "AddCar_Btn";
            this.AddCar_Btn.Size = new System.Drawing.Size(167, 54);
            this.AddCar_Btn.TabIndex = 16;
            this.AddCar_Btn.Text = "Araç Ekle";
            this.AddCar_Btn.UseVisualStyleBackColor = false;
            this.AddCar_Btn.Click += new System.EventHandler(this.AddCar_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(822, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Araç Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(822, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 54);
            this.button2.TabIndex = 18;
            this.button2.Text = "Araç Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ArabalarDataGrid
            // 
            this.ArabalarDataGrid.AllowUserToAddRows = false;
            this.ArabalarDataGrid.AllowUserToDeleteRows = false;
            this.ArabalarDataGrid.AutoGenerateColumns = false;
            this.ArabalarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArabalarDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.yakitTuruDataGridViewTextBoxColumn,
            this.vitesTuruDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.kilometreDataGridViewTextBoxColumn,
            this.bostaMiDataGridViewCheckBoxColumn,
            this.kiralamalarDataGridViewTextBoxColumn});
            this.ArabalarDataGrid.DataSource = this.arabaBindingSource2;
            this.ArabalarDataGrid.Location = new System.Drawing.Point(3, 3);
            this.ArabalarDataGrid.Name = "ArabalarDataGrid";
            this.ArabalarDataGrid.ReadOnly = true;
            this.ArabalarDataGrid.Size = new System.Drawing.Size(716, 618);
            this.ArabalarDataGrid.TabIndex = 19;
            this.ArabalarDataGrid.SelectionChanged += new System.EventHandler(this.ArabalarDataGrid_SelectionChanged);
            // 
            // Marka_Textbox
            // 
            this.Marka_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Marka_Textbox.Location = new System.Drawing.Point(890, 3);
            this.Marka_Textbox.Name = "Marka_Textbox";
            this.Marka_Textbox.ReadOnly = true;
            this.Marka_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Marka_Textbox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(759, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marka";
            // 
            // Model_Textbox
            // 
            this.Model_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Model_Textbox.Location = new System.Drawing.Point(890, 39);
            this.Model_Textbox.Name = "Model_Textbox";
            this.Model_Textbox.ReadOnly = true;
            this.Model_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Model_Textbox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(759, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Model";
            // 
            // Kategori_Textbox
            // 
            this.Kategori_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategori_Textbox.Location = new System.Drawing.Point(890, 75);
            this.Kategori_Textbox.Name = "Kategori_Textbox";
            this.Kategori_Textbox.ReadOnly = true;
            this.Kategori_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Kategori_Textbox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(759, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kategori";
            // 
            // Yakit_Textbox
            // 
            this.Yakit_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yakit_Textbox.Location = new System.Drawing.Point(890, 111);
            this.Yakit_Textbox.Name = "Yakit_Textbox";
            this.Yakit_Textbox.ReadOnly = true;
            this.Yakit_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Yakit_Textbox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(759, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Yakıt Türü";
            // 
            // Vites_Textbox
            // 
            this.Vites_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vites_Textbox.Location = new System.Drawing.Point(890, 147);
            this.Vites_Textbox.Name = "Vites_Textbox";
            this.Vites_Textbox.ReadOnly = true;
            this.Vites_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Vites_Textbox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(759, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Vites Türü";
            // 
            // Plaka_Textbox
            // 
            this.Plaka_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Plaka_Textbox.Location = new System.Drawing.Point(890, 183);
            this.Plaka_Textbox.Name = "Plaka_Textbox";
            this.Plaka_Textbox.ReadOnly = true;
            this.Plaka_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Plaka_Textbox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(759, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Plaka";
            // 
            // Kilometre_Textbox
            // 
            this.Kilometre_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kilometre_Textbox.Location = new System.Drawing.Point(890, 219);
            this.Kilometre_Textbox.Name = "Kilometre_Textbox";
            this.Kilometre_Textbox.ReadOnly = true;
            this.Kilometre_Textbox.Size = new System.Drawing.Size(167, 30);
            this.Kilometre_Textbox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(759, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kilometre";
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Id_TextBox.Location = new System.Drawing.Point(890, 255);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.ReadOnly = true;
            this.Id_TextBox.Size = new System.Drawing.Size(167, 30);
            this.Id_TextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(759, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Id";
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
            this.markaDataGridViewTextBoxColumn.Width = 75;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 75;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriDataGridViewTextBoxColumn.Width = 75;
            // 
            // yakitTuruDataGridViewTextBoxColumn
            // 
            this.yakitTuruDataGridViewTextBoxColumn.DataPropertyName = "Yakit_Turu";
            this.yakitTuruDataGridViewTextBoxColumn.HeaderText = "Yakit_Turu";
            this.yakitTuruDataGridViewTextBoxColumn.Name = "yakitTuruDataGridViewTextBoxColumn";
            this.yakitTuruDataGridViewTextBoxColumn.ReadOnly = true;
            this.yakitTuruDataGridViewTextBoxColumn.Width = 75;
            // 
            // vitesTuruDataGridViewTextBoxColumn
            // 
            this.vitesTuruDataGridViewTextBoxColumn.DataPropertyName = "Vites_Turu";
            this.vitesTuruDataGridViewTextBoxColumn.HeaderText = "Vites_Turu";
            this.vitesTuruDataGridViewTextBoxColumn.Name = "vitesTuruDataGridViewTextBoxColumn";
            this.vitesTuruDataGridViewTextBoxColumn.ReadOnly = true;
            this.vitesTuruDataGridViewTextBoxColumn.Width = 75;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.ReadOnly = true;
            this.plakaDataGridViewTextBoxColumn.Width = 75;
            // 
            // kilometreDataGridViewTextBoxColumn
            // 
            this.kilometreDataGridViewTextBoxColumn.DataPropertyName = "Kilometre";
            this.kilometreDataGridViewTextBoxColumn.HeaderText = "Kilometre";
            this.kilometreDataGridViewTextBoxColumn.Name = "kilometreDataGridViewTextBoxColumn";
            this.kilometreDataGridViewTextBoxColumn.ReadOnly = true;
            this.kilometreDataGridViewTextBoxColumn.Width = 75;
            // 
            // bostaMiDataGridViewCheckBoxColumn
            // 
            this.bostaMiDataGridViewCheckBoxColumn.DataPropertyName = "BostaMi";
            this.bostaMiDataGridViewCheckBoxColumn.HeaderText = "BostaMi";
            this.bostaMiDataGridViewCheckBoxColumn.Name = "bostaMiDataGridViewCheckBoxColumn";
            this.bostaMiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bostaMiDataGridViewCheckBoxColumn.Width = 50;
            // 
            // kiralamalarDataGridViewTextBoxColumn
            // 
            this.kiralamalarDataGridViewTextBoxColumn.DataPropertyName = "Kiralamalar";
            this.kiralamalarDataGridViewTextBoxColumn.HeaderText = "Kiralamalar";
            this.kiralamalarDataGridViewTextBoxColumn.Name = "kiralamalarDataGridViewTextBoxColumn";
            this.kiralamalarDataGridViewTextBoxColumn.ReadOnly = true;
            this.kiralamalarDataGridViewTextBoxColumn.Width = 60;
            // 
            // arabaBindingSource2
            // 
            this.arabaBindingSource2.DataSource = typeof(AracKiralama.Model.Araba);
            // 
            // arabaBindingSource
            // 
            this.arabaBindingSource.DataSource = typeof(AracKiralama.Model.Araba);
            // 
            // arabaBindingSource1
            // 
            this.arabaBindingSource1.DataSource = typeof(AracKiralama.Model.Araba);
            // 
            // A_Araclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kilometre_Textbox);
            this.Controls.Add(this.Plaka_Textbox);
            this.Controls.Add(this.Vites_Textbox);
            this.Controls.Add(this.Yakit_Textbox);
            this.Controls.Add(this.Kategori_Textbox);
            this.Controls.Add(this.Model_Textbox);
            this.Controls.Add(this.Marka_Textbox);
            this.Controls.Add(this.ArabalarDataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddCar_Btn);
            this.Name = "A_Araclar";
            this.Size = new System.Drawing.Size(1085, 624);
            ((System.ComponentModel.ISupportInitialize)(this.ArabalarDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCar_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ArabalarDataGrid;
        private System.Windows.Forms.TextBox Marka_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource arabaBindingSource;
        private System.Windows.Forms.BindingSource arabaBindingSource1;
        private System.Windows.Forms.BindingSource arabaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bostaMiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamalarDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Model_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kategori_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Yakit_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Vites_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Plaka_Textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Kilometre_Textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Id_TextBox;
    }
}
