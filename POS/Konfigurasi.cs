using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;
using System.Data.SqlClient;

namespace POS
{
    class Konfigurasi
    {
        private String connectionString = POS.Properties.Settings.Default.DB_POSConnectionString;
        private String user = "admin";
        private Orientation splitContainerOrientation = Orientation.Vertical;
        public int splitterDistance = 400;
        List<RegistryTable> registryTables;
        String server, instance, username, password, database;

        public SqlConnection getKoneksi()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
            String conStr;
            server = (String)reg.GetValue("server");
            instance = (String)reg.GetValue("instance");
            username = (String)reg.GetValue("userID");
            password = (String)reg.GetValue("password");
            database = (String)reg.GetValue("database");
            if (instance == null)
                conStr = String.Format("Server={0};Database={1};User Id={2};Password={3};", server, database, username, password);
            else
                conStr = String.Format("Server={0}\\{4};Database={1};User Id={2};Password={3};", server, database, username, password,instance);
            SqlConnection connection = new SqlConnection(conStr);
            return connection;
        }


        class RegistryTable
        {
            String registryName;
            RegistryValueKind registryType;
            Object registryValue;
            public RegistryTable(String registryName, RegistryValueKind registryType, Object registryValue)
            {
                this.registryName = registryName;
                this.registryType = registryType;
                this.registryValue = registryValue;
            }
            public String getRegistryName()
            {
                return this.registryName;
            }
            public Object getRegistryValue()
            {
                return this.registryValue;
            }
            public RegistryValueKind getRegistryType()
            {
                return this.registryType;
            }

        }

        public Font getFont()
        {
            return new Font(getRegistryValue("fontFamily").ToString(), Convert.ToSingle(getRegistryValue("fontSize")));
        }

        public Color getFontColor()
        {
            return Color.FromName(getRegistryValue("fontColor").ToString());
        }

        public Color getBackColor()
        {
            return Color.FromName(getRegistryValue("backColor").ToString());
        }

        public Konfigurasi()
        {
            
        }

        public void createRegistryBaseDir()
        {

            //registry
            registryTables = new List<RegistryTable>();
            registryTables.Add(new POS.Konfigurasi.RegistryTable("fontFamily", RegistryValueKind.String, "Courier New"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("fontSize", RegistryValueKind.DWord, 12.0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("printerName", RegistryValueKind.String, "Printer"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("server", RegistryValueKind.String, "localhost"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("instance", RegistryValueKind.String, "sqlexpress"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("password", RegistryValueKind.String, ""));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("database", RegistryValueKind.String, "db_pos"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("userID", RegistryValueKind.String, ""));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("fontColor", RegistryValueKind.String, "Black"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("backColor", RegistryValueKind.String, "White"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("kwitansiFontSize", RegistryValueKind.DWord, 8.0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("paperHeight", RegistryValueKind.DWord, 1000.0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("paperWidth", RegistryValueKind.DWord, 305.0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("printerMarginLeft", RegistryValueKind.DWord, 0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("printerMarginRight", RegistryValueKind.DWord, 0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("printerMarginTop", RegistryValueKind.DWord, 0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("printerMarginBottom", RegistryValueKind.DWord, 0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("printerName", RegistryValueKind.DWord, ""));
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
            if (reg == null)
            {
                Registry.CurrentUser.CreateSubKey(@"Software\POS");
                reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                //MessageBox.Show("tes");
            }

            foreach (RegistryTable registryTable in registryTables)
            {
                if (reg.GetValue(registryTable.getRegistryName())==null)
                {
                    reg.SetValue(registryTable.getRegistryName(), registryTable.getRegistryValue(), registryTable.getRegistryType());
                }
            }
            
            reg.Close();
        }

        public Object getRegistryValue(String registryKey)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
            return reg.GetValue(registryKey);
        }

        public void showError(Exception ex)
        {
            MessageBox.Show("Error, hubungi administrator\n" + ex.StackTrace + "\n" + ex.Message);
        }

        public void setSplitContainerOrientation(Orientation orientation)
        {
            splitContainerOrientation = orientation;
        }
        public Orientation getSplitContainerOrientation()
        {
            return splitContainerOrientation;
        }
        public String getUser()
        {
            return this.user;
        }
        public void setUserLogin(String user)
        {
            this.user = user;
        }
        public String getConnectionString()
        {
            return connectionString;
        }
    }
}
