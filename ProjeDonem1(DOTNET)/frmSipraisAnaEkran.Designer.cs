
namespace ProjeDonem1_DOTNET_
{
    partial class frmSipraisAnaEkran
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesabımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgilerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeYöntemlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapıdaÖdemeNakitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sipraişlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTumUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje_Donem1DataSet3 = new ProjeDonem1_DOTNET_.Proje_Donem1DataSet3();
            this.tbl_TumUrunlerTableAdapter = new ProjeDonem1_DOTNET_.Proje_Donem1DataSet3TableAdapters.Tbl_TumUrunlerTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTumUrunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_Donem1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesabımToolStripMenuItem,
            this.sepetimToolStripMenuItem,
            this.sipraişlerimToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesabımToolStripMenuItem
            // 
            this.hesabımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıBilgilerimToolStripMenuItem,
            this.ödemeYöntemlerimToolStripMenuItem,
            this.adresEkleToolStripMenuItem});
            this.hesabımToolStripMenuItem.Name = "hesabımToolStripMenuItem";
            this.hesabımToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hesabımToolStripMenuItem.Text = "Hesabım";
            // 
            // kullanıcıBilgilerimToolStripMenuItem
            // 
            this.kullanıcıBilgilerimToolStripMenuItem.Name = "kullanıcıBilgilerimToolStripMenuItem";
            this.kullanıcıBilgilerimToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kullanıcıBilgilerimToolStripMenuItem.Text = "Kullanıcı Bilgilerim";
            this.kullanıcıBilgilerimToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgilerimToolStripMenuItem_Click);
            // 
            // ödemeYöntemlerimToolStripMenuItem
            // 
            this.ödemeYöntemlerimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krediKartıToolStripMenuItem,
            this.kapıdaÖdemeNakitToolStripMenuItem});
            this.ödemeYöntemlerimToolStripMenuItem.Name = "ödemeYöntemlerimToolStripMenuItem";
            this.ödemeYöntemlerimToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ödemeYöntemlerimToolStripMenuItem.Text = "Ödeme Yöntemlerim";
            // 
            // krediKartıToolStripMenuItem
            // 
            this.krediKartıToolStripMenuItem.Name = "krediKartıToolStripMenuItem";
            this.krediKartıToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.krediKartıToolStripMenuItem.Text = "Kredi Kartı";
            this.krediKartıToolStripMenuItem.Click += new System.EventHandler(this.krediKartıToolStripMenuItem_Click);
            // 
            // kapıdaÖdemeNakitToolStripMenuItem
            // 
            this.kapıdaÖdemeNakitToolStripMenuItem.Name = "kapıdaÖdemeNakitToolStripMenuItem";
            this.kapıdaÖdemeNakitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kapıdaÖdemeNakitToolStripMenuItem.Text = "Kapıda Ödeme(Nakit)";
            this.kapıdaÖdemeNakitToolStripMenuItem.Click += new System.EventHandler(this.kapıdaÖdemeNakitToolStripMenuItem_Click);
            // 
            // adresEkleToolStripMenuItem
            // 
            this.adresEkleToolStripMenuItem.Name = "adresEkleToolStripMenuItem";
            this.adresEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adresEkleToolStripMenuItem.Text = "Adres Ekle";
            this.adresEkleToolStripMenuItem.Click += new System.EventHandler(this.adresEkleToolStripMenuItem_Click);
            // 
            // sepetimToolStripMenuItem
            // 
            this.sepetimToolStripMenuItem.Name = "sepetimToolStripMenuItem";
            this.sepetimToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sepetimToolStripMenuItem.Text = "Sepetim";
            this.sepetimToolStripMenuItem.Click += new System.EventHandler(this.sepetimToolStripMenuItem_Click);
            // 
            // sipraişlerimToolStripMenuItem
            // 
            this.sipraişlerimToolStripMenuItem.Name = "sipraişlerimToolStripMenuItem";
            this.sipraişlerimToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.sipraişlerimToolStripMenuItem.Text = "Sipraişlerim";
            this.sipraişlerimToolStripMenuItem.Click += new System.EventHandler(this.sipraişlerimToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTumUrunlerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(650, 403);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "Urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "Urun_id";
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblTumUrunlerBindingSource
            // 
            this.tblTumUrunlerBindingSource.DataMember = "Tbl_TumUrunler";
            this.tblTumUrunlerBindingSource.DataSource = this.proje_Donem1DataSet3;
            // 
            // proje_Donem1DataSet3
            // 
            this.proje_Donem1DataSet3.DataSetName = "Proje_Donem1DataSet3";
            this.proje_Donem1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_TumUrunlerTableAdapter
            // 
            this.tbl_TumUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmSipraisAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSipraisAnaEkran";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.frmSipraisAnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTumUrunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_Donem1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesabımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgilerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeYöntemlerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sipraişlerimToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private Proje_Donem1DataSet3 proje_Donem1DataSet3;
        private System.Windows.Forms.BindingSource tblTumUrunlerBindingSource;
        private Proje_Donem1DataSet3TableAdapters.Tbl_TumUrunlerTableAdapter tbl_TumUrunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem kapıdaÖdemeNakitToolStripMenuItem;
    }
}