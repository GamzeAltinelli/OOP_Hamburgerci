﻿
namespace OOP_Hamburgerci
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxTumSiparisler = new System.Windows.Forms.ListBox();
            this.grpCiro = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.grpToplamSiparisSayisi = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.grpEkstraMalzemeGeliri = new System.Windows.Forms.GroupBox();
            this.lblEkstraMalzemeGeliri = new System.Windows.Forms.Label();
            this.grpSatilanUrunAdedi = new System.Windows.Forms.GroupBox();
            this.lblSatilanUrunAdedi = new System.Windows.Forms.Label();
            this.grpCiro.SuspendLayout();
            this.grpToplamSiparisSayisi.SuspendLayout();
            this.grpEkstraMalzemeGeliri.SuspendLayout();
            this.grpSatilanUrunAdedi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÜM SİPARİŞLER";
            // 
            // lbxTumSiparisler
            // 
            this.lbxTumSiparisler.FormattingEnabled = true;
            this.lbxTumSiparisler.HorizontalScrollbar = true;
            this.lbxTumSiparisler.ItemHeight = 19;
            this.lbxTumSiparisler.Location = new System.Drawing.Point(12, 42);
            this.lbxTumSiparisler.Name = "lbxTumSiparisler";
            this.lbxTumSiparisler.Size = new System.Drawing.Size(245, 327);
            this.lbxTumSiparisler.TabIndex = 1;
            // 
            // grpCiro
            // 
            this.grpCiro.Controls.Add(this.lblCiro);
            this.grpCiro.Location = new System.Drawing.Point(274, 42);
            this.grpCiro.Name = "grpCiro";
            this.grpCiro.Size = new System.Drawing.Size(165, 65);
            this.grpCiro.TabIndex = 2;
            this.grpCiro.TabStop = false;
            this.grpCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiro.ForeColor = System.Drawing.Color.Red;
            this.lblCiro.Location = new System.Drawing.Point(71, 23);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(51, 27);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0,00";
            // 
            // grpToplamSiparisSayisi
            // 
            this.grpToplamSiparisSayisi.Controls.Add(this.lblToplamSiparisSayisi);
            this.grpToplamSiparisSayisi.Location = new System.Drawing.Point(274, 113);
            this.grpToplamSiparisSayisi.Name = "grpToplamSiparisSayisi";
            this.grpToplamSiparisSayisi.Size = new System.Drawing.Size(165, 65);
            this.grpToplamSiparisSayisi.TabIndex = 3;
            this.grpToplamSiparisSayisi.TabStop = false;
            this.grpToplamSiparisSayisi.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            this.lblToplamSiparisSayisi.AutoSize = true;
            this.lblToplamSiparisSayisi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSiparisSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblToplamSiparisSayisi.Location = new System.Drawing.Point(71, 23);
            this.lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            this.lblToplamSiparisSayisi.Size = new System.Drawing.Size(51, 27);
            this.lblToplamSiparisSayisi.TabIndex = 0;
            this.lblToplamSiparisSayisi.Text = "0,00";
            // 
            // grpEkstraMalzemeGeliri
            // 
            this.grpEkstraMalzemeGeliri.Controls.Add(this.lblEkstraMalzemeGeliri);
            this.grpEkstraMalzemeGeliri.Location = new System.Drawing.Point(274, 184);
            this.grpEkstraMalzemeGeliri.Name = "grpEkstraMalzemeGeliri";
            this.grpEkstraMalzemeGeliri.Size = new System.Drawing.Size(165, 65);
            this.grpEkstraMalzemeGeliri.TabIndex = 4;
            this.grpEkstraMalzemeGeliri.TabStop = false;
            this.grpEkstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            this.lblEkstraMalzemeGeliri.AutoSize = true;
            this.lblEkstraMalzemeGeliri.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkstraMalzemeGeliri.ForeColor = System.Drawing.Color.Red;
            this.lblEkstraMalzemeGeliri.Location = new System.Drawing.Point(71, 23);
            this.lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            this.lblEkstraMalzemeGeliri.Size = new System.Drawing.Size(51, 27);
            this.lblEkstraMalzemeGeliri.TabIndex = 0;
            this.lblEkstraMalzemeGeliri.Text = "0,00";
            // 
            // grpSatilanUrunAdedi
            // 
            this.grpSatilanUrunAdedi.Controls.Add(this.lblSatilanUrunAdedi);
            this.grpSatilanUrunAdedi.Location = new System.Drawing.Point(274, 255);
            this.grpSatilanUrunAdedi.Name = "grpSatilanUrunAdedi";
            this.grpSatilanUrunAdedi.Size = new System.Drawing.Size(165, 65);
            this.grpSatilanUrunAdedi.TabIndex = 5;
            this.grpSatilanUrunAdedi.TabStop = false;
            this.grpSatilanUrunAdedi.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdedi
            // 
            this.lblSatilanUrunAdedi.AutoSize = true;
            this.lblSatilanUrunAdedi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatilanUrunAdedi.ForeColor = System.Drawing.Color.Red;
            this.lblSatilanUrunAdedi.Location = new System.Drawing.Point(71, 23);
            this.lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            this.lblSatilanUrunAdedi.Size = new System.Drawing.Size(51, 27);
            this.lblSatilanUrunAdedi.TabIndex = 0;
            this.lblSatilanUrunAdedi.Text = "0,00";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 392);
            this.Controls.Add(this.grpSatilanUrunAdedi);
            this.Controls.Add(this.grpEkstraMalzemeGeliri);
            this.Controls.Add(this.grpToplamSiparisSayisi);
            this.Controls.Add(this.grpCiro);
            this.Controls.Add(this.lbxTumSiparisler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.grpCiro.ResumeLayout(false);
            this.grpCiro.PerformLayout();
            this.grpToplamSiparisSayisi.ResumeLayout(false);
            this.grpToplamSiparisSayisi.PerformLayout();
            this.grpEkstraMalzemeGeliri.ResumeLayout(false);
            this.grpEkstraMalzemeGeliri.PerformLayout();
            this.grpSatilanUrunAdedi.ResumeLayout(false);
            this.grpSatilanUrunAdedi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTumSiparisler;
        private System.Windows.Forms.GroupBox grpCiro;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox grpToplamSiparisSayisi;
        private System.Windows.Forms.Label lblToplamSiparisSayisi;
        private System.Windows.Forms.GroupBox grpEkstraMalzemeGeliri;
        private System.Windows.Forms.Label lblEkstraMalzemeGeliri;
        private System.Windows.Forms.GroupBox grpSatilanUrunAdedi;
        private System.Windows.Forms.Label lblSatilanUrunAdedi;
    }
}