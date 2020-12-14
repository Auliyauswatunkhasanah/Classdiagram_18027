using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classdiagram
{
    public class Transaksi : Data_Buku
    {
        public int id_anggota
        {
            get => default(int);
            set
            {
            }
        }

        public int id_admin
        {
            get => default(int);
            set
            {
            }
        }

        public int tgl_pinjam
        {
            get => default(int);
            set
            {
            }
        }

        public int tgl_kembali
        {
            get => default(int);
            set
            {
            }
        }

        public Anggota Anggota
        {
            get => default(Anggota);
            set
            {
            }
        }

        public void insert_transaksi()
        {
            throw new System.NotImplementedException();
        }

        public void update_transaksi()
        {
            throw new System.NotImplementedException();
        }

        public void delete_transaksi()
        {
            throw new System.NotImplementedException();
        }
    }
}