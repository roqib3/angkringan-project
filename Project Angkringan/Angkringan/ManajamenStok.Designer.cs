namespace Project_Angkringan.Angkringan
{
    partial class ManajamenStok
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonhapus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoninput = new System.Windows.Forms.Button();
            this.textBoxstok = new System.Windows.Forms.TextBox();
            this.dataGridViewstok = new System.Windows.Forms.DataGridView();
            this.textBoxharga = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.dataGridViewDaftarPesanan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPesanan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonupdate);
            this.groupBox1.Controls.Add(this.buttonhapus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttoninput);
            this.groupBox1.Controls.Add(this.textBoxstok);
            this.groupBox1.Controls.Add(this.dataGridViewstok);
            this.groupBox1.Controls.Add(this.textBoxharga);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Location = new System.Drawing.Point(44, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Angkringan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga";
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(474, 167);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(75, 23);
            this.buttonupdate.TabIndex = 4;
            this.buttonupdate.Text = "UPDATE";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonhapus
            // 
            this.buttonhapus.Location = new System.Drawing.Point(574, 167);
            this.buttonhapus.Name = "buttonhapus";
            this.buttonhapus.Size = new System.Drawing.Size(75, 23);
            this.buttonhapus.TabIndex = 5;
            this.buttonhapus.Text = "DELETE";
            this.buttonhapus.UseVisualStyleBackColor = true;
            this.buttonhapus.Click += new System.EventHandler(this.buttonhapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jumlah Tersedia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(373, 167);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(75, 23);
            this.buttoninput.TabIndex = 3;
            this.buttoninput.Text = "INPUT";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // textBoxstok
            // 
            this.textBoxstok.Location = new System.Drawing.Point(122, 93);
            this.textBoxstok.Name = "textBoxstok";
            this.textBoxstok.Size = new System.Drawing.Size(161, 23);
            this.textBoxstok.TabIndex = 2;
            // 
            // dataGridViewstok
            // 
            this.dataGridViewstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstok.Location = new System.Drawing.Point(339, 22);
            this.dataGridViewstok.Name = "dataGridViewstok";
            this.dataGridViewstok.RowTemplate.Height = 25;
            this.dataGridViewstok.Size = new System.Drawing.Size(329, 120);
            this.dataGridViewstok.TabIndex = 1;
            this.dataGridViewstok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstok_CellContentClick);
            // 
            // textBoxharga
            // 
            this.textBoxharga.Location = new System.Drawing.Point(122, 142);
            this.textBoxharga.Name = "textBoxharga";
            this.textBoxharga.Size = new System.Drawing.Size(161, 23);
            this.textBoxharga.TabIndex = 1;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(122, 38);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(161, 23);
            this.textBoxname.TabIndex = 0;
            // 
            // dataGridViewDaftarPesanan
            // 
            this.dataGridViewDaftarPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPesanan.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewDaftarPesanan.Name = "dataGridViewDaftarPesanan";
            this.dataGridViewDaftarPesanan.RowTemplate.Height = 25;
            this.dataGridViewDaftarPesanan.Size = new System.Drawing.Size(484, 145);
            this.dataGridViewDaftarPesanan.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDaftarPesanan);
            this.groupBox2.Location = new System.Drawing.Point(166, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 173);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Riwayat Pembelian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ANGKRINGAN GACOR";
            // 
            // ManajamenStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManajamenStok";
            this.Text = "Stok Angkringan";
            this.Load += new System.EventHandler(this.ManajamenStok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPesanan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxstok;
        private TextBox textBoxharga;
        private TextBox textBoxname;
        private DataGridView dataGridViewstok;
        private Button buttoninput;
        private Button buttonupdate;
        private Button buttonhapus;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewDaftarPesanan;
        private GroupBox groupBox2;
        private Label label4;
    }
}