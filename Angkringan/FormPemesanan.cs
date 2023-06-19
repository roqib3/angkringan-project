using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Project_Angkringan.Angkringan
{
    public partial class FormPemesanan : Form
    {
        private int selectedId;
        int pemesananId;
        private List<Item> items;
        private decimal total;
        private string connectionString = "server=localhost;database=angkringan;uid=root;pwd=\"\";";

        public FormPemesanan()
        {
            InitializeComponent();
            // Inisialisasi TextBox untuk uang bayar
            TextBox textBoxUangBayar = new TextBox();
            textBoxUangBayar.Location = new Point(12, 260);
            textBoxUangBayar.Size = new Size(100, 20);
            this.Controls.Add(textBoxUangBayar);

            // Inisialisasi Label untuk total bayar
            Label labelTotalBayar = new Label();
            labelTotalBayar.Location = new Point(12, 290);
            labelTotalBayar.AutoSize = true;
            this.Controls.Add(labelTotalBayar);

            // Inisialisasi Label untuk uang kembalian
            Label labelUangKembalian = new Label();
            labelUangKembalian.Location = new Point(12, 320);
            labelUangKembalian.AutoSize = true;
            this.Controls.Add(labelUangKembalian);
            items = new List<Item>();
            total = 0;

            InitializeDataGridViewPesanan();
            // Mengikat event click untuk tombol "Tambah" dan "Pesan"
            buttontambah.Click += buttontambah_Click;
            buttonpesan.Click += buttonpesan_Click;

        }
        private void tampilkanData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM stok_angkringan", connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewstok.DataSource = dt;
                }
            }
        }
        private void dataGridViewstok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewstok.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                textBoxname.Text = row.Cells["Nama"].Value.ToString();
                textBoxharga.Text = row.Cells["Harga"].Value.ToString();
            }
        }
        private void FormPemesanan_Load(object sender, EventArgs e)
        {
            dataGridViewstok.CellClick += dataGridViewstok_CellClick;
            tampilkanData();
        }

        private void buttontambah_Click(object sender, EventArgs e)
        {
            if (selectedId != 0 && !string.IsNullOrEmpty(textBoxJumlah.Text))
            {
                if (int.TryParse(textBoxJumlah.Text, out int jumlah) && decimal.TryParse(textBoxharga.Text, out decimal harga))
                {
                    decimal subtotal = jumlah * harga;

                    items.Add(new Item(selectedId, textBoxname.Text, jumlah, subtotal));
                    total += subtotal;

                    dataGridViewpesanan.Rows.Add(selectedId, textBoxname.Text, jumlah, harga, subtotal);

                    labeltotal.Text = "Total: Rp " + total.ToString();
                    textBoxname.Clear();
                    textBoxharga.Clear();
                    textBoxJumlah.Clear();
                }
                else
                {
                    MessageBox.Show("Jumlah atau harga tidak valid.");
                }
            }
            else
            {
                MessageBox.Show("Pilih item dan masukkan jumlah terlebih dahulu.");
            }
        }
        private void InitializeDataGridViewPesanan()
        {
            dataGridViewpesanan.ColumnCount = 5;
            dataGridViewpesanan.Columns[0].Name = "Id";
            dataGridViewpesanan.Columns[1].Name = "Nama";
            dataGridViewpesanan.Columns[2].Name = "Jumlah";
            dataGridViewpesanan.Columns[3].Name = "Harga";
            dataGridViewpesanan.Columns[4].Name = "Subtotal";
        }
        private void UpdateTotalHarga()
        {
            decimal totalHarga = 0;

            foreach (DataGridViewRow row in dataGridViewpesanan.Rows)
            {
                int jumlahPesanan = Convert.ToInt32(row.Cells["Jumlah"].Value);
                decimal hargaItem = Convert.ToDecimal(row.Cells["Harga"].Value);
                decimal subtotal = jumlahPesanan * hargaItem;
                totalHarga += subtotal;
            }

            //labelTotalHarga.Text = "Total Harga: " + totalHarga.ToString("C");
        }

        private void buttonpesan_Click(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                // Mengambil uang bayar dari TextBox
                if (decimal.TryParse(textBoxUangBayar.Text, out decimal uangBayar))
                {
                    // Menghitung total bayar
                    decimal totalBayar = total;

                    // Menampilkan total bayar
                    labelTotalBayar.Text = "Total Bayar: Rp " + totalBayar.ToString();

                    // Memeriksa apakah uang bayar cukup
                    if (uangBayar >= totalBayar)
                    {
                        // Menghitung uang kembalian
                        decimal uangKembalian = uangBayar - totalBayar;

                        // Memperbarui label uang kembalian
                        labelUangKembalian.Text = "Uang Kembalian: Rp " + uangKembalian.ToString();

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            using (MySqlTransaction transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    bool stokTersedia = true;

                                    // Memeriksa stok barang
                                    foreach (Item item in items)
                                    {
                                        MySqlCommand checkCmd = connection.CreateCommand();
                                        checkCmd.Transaction = transaction;
                                        checkCmd.CommandText = "SELECT tersedia FROM stok_angkringan WHERE id = @item_id";
                                        checkCmd.Parameters.AddWithValue("@item_id", item.Id);
                                        int tersedia = Convert.ToInt32(checkCmd.ExecuteScalar());

                                        if (tersedia < item.Jumlah)
                                        {
                                            stokTersedia = false;
                                            break;
                                        }
                                    }

                                    if (stokTersedia)
                                    {
                                        // Membuat data pemesanan baru di tabel "pemesanan"
                                        MySqlCommand cmd = connection.CreateCommand();
                                        cmd.Transaction = transaction;
                                        cmd.CommandText = "INSERT INTO pemesanan (tanggal) VALUES (@tanggal)";
                                        cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                                        cmd.ExecuteNonQuery();

                                        // Mendapatkan ID pemesanan terakhir
                                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                                        int pemesananId = Convert.ToInt32(cmd.ExecuteScalar());

                                        // Menyimpan detail pemesanan di tabel "detail_pemesanan"
                                        foreach (Item item in items)
                                        {
                                            cmd.CommandText = "INSERT INTO detail_pemesanan (pemesanan_id, item_id, jumlah, subtotal) VALUES (@pemesanan_id, @item_id, @jumlah, @subtotal)";
                                            cmd.Parameters.Clear();
                                            cmd.Parameters.AddWithValue("@pemesanan_id", pemesananId);
                                            cmd.Parameters.AddWithValue("@item_id", item.Id);
                                            cmd.Parameters.AddWithValue("@jumlah", item.Jumlah);
                                            cmd.Parameters.AddWithValue("@subtotal", item.Subtotal);
                                            cmd.ExecuteNonQuery();
                                        }

                                        transaction.Commit();

                                        // Mengurangi stok item yang dipesan dari tabel "stok_angkringan"
                                        foreach (Item item in items)
                                        {
                                            cmd.CommandText = "UPDATE stok_angkringan SET tersedia = tersedia - @jumlah WHERE id = @item_id";
                                            cmd.Parameters.Clear();
                                            cmd.Parameters.AddWithValue("@jumlah", item.Jumlah);
                                            cmd.Parameters.AddWithValue("@item_id", item.Id);
                                            cmd.ExecuteNonQuery();
                                        }

                                        MessageBox.Show("Pesanan berhasil disimpan.");
                                        items.Clear();
                                        total = 0;
                                        dataGridViewpesanan.Rows.Clear();
                                        labeltotal.Text = "Total: Rp 0";
                                        tampilkanData(); // Menampilkan stok terbaru
                                        textBoxUangBayar.Clear();
                                        labelUangKembalian.Text = "Total: Rp 0";
                                        labelTotalBayar.Text = "Total: Rp 0";
                                    }
                                    else
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show("Stok barang tidak mencukupi.");
                                        textBoxUangBayar.Clear(); // Menghapus nilai di TextBox uang bayar
                                        dataGridViewpesanan.Rows.Clear();
                                        labelUangKembalian.Text = "Total: Rp 0";
                                        labelTotalBayar.Text = "Total: Rp 0";

                                    }
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Gagal menyimpan pesanan: " + ex.Message);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uang bayar tidak cukup.");
                    }
                }
                else
                {
                    MessageBox.Show("Uang bayar tidak valid.");
                }
            }
            else
            {
                MessageBox.Show("Tambahkan item terlebih dahulu ke dalam pesanan.");
            }
        }

        public class Item
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public int Jumlah { get; set; }
            public decimal Subtotal { get; set; }

            public Item(int id, string nama, int jumlah, decimal subtotal)
            {
                Id = id;
                Nama = nama;
                Jumlah = jumlah;
                Subtotal = subtotal;
            }
        }

        private void FormPemesanan_Load_1(object sender, EventArgs e)
        {
            tampilkanData();
            dataGridViewstok.CellClick += dataGridViewstok_CellClick;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}