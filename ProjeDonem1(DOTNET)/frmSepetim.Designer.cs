
namespace ProjeDonem1_DOTNET_
{
    partial class frmSepetim
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
            this.button1 = new System.Windows.Forms.Button();
            this.lnklblAnaSayfa = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblSepetimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje_Donem1DataSet4 = new ProjeDonem1_DOTNET_.Proje_Donem1DataSet4();
            this.button2 = new System.Windows.Forms.Button();
            this.tbl_SepetimTableAdapter = new ProjeDonem1_DOTNET_.Proje_Donem1DataSet4TableAdapters.Tbl_SepetimTableAdapter();
            this.proje_Donem1DataSet3 = new ProjeDonem1_DOTNET_.Proje_Donem1DataSet3();
            this.tblTumUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TumUrunlerTableAdapter = new ProjeDonem1_DOTNET_.Proje_Donem1DataSet3TableAdapters.Tbl_TumUrunlerTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSepetimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_Donem1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_Donem1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTumUrunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ödeme Ekranına Geç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnklblAnaSayfa
            // 
            this.lnklblAnaSayfa.AutoSize = true;
            this.lnklblAnaSayfa.Location = new System.Drawing.Point(362, 351);
            this.lnklblAnaSayfa.Name = "lnklblAnaSayfa";
            this.lnklblAnaSayfa.Size = new System.Drawing.Size(133, 20);
            this.lnklblAnaSayfa.TabIndex = 2;
            this.lnklblAnaSayfa.TabStop = true;
            this.lnklblAnaSayfa.Text = "Ana Sayfaya Dön";
            this.lnklblAnaSayfa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAnaSayfa_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 564);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepetimdeki Ürünler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(338, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tblSepetimBindingSource
            // 
            this.tblSepetimBindingSource.DataMember = "Tbl_Sepetim";
            this.tblSepetimBindingSource.DataSource = this.proje_Donem1DataSet4;
            // 
            // proje_Donem1DataSet4
            // 
            this.proje_Donem1DataSet4.DataSetName = "Proje_Donem1DataSet4";
            this.proje_Donem1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbl_SepetimTableAdapter
            // 
            this.tbl_SepetimTableAdapter.ClearBeforeFill = true;
            // 
            // proje_Donem1DataSet3
            // 
            this.proje_Donem1DataSet3.DataSetName = "Proje_Donem1DataSet3";
            this.proje_Donem1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTumUrunlerBindingSource
            // 
            this.tblTumUrunlerBindingSource.DataMember = "Tbl_TumUrunler";
            this.tblTumUrunlerBindingSource.DataSource = this.proje_Donem1DataSet3;
            // 
            // tbl_TumUrunlerTableAdapter
            // 
            this.tbl_TumUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(362, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(119, 117);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Ürünlere çift tıklayarak sepetinizden ürün çıkarabilirsiniz.";
            // 
            // frmSepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 588);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnklblAnaSayfa);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSepetim";
            this.Text = "Sepetim";
            this.Load += new System.EventHandler(this.frmSepetim_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSepetimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_Donem1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_Donem1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTumUrunlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnklblAnaSayfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Proje_Donem1DataSet4 proje_Donem1DataSet4;
        private System.Windows.Forms.BindingSource tblSepetimBindingSource;
        private Proje_Donem1DataSet4TableAdapters.Tbl_SepetimTableAdapter tbl_SepetimTableAdapter;
        private Proje_Donem1DataSet3 proje_Donem1DataSet3;
        private System.Windows.Forms.BindingSource tblTumUrunlerBindingSource;
        private Proje_Donem1DataSet3TableAdapters.Tbl_TumUrunlerTableAdapter tbl_TumUrunlerTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}