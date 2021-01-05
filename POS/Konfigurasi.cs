using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;

namespace POS
{
    class Konfigurasi
    {

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

        private String connectionString = POS.Properties.Settings.Default.DB_POSConnectionString;
        private String user="admin";
        private Orientation splitContainerOrientation = Orientation.Vertical;
        public int splitterDistance = 400;
        List<RegistryTable> registryTables;

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
            //registry
            registryTables = new List<RegistryTable>();
            registryTables.Add(new POS.Konfigurasi.RegistryTable("fontFamily",RegistryValueKind.String,"Courier New"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("fontSize", RegistryValueKind.DWord, 12.0));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("printerName", RegistryValueKind.String, "Printer"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("server", RegistryValueKind.String, "localhost"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("instance", RegistryValueKind.String, "sqlexpress"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("password", RegistryValueKind.String, ""));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("database", RegistryValueKind.String, "db_pos"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("userID", RegistryValueKind.String, ""));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("fontColor", RegistryValueKind.String, "Black"));
            registryTables.Add(new POS.Konfigurasi.RegistryTable("backColor", RegistryValueKind.String, "White"));
        }

        public void createRegistryBaseDir()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
            if (reg == null)
            {
                Registry.CurrentUser.CreateSubKey(@"Software\POS");
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
