
namespace ProjeDonem1_DOTNET_
{
    partial class frmKapidaOdeme
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
            this.lblKullaniciAdS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoyadS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAdres = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lnklblAnaSayfa = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblKullaniciAdS
            // 
            this.lblKullaniciAdS.AutoSize = true;
            this.lblKullaniciAdS.Location = new System.Drawing.Point(163, 145);
            this.lblKullaniciAdS.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblKullaniciAdS.Name = "lblKullaniciAdS";
            this.lblKullaniciAdS.Size = new System.Drawing.Size(70, 25);
            this.lblKullaniciAdS.TabIndex = 1;
            this.lblKullaniciAdS.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // lblSoyadS
            // 
            this.lblSoyadS.AutoSize = true;
            this.lblSoyadS.Location = new System.Drawing.Point(163, 80);
            this.lblSoyadS.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblSoyadS.Name = "lblSoyadS";
            this.lblSoyadS.Size = new System.Drawing.Size(70, 25);
            this.lblSoyadS.TabIndex = 3;
            this.lblSoyadS.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad:";
            // 
            // lblAdS
            // 
            this.lblAdS.AutoSize = true;
            this.lblAdS.Location = new System.Drawing.Point(163, 9);
            this.lblAdS.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblAdS.Name = "lblAdS";
            this.lblAdS.Size = new System.Drawing.Size(70, 25);
            this.lblAdS.TabIndex = 5;
            this.lblAdS.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad:";
            // 
            // cmbAdres
            // 
            this.cmbAdres.FormattingEnabled = true;
            this.cmbAdres.Location = new System.Drawing.Point(310, 37);
            this.cmbAdres.Name = "cmbAdres";
            this.cmbAdres.Size = new System.Drawing.Size(463, 33);
            this.cmbAdres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lütfen sipraşinizin teslim edileceği adresi seçin.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ödemeyi Tamamla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnklblAnaSayfa
            // 
            this.lnklblAnaSayfa.AutoSize = true;
            this.lnklblAnaSayfa.Location = new System.Drawing.Point(352, 145);
            this.lnklblAnaSayfa.Name = "lnklblAnaSayfa";
            this.lnklblAnaSayfa.Size = new System.Drawing.Size(179, 25);
            this.lnklblAnaSayfa.TabIndex = 10;
            this.lnklblAnaSayfa.TabStop = true;
            this.lnklblAnaSayfa.Text = "Ana Sayfaya Dön";
            this.lnklblAnaSayfa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAnaSayfa_LinkClicked);
            // 
            // frmKapidaOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 203);
            this.Controls.Add(this.lnklblAnaSayfa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAdres);
            this.Controls.Add(this.lblKullaniciAdS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSoyadS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmKapidaOdeme";
            this.Text = "Kapıda Ödeme Bilgileri";
            this.Load += new System.EventHandler(this.frmKapidaOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoyadS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnklblAnaSayfa;
    }
}