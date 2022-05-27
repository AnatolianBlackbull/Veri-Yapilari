
namespace Bil204_Ödev_2_3
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDosyaOku = new System.Windows.Forms.Button();
            this.txtOkunacak = new System.Windows.Forms.TextBox();
            this.lblOkunacak = new System.Windows.Forms.Label();
            this.btnYigit = new System.Windows.Forms.Button();
            this.btnAgac = new System.Windows.Forms.Button();
            this.lvAna = new System.Windows.Forms.ListView();
            this.btnIst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDosyaOku
            // 
            this.btnDosyaOku.Location = new System.Drawing.Point(140, 106);
            this.btnDosyaOku.Name = "btnDosyaOku";
            this.btnDosyaOku.Size = new System.Drawing.Size(129, 47);
            this.btnDosyaOku.TabIndex = 0;
            this.btnDosyaOku.Text = "Dosyayı Oku";
            this.btnDosyaOku.UseVisualStyleBackColor = true;
            this.btnDosyaOku.Click += new System.EventHandler(this.btnDosyaOku_Click);
            // 
            // txtOkunacak
            // 
            this.txtOkunacak.Location = new System.Drawing.Point(275, 53);
            this.txtOkunacak.Name = "txtOkunacak";
            this.txtOkunacak.Size = new System.Drawing.Size(399, 27);
            this.txtOkunacak.TabIndex = 1;
            // 
            // lblOkunacak
            // 
            this.lblOkunacak.AutoSize = true;
            this.lblOkunacak.Location = new System.Drawing.Point(140, 53);
            this.lblOkunacak.Name = "lblOkunacak";
            this.lblOkunacak.Size = new System.Drawing.Size(121, 20);
            this.lblOkunacak.TabIndex = 2;
            this.lblOkunacak.Text = "Okunacak Dosya:";
            // 
            // btnYigit
            // 
            this.btnYigit.Location = new System.Drawing.Point(275, 106);
            this.btnYigit.Name = "btnYigit";
            this.btnYigit.Size = new System.Drawing.Size(129, 47);
            this.btnYigit.TabIndex = 3;
            this.btnYigit.Text = "Yığıta Çevir";
            this.btnYigit.UseVisualStyleBackColor = true;
            this.btnYigit.Click += new System.EventHandler(this.btnYigit_Click);
            // 
            // btnAgac
            // 
            this.btnAgac.Location = new System.Drawing.Point(410, 106);
            this.btnAgac.Name = "btnAgac";
            this.btnAgac.Size = new System.Drawing.Size(129, 47);
            this.btnAgac.TabIndex = 4;
            this.btnAgac.Text = "Ağaca Çevir";
            this.btnAgac.UseVisualStyleBackColor = true;
            this.btnAgac.Click += new System.EventHandler(this.btnAgac_Click);
            // 
            // lvAna
            // 
            this.lvAna.HideSelection = false;
            this.lvAna.Location = new System.Drawing.Point(140, 185);
            this.lvAna.Name = "lvAna";
            this.lvAna.Size = new System.Drawing.Size(534, 215);
            this.lvAna.TabIndex = 5;
            this.lvAna.UseCompatibleStateImageBehavior = false;
            // 
            // btnIst
            // 
            this.btnIst.Location = new System.Drawing.Point(545, 106);
            this.btnIst.Name = "btnIst";
            this.btnIst.Size = new System.Drawing.Size(129, 47);
            this.btnIst.TabIndex = 6;
            this.btnIst.Text = "İstatistik Getir";
            this.btnIst.UseVisualStyleBackColor = true;
            this.btnIst.Click += new System.EventHandler(this.btnIst_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIst);
            this.Controls.Add(this.lvAna);
            this.Controls.Add(this.btnAgac);
            this.Controls.Add(this.btnYigit);
            this.Controls.Add(this.lblOkunacak);
            this.Controls.Add(this.txtOkunacak);
            this.Controls.Add(this.btnDosyaOku);
            this.Name = "frmAna";
            this.Text = "Veri Yapıları Ödevi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaOku;
        private System.Windows.Forms.TextBox txtOkunacak;
        private System.Windows.Forms.Label lblOkunacak;
        private System.Windows.Forms.Button btnYigit;
        private System.Windows.Forms.Button btnAgac;
        private System.Windows.Forms.ListView lvAna;
        private System.Windows.Forms.Button btnIst;
    }
}

