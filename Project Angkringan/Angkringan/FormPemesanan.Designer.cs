namespace Project_Angkringan.Angkringan
{
    partial class FormPemesanan
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
            this.dataGridViewstok = new System.Windows.Forms.DataGridView();
            this.buttontambah = new System.Windows.Forms.Button();
            this.buttonpesan = new System.Windows.Forms.Button();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxharga = new System.Windows.Forms.TextBox();
            this.labeltotal = new System.Windows.Forms.Label();
            this.dataGridViewpesanan = new System.Windows.Forms.DataGridView();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.labelUangKembalian = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUangBayar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpesanan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewstok
            // 
            this.dataGridViewstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstok.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewstok.Name = "dataGridViewstok";
            this.dataGridViewstok.RowTemplate.Height = 25;
            this.dataGridViewstok.Size = new System.Drawing.Size(354, 203);
            this.dataGridViewstok.TabIndex = 0;
            // 
            // buttontambah
            // 
            this.buttontambah.Location = new System.Drawing.Point(113, 367);
            this.buttontambah.Name = "buttontambah";
            this.buttontambah.Size = new System.Drawing.Size(149, 23);
            this.buttontambah.TabIndex = 1;
            this.buttontambah.Text = "Tambah Pesanan";
            this.buttontambah.UseVisualStyleBackColor = true;
            // 
            // buttonpesan
            // 
            this.buttonpesan.Location = new System.Drawing.Point(307, 287);
            this.buttonpesan.Name = "buttonpesan";
            this.buttonpesan.Size = new System.Drawing.Size(75, 23);
            this.buttonpesan.TabIndex = 2;
            this.buttonpesan.Text = "Pesan";
            this.buttonpesan.UseVisualStyleBackColor = true;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(257, 298);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(100, 23);
            this.textBoxJumlah.TabIndex = 3;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(100, 265);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 23);
            this.textBoxname.TabIndex = 4;
            // 
            // textBoxharga
            // 
            this.textBoxharga.Location = new System.Drawing.Point(100, 316);
            this.textBoxharga.Name = "textBoxharga";
            this.textBoxharga.Size = new System.Drawing.Size(100, 23);
            this.textBoxharga.TabIndex = 5;
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(6, 210);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(13, 15);
            this.labeltotal.TabIndex = 6;
            this.labeltotal.Text = "0";
            // 
            // dataGridViewpesanan
            // 
            this.dataGridViewpesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpesanan.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewpesanan.Name = "dataGridViewpesanan";
            this.dataGridViewpesanan.RowTemplate.Height = 25;
            this.dataGridViewpesanan.Size = new System.Drawing.Size(376, 168);
            this.dataGridViewpesanan.TabIndex = 7;
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.AutoSize = true;
            this.labelTotalBayar.Location = new System.Drawing.Point(6, 225);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(13, 15);
            this.labelTotalBayar.TabIndex = 10;
            this.labelTotalBayar.Text = "0";
            // 
            // labelUangKembalian
            // 
            this.labelUangKembalian.AutoSize = true;
            this.labelUangKembalian.Location = new System.Drawing.Point(6, 258);
            this.labelUangKembalian.Name = "labelUangKembalian";
            this.labelUangKembalian.Size = new System.Drawing.Size(13, 15);
            this.labelUangKembalian.TabIndex = 12;
            this.labelUangKembalian.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewstok);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.textBoxharga);
            this.groupBox1.Controls.Add(this.buttontambah);
            this.groupBox1.Controls.Add(this.textBoxJumlah);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 411);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Harga Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Menu Pilihan";
            // 
            // textBoxUangBayar
            // 
            this.textBoxUangBayar.Location = new System.Drawing.Point(136, 240);
            this.textBoxUangBayar.Name = "textBoxUangBayar";
            this.textBoxUangBayar.Size = new System.Drawing.Size(100, 23);
            this.textBoxUangBayar.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridViewpesanan);
            this.groupBox2.Controls.Add(this.textBoxUangBayar);
            this.groupBox2.Controls.Add(this.labeltotal);
            this.groupBox2.Controls.Add(this.labelUangKembalian);
            this.groupBox2.Controls.Add(this.buttonpesan);
            this.groupBox2.Controls.Add(this.labelTotalBayar);
            this.groupBox2.Location = new System.Drawing.Point(400, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 316);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Belanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "KASIR ANGKRINGAN GACOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Uang Pembayaran";
            // 
            // FormPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPemesanan";
            this.Text = "FormPemesanan";
            this.Load += new System.EventHandler(this.FormPemesanan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpesanan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewstok;
        private Button buttontambah;
        private Button buttonpesan;
        private TextBox textBoxJumlah;
        private TextBox textBoxname;
        private TextBox textBoxharga;
        private Label labeltotal;
        private DataGridView dataGridViewpesanan;
        private Label labelTotalBayar;
        private Label labelUangKembalian;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxUangBayar;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}