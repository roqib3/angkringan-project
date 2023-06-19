using System;
using MySql.Data.MySqlClient;
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
    public partial class ManajamenStok : Form
    {
        int selectedId;
        string connetionString = "server=localhost;database=angkringan;uid=root;pwd=\"\";";


        public ManajamenStok()
        {
            InitializeComponent();

        }

        private void ManajamenStok_Load(object sender, EventArgs e)
        {
            tampilkanData();
            TampilkanDaftarPesanan();
        }

        private void buttoninput_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connetionString))
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO stok_angkringan (nama,tersedia,harga) Values (@nama,@tersedia,@harga)";
                cmd.Parameters.AddWithValue("@nama", textBoxname.Text);
                cmd.Parameters.AddWithValue("@tersedia", textBoxstok.Text);
                cmd.Parameters.AddWithValue("@harga", textBoxharga.Text);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Input data berhasil");
                    tampilkanData();
                    textBoxname.Clear();
                    textBoxstok.Clear();
                    textBoxharga.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi gagal\n" + ex.Message);
                }
            }

        }
        private void tampilkanData()
        {
            using (MySqlConnection connection = new MySqlConnection(connetionString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM stok_angkringan", connection);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "sangkringan");
                dataGridViewstok.DataSource = ds.Tables["sangkringan"].DefaultView;
            }

        }

        private void dataGridViewstok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(dataGridViewstok.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show("Nama: " + selectedId);
            textBoxname.Text = dataGridViewstok.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxstok.Text = dataGridViewstok.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxharga.Text = dataGridViewstok.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connetionString))
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE stok_angkringan SET Nama=@nama, Tersedia=@tersedia, Harga=@harga WHERE Id=@id";
                cmd.Parameters.AddWithValue("@nama", textBoxname.Text);
                cmd.Parameters.AddWithValue("@tersedia", textBoxstok.Text);
                cmd.Parameters.AddWithValue("@harga", textBoxharga.Text);
                cmd.Parameters.AddWithValue("@id", selectedId);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update data berhasil");
                    tampilkanData();
                    textBoxname.Clear();
                    textBoxstok.Clear();
                    textBoxharga.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connetionString))
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM stok_angkringan WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", selectedId);
                DialogResult dialogResult = MessageBox.Show("Anda Yakin ingin menghapus data dengan id : " + selectedId + "?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Hapus Data Berhasil !");
                        tampilkanData();
                        textBoxname.Clear();
                        textBoxstok.Clear();
                        textBoxharga.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hapus Data tidak berhasil" + ex.Message);
                    }
                }
            }
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
        private void ManajamenStok_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the application when ManajamenStok form is closed
            Application.Exit();
        }
    }
}
