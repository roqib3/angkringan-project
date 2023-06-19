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
    public partial class Menu_Utama : Form
    {
        FormPemesanan pesan;
        ManajamenStok stok;

        void pesan_FormClosed(Object sender, FormClosedEventArgs e)
        {
            pesan = null;
        }

        void stok_FormClosed(Object sender, FormClosedEventArgs e)
        {
            stok = null;
        }
        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_pemesanan_Click(object sender, EventArgs e)
        {
            if (pesan == null)
            {
                pesan = new FormPemesanan();
                pesan.MdiParent = this;
                pesan.FormClosed += new FormClosedEventHandler(pesan_FormClosed);
                pesan.Show();
            }
            else
            {
                pesan.Activate();
            }
        }

        private void submenu_stok_Click(object sender, EventArgs e)
        {
            if (stok == null)
            {
                stok = new ManajamenStok();
                stok.MdiParent = this;
                stok.FormClosed += new FormClosedEventHandler(stok_FormClosed);
                stok.Show();
            }
            else
            {
                stok.Activate();
            }
        }
    }
}
