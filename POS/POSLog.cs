using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POS
{
    class POSLog
    {
        Konfigurasi konfigurasi = new Konfigurasi();
        SqlConnection conn;
        SqlCommand cmd;
        public POSLog()
        {
            conn = new SqlConnection(konfigurasi.getConnectionString());
        }
        public void setLogStok(String keterangan)
        {
            try
            {
                String cmdStr = "insert into tbl_log_stok(tanggal_waktu, keterangan) values(@tanggal_waktu, @keterangan)";
                cmd = new SqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@tanggal_waktu", DateTime.Now);
                cmd.Parameters.AddWithValue("@keterangan", keterangan);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
