using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classdiagram
{
    public class Admin : Transaksi
    {
        public int id_admin
        {
            get => default(int);
            set
            {
            }
        }

        public int nama_admin
        {
            get => default(int);
            set
            {
            }
        }

        public Laporan Laporan
        {
            get => default(Laporan);
            set
            {
            }
        }

        public void insert_admin()
        {
            throw new System.NotImplementedException();
        }

        public void update_admin()
        {
            throw new System.NotImplementedException();
        }

        public void delete_admin()
        {
            throw new System.NotImplementedException();
        }
    }
}