using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_714220040_714220046.controller;
using TB_714220040_714220046.model;

namespace TB_714220040_714220046
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;


        public void Tampil()
        {
            dgBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang ORDER BY nama_barang");

            dgBarang.Columns[0].HeaderText = "ID";
            dgBarang.Columns[1].HeaderText = "Nama Barang";
            dgBarang.Columns[2].HeaderText = "Harga Barang";
        }

        public FormBarang()
        {
            InitializeComponent();
            dgBarang.ColumnHeaderMouseClick += dgBarang_ColumnHeaderMouseClick;

        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void FormatDigit(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.All(char.IsDigit))
            {
                string number = textBox.Text.Replace(".", "");

                number = string.Format("{0:#,##0}", double.Parse(number));

                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void dgBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            dgBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tbCari.Text + "' '%' OR nama_barang LIKE '%' '" + tbCari.Text + "' '%' OR harga LIKE '%' '" + tbCari.Text + "' '%' \r\n");

        }

        private void dgBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgBarang.Rows.Count)
            {
                tbNamaBarang.Text = dgBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbHargaBarang.Text = dgBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        public void ResetForm()
        {
            tbNamaBarang.Text = "";
            tbHargaBarang.Text = "";
            tbCari.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || (tbNamaBarang.Text).All(Char.IsNumber) || tbHargaBarang.Text == "" || (tbHargaBarang.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Barang brg = new Barang();
                m_barang.NamaBarang = tbNamaBarang.Text;
                m_barang.Harga = tbHargaBarang.Text;

                brg.Insert(m_barang);
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text != "" || !tbNamaBarang.Text.All(Char.IsNumber) || tbHargaBarang.Text != "" || !tbHargaBarang.Text.All(Char.IsLetter))
            {
                Barang brg = new Barang();
                m_barang.NamaBarang = tbNamaBarang.Text;
                m_barang.Harga = tbHargaBarang.Text;

                brg.Update(m_barang, id_barang);
                ResetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Harap masukkan data dengan benar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                controller.Barang brg = new controller.Barang();
                brg.Delete(id_barang);
                ResetForm();
                Tampil();
            }
        }


        private void dgBarang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string namaKolom = dgBarang.Columns[e.ColumnIndex].Name;
            // Digunakan utk mendapatkan nama kolom yg diklik

            string query = $"SELECT * FROM t_barang ORDER BY ";
            // Memperbarui query SQL berdasarkan kolom yang diklik

            switch (namaKolom)
            {
                case "id_barang":
                case "nama_barang":  
                case "harga":      
                    query += namaKolom;
                    break;
                default:
                    // Kolom default yang akan diurutkan jika nama kolom tidak cocok dengan yang diharapkan
                    query += "id_barang";
                    break;
            }

            dgBarang.DataSource = koneksi.ShowData(query);
        }

        private void dgBarang_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string namaKolom = dgBarang.Columns[e.ColumnIndex].Name;

            string query = $"SELECT * FROM t_barang ORDER BY ";

            switch (namaKolom)
            {
                case "id_barang":
                case "nama_barang":
                case "harga":
                    query += $"{namaKolom} DESC";
                    break;
                default:
                    query += "id_barang";
                    break;
            }

            dgBarang.DataSource = koneksi.ShowData(query);
        }

    }
}
