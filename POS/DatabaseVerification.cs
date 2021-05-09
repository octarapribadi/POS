using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using Microsoft.Win32;

namespace POS
{
    class DatabaseVerification
    {
        Konfigurasi konfigurasi;
        SqlConnection koneksi;
        SqlCommand cmd;
        String database;
        RegistryKey reg;
        public DatabaseVerification()
        {
            konfigurasi = new Konfigurasi();
            koneksi = konfigurasi.getKoneksi();
            reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
            database = (String)reg.GetValue("database");
        }

        public Boolean verify()
        {
            try
            {
                XmlReader reader;
                reader = XmlReader.Create("database.xml");
                koneksi.Open();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "table")
                    {
                        
                        cmd = new SqlCommand(String.Format("select count(TABLE_NAME) from {0}.INFORMATION_SCHEMA.TABLES where TABLE_NAME = '{1}'",database,reader.GetAttribute("name")), koneksi);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                        {
                            cmd = new SqlCommand(reader.GetAttribute("tblstring"), koneksi);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine(reader.GetAttribute("name") + " berhasil ditambahkan!");
                        }
                        
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
