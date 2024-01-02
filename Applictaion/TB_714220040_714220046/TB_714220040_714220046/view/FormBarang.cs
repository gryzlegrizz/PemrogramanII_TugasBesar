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

namespace TB_714220040_714220046
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
            dgBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");

            dgBarang.Columns[0].HeaderText = "ID";
            dgBarang.Columns[1].HeaderText = "Nama Barang";
            dgBarang.Columns[2].HeaderText = "Harga Barang";
        }

        public FormBarang()
        {
            InitializeComponent();
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
            tbNamaBarang.Text = dgBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHargaBarang.Text = dgBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        
    }
}
