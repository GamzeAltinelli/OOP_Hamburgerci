
namespace OOP_Hamburgerci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.grpBoyutlar = new System.Windows.Forms.GroupBox();
            this.rdoBuyuk = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisiEkle = new System.Windows.Forms.Button();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(13, 13);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(249, 138);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(13, 175);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(249, 31);
            this.cmbMenuler.TabIndex = 2;
            // 
            // grpBoyutlar
            // 
            this.grpBoyutlar.Controls.Add(this.rdoBuyuk);
            this.grpBoyutlar.Controls.Add(this.rdoOrta);
            this.grpBoyutlar.Controls.Add(this.rdoKucuk);
            this.grpBoyutlar.Location = new System.Drawing.Point(13, 207);
            this.grpBoyutlar.Name = "grpBoyutlar";
            this.grpBoyutlar.Size = new System.Drawing.Size(264, 61);
            this.grpBoyutlar.TabIndex = 3;
            this.grpBoyutlar.TabStop = false;
            this.grpBoyutlar.Text = "BOYUT SEÇİNİZ";
            // 
            // rdoBuyuk
            // 
            this.rdoBuyuk.AutoSize = true;
            this.rdoBuyuk.Location = new System.Drawing.Point(176, 26);
            this.rdoBuyuk.Name = "rdoBuyuk";
            this.rdoBuyuk.Size = new System.Drawing.Size(84, 27);
            this.rdoBuyuk.TabIndex = 2;
            this.rdoBuyuk.TabStop = true;
            this.rdoBuyuk.Text = "Büyük";
            this.rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(95, 26);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(67, 27);
            this.rdoOrta.TabIndex = 1;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(7, 26);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(84, 27);
            this.rdoKucuk.TabIndex = 0;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "MALZEME SEÇİN";
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.AutoScroll = true;
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(12, 297);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(249, 192);
            this.flpEkstraMalzemeler.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADET";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(89, 492);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(173, 30);
            this.nmrAdet.TabIndex = 7;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisiEkle
            // 
            this.btnSiparisiEkle.Location = new System.Drawing.Point(13, 524);
            this.btnSiparisiEkle.Name = "btnSiparisiEkle";
            this.btnSiparisiEkle.Size = new System.Drawing.Size(249, 73);
            this.btnSiparisiEkle.TabIndex = 8;
            this.btnSiparisiEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisiEkle.UseVisualStyleBackColor = true;
            this.btnSiparisiEkle.Click += new System.EventHandler(this.btnSiparisiEkle_Click);
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.HorizontalScrollbar = true;
            this.lbxSiparisler.ItemHeight = 23;
            this.lbxSiparisler.Location = new System.Drawing.Point(283, 13);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(529, 487);
            this.lbxSiparisler.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(430, 524);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(20, 23);
            this.lblToplamTutar.TabIndex = 11;
            this.lblToplamTutar.Text = "0";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(581, 513);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(231, 84);
            this.btnSiparisiTamamla.TabIndex = 12;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 605);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.btnSiparisiEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBoyutlar);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxLogo);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.grpBoyutlar.ResumeLayout(false);
            this.grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.GroupBox grpBoyutlar;
        private System.Windows.Forms.RadioButton rdoBuyuk;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.RadioButton rdoKucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Button btnSiparisiEkle;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisiTamamla;
    }
}

