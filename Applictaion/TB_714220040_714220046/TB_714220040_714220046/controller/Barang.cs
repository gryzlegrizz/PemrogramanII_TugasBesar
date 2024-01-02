using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_714220040_714220046.model;

namespace TB_714220040_714220046.controller
{
    internal class Barang
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(M_barang barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_barang (id_barang, nama_barang, harga) VALUES('" + barang.ID + "', '" + barang.NamaBarang + "','" + barang.Harga + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(M_barang barang, string id_barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_barang SET nama_barang='" + barang.NamaBarang + "'," + "harga='" + barang.Harga + "' WHERE id_barang = '" + id_barang + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id_barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_barang WHERE id_barang='" + id_barang + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
