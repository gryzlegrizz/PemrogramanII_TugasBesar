using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_714220040_714220046.model
{
    internal class M_barang
    {
        string id_barang, nama_barang, harga;

        public M_barang()
        {

        }

        public M_barang(string id_barang, string nama_barang, string harga)
        {
            this.id_barang = id_barang;
            this.nama_barang = nama_barang;
            this.harga = harga;
        }

        public string ID { get => id_barang; set => id_barang = value; }
        public string NamaBarang { get => nama_barang; set => nama_barang = value; }
        public string Harga { get => harga; set => harga= value; }
    }
}
