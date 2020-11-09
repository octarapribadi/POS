using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class AksesKontrol
    {
        private String user, tabel, akses;
        public Boolean getAkses(String user, String tabel, String akses)
        {
            return true;
        }
        public String tampilkanPesanAksesDitolak(String user, String tabel, String akses)
        {
            String s = "User "+ user+" tidak memiliki hak akses "+ akses + " di tabel " + tabel;
            return s;
        }
    }
}
