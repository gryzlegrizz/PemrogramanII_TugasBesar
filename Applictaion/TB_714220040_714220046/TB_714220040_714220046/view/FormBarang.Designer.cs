namespace TB_714220040_714220046
{
    partial class FormBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarang));
            this.dgBarang = new System.Windows.Forms.DataGridView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAct = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbAct.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBarang
            // 
            this.dgBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgBarang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgBarang.Location = new System.Drawing.Point(0, 0);
            this.dgBarang.Name = "dgBarang";
            this.dgBarang.RowHeadersWidth = 51;
            this.dgBarang.RowTemplate.Height = 24;
            this.dgBarang.Size = new System.Drawing.Size(918, 311);
            this.dgBarang.TabIndex = 0;
            this.dgBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBarang_CellClick);
            this.dgBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgBarang_CellFormatting);
            this.dgBarang.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBarang_ColumnHeaderMouseClick);
            this.dgBarang.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBarang_ColumnHeaderMouseDoubleClick);
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.MintCream;
            this.gbSearch.Controls.Add(this.tbCari);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Location = new System.Drawing.Point(9, 312);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(561, 67);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(108, 28);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(447, 22);
            this.tbCari.TabIndex = 1;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Barang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAct
            // 
            this.gbAct.BackColor = System.Drawing.Color.LightCyan;
            this.gbAct.Controls.Add(this.btnHapus);
            this.gbAct.Controls.Add(this.btnUbah);
            this.gbAct.Controls.Add(this.btnSimpan);
            this.gbAct.Controls.Add(this.btnRefresh);
            this.gbAct.Location = new System.Drawing.Point(576, 312);
            this.gbAct.Name = "gbAct";
            this.gbAct.Size = new System.Drawing.Size(330, 257);
            this.gbAct.TabIndex = 3;
            this.gbAct.TabStop = false;
            // 
            // btnHapus
            // 
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.Location = new System.Drawing.Point(28, 176);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(255, 35);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.Location = new System.Drawing.Point(28, 99);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(255, 35);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Location = new System.Drawing.Point(28, 22);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(255, 35);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(289, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbInput
            // 
            this.gbInput.BackColor = System.Drawing.Color.MintCream;
            this.gbInput.Controls.Add(this.label4);
            this.gbInput.Controls.Add(this.tbHargaBarang);
            this.gbInput.Controls.Add(this.label3);
            this.gbInput.Controls.Add(this.tbNamaBarang);
            this.gbInput.Controls.Add(this.label2);
            this.gbInput.Location = new System.Drawing.Point(9, 378);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(561, 191);
            this.gbInput.TabIndex = 2;
            this.gbInput.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(105, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rp.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.BackColor = System.Drawing.Color.White;
            this.tbHargaBarang.Location = new System.Drawing.Point(132, 126);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(423, 22);
            this.tbHargaBarang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.BackColor = System.Drawing.Color.White;
            this.tbNamaBarang.Location = new System.Drawing.Point(108, 46);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(447, 22);
            this.tbNamaBarang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Barang";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(918, 575);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.gbAct);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgBarang);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBarang";
            this.Text = "Data Barang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbAct.ResumeLayout(false);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBarang;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAct;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label2;
    }
}

