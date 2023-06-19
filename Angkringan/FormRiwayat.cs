using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Angkringan.Angkringan
{
    public partial class FormRiwayat : Form
    {
        string connetionString = "server=localhost;database=angkringan;uid=root;pwd=\"\";";
        public FormRiwayat()
        {
            InitializeComponent();
        }

        private void TampilkanDaftarPesanan()
        {
            // Menghapus kolom yang sudah ada sebelumnya
            dataGridViewDaftarPesanan.Columns.Clear();

            // Menambahkan kolom pada DataGridView
            dataGridViewDaftarPesanan.Columns.Add("pemesanan_id", "Pemesanan ID");
            dataGridViewDaftarPesanan.Columns.Add("tanggal", "Tanggal");
            dataGridViewDaftarPesanan.Columns.Add("nama", "Nama Item");
            dataGridViewDaftarPesanan.Columns.Add("jumlah", "Jumlah");
            dataGridViewDaftarPesanan.Columns.Add("subtotal", "Subtotal");

            using (MySqlConnection connection = new MySqlConnection(connetionString))
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT p.pemesanan_id, p.tanggal, i.nama, d.jumlah, d.subtotal
                            FROM pemesanan p
                            INNER JOIN detail_pemesanan d ON p.pemesanan_id = d.pemesanan_id
                            INNER JOIN stok_angkringan i ON d.item_id = i.id";

                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int pemesananId = reader.GetInt32("pemesanan_id");
                        DateTime tanggal = reader.GetDateTime("tanggal");
                        string namaItem = reader.GetString("nama");
                        int jumlah = reader.GetInt32("jumlah");
                        decimal subtotal = reader.GetDecimal("subtotal");

                        dataGridViewDaftarPesanan.Rows.Add(pemesananId, tanggal, namaItem, jumlah, subtotal);
                    }
                }
            }
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            TampilkanDaftarPesanan();
        }

        private void dataGridViewDaftarPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
