
namespace EntityFramework
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txturunAdi = new System.Windows.Forms.TextBox();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.nudstok = new System.Windows.Forms.NumericUpDown();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.cmbtedarikci = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori";
            // 
            // txturunAdi
            // 
            this.txturunAdi.Location = new System.Drawing.Point(64, 86);
            this.txturunAdi.Name = "txturunAdi";
            this.txturunAdi.Size = new System.Drawing.Size(100, 22);
            this.txturunAdi.TabIndex = 5;
            // 
            // nudfiyat
            // 
            this.nudfiyat.Location = new System.Drawing.Point(181, 85);
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(120, 22);
            this.nudfiyat.TabIndex = 6;
            // 
            // nudstok
            // 
            this.nudstok.Location = new System.Drawing.Point(337, 85);
            this.nudstok.Name = "nudstok";
            this.nudstok.Size = new System.Drawing.Size(120, 22);
            this.nudstok.TabIndex = 7;
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(485, 82);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(121, 24);
            this.cmbkategori.TabIndex = 8;
            // 
            // cmbtedarikci
            // 
            this.cmbtedarikci.FormattingEnabled = true;
            this.cmbtedarikci.Location = new System.Drawing.Point(612, 82);
            this.cmbtedarikci.Name = "cmbtedarikci";
            this.cmbtedarikci.Size = new System.Drawing.Size(121, 24);
            this.cmbtedarikci.TabIndex = 9;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(750, 78);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 30);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(831, 78);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 30);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(912, 78);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(88, 30);
            this.btnguncelle.TabIndex = 12;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tedarikçi";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(337, 576);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(221, 22);
            this.txtara.TabIndex = 14;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ürün Adına Göre Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 643);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.cmbtedarikci);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.nudstok);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.txturunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txturunAdi;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.NumericUpDown nudstok;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.ComboBox cmbtedarikci;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label6;
    }
}