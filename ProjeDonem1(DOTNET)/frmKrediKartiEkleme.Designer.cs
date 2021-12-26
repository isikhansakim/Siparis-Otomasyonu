
namespace ProjeDonem1_DOTNET_
{
    partial class frmKrediKartiEkleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskdSKT = new System.Windows.Forms.MaskedTextBox();
            this.mskdCVV = new System.Windows.Forms.MaskedTextBox();
            this.mskdKKNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyIsım = new System.Windows.Forms.TextBox();
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdSKT);
            this.groupBox1.Controls.Add(this.mskdCVV);
            this.groupBox1.Controls.Add(this.mskdKKNo);
            this.groupBox1.Controls.Add(this.txtSoyIsım);
            this.groupBox1.Controls.Add(this.txtIsım);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kartı Ekle";
            // 
            // mskdSKT
            // 
            this.mskdSKT.Location = new System.Drawing.Point(234, 167);
            this.mskdSKT.Mask = "00/0000";
            this.mskdSKT.Name = "mskdSKT";
            this.mskdSKT.Size = new System.Drawing.Size(205, 26);
            this.mskdSKT.TabIndex = 2;
            this.mskdSKT.ValidatingType = typeof(System.DateTime);
            // 
            // mskdCVV
            // 
            this.mskdCVV.Location = new System.Drawing.Point(234, 135);
            this.mskdCVV.Mask = "000";
            this.mskdCVV.Name = "mskdCVV";
            this.mskdCVV.Size = new System.Drawing.Size(205, 26);
            this.mskdCVV.TabIndex = 2;
            this.mskdCVV.ValidatingType = typeof(int);
            // 
            // mskdKKNo
            // 
            this.mskdKKNo.Location = new System.Drawing.Point(234, 103);
            this.mskdKKNo.Mask = "0000 0000 0000 0000";
            this.mskdKKNo.Name = "mskdKKNo";
            this.mskdKKNo.Size = new System.Drawing.Size(205, 26);
            this.mskdKKNo.TabIndex = 2;
            // 
            // txtSoyIsım
            // 
            this.txtSoyIsım.Location = new System.Drawing.Point(234, 71);
            this.txtSoyIsım.Name = "txtSoyIsım";
            this.txtSoyIsım.Size = new System.Drawing.Size(205, 26);
            this.txtSoyIsım.TabIndex = 1;
            // 
            // txtIsım
            // 
            this.txtIsım.Location = new System.Drawing.Point(234, 40);
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(205, 26);
            this.txtIsım.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Son Kullanma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CVV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kredi Kartı Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kredi Kartı Üzerindeki Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kredi Kartı Üzerindeki İsim:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kredi Kartı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKrediKartiEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKrediKartiEkleme";
            this.Text = "Kredi Kartı Ekleme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskdSKT;
        private System.Windows.Forms.MaskedTextBox mskdCVV;
        private System.Windows.Forms.MaskedTextBox mskdKKNo;
        private System.Windows.Forms.TextBox txtSoyIsım;
        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}