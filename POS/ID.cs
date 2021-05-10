using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace POS
{
    class ID
    {
        RegistryKey reg;
        Konfigurasi konfigurasi;
        public ID()
        {
            konfigurasi = new Konfigurasi();
            /*String x = "BEGIN TRAN T1" +
                        "USE DB_POS; " +
                        "UPDATE TBL_IDX_BARANG SET IDX = (SELECT MAX(idx) FROM TBL_IDX_BARANG) +1" +
                        "SELECT* FROM TBL_IDX_BARANG WITH(UPDLOCK);" +
                        "WAITFOR DELAY '00:00:05'" +
                        "COMMIT";
    */    
    }
        public Int64 getID(String tableName)
        {
            Int64 idx = -1;
            reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
            String database = reg.GetValue("database").ToString();
            String cmdString = String.Format("BEGIN TRAN T " +
                                                "USE {0}; " +
                                                "IF NOT EXISTS (SELECT idx FROM {1} WITH(UPDLOCK)) " +
                                                "BEGIN INSERT INTO {1}(idx, tanggal) values(1,GETDATE()); END " +
                                                "ELSE " +
                                                "BEGIN UPDATE {1} set idx = idx + 1, tanggal = GETDATE(); END " +
                                                "SELECT idx FROM {1} WITH(UPDLOCK) " +
                                             "COMMIT", database,tableName);
            SqlConnection koneksi = konfigurasi.getKoneksi();
            //Console.WriteLine(cmdString);
            try
            {
                
                koneksi.Open();
                SqlCommand cmd = new SqlCommand(cmdString, koneksi);
                idx = Convert.ToInt64(cmd.ExecuteScalar());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                koneksi.Close();
            }
            return idx;
        }
    }
}
