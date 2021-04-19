using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace POS.Forms
{
    public partial class FormDatabase : Form
    {
        Konfigurasi konfigurasi;
        String server, instance, username, password, database;

        private void cmbDatabase_DropDown(object sender, EventArgs e)
        {
            
            try
            {
                String conStr;
                server = txtServer.Text;
                instance = txtInstance.Text;
                username = txtUsername.Text;
                password = txtPassword.Text;

                if (instance == null)
                    conStr = String.Format("Server={0};User Id={2};Password={3};", server, database, username, password);
                else
                    conStr = String.Format("Server={0}\\{4};User Id={2};Password={3};", server, database, username, password, instance);

                cmbDatabase.Items.Clear();
                SqlConnection conn = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases; ", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbDatabase.Items.Add(reader["name"]);
                }
                conn.Close();
                
                //MessageBox.Show(konfigurasi.getKoneksi().ConnectionString);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
        }

        public FormDatabase()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();

                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                server = (String)reg.GetValue("server");
                instance = (String)reg.GetValue("instance");
                username = (String)reg.GetValue("userID");
                password = (String)reg.GetValue("password");
                database = (String)reg.GetValue("database");
                txtServer.Text = server;
                txtInstance.Text = instance;
                txtUsername.Text = username;
                txtPassword.Text = password;
                cmbDatabase.Text = database;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                server = txtServer.Text;
                instance = txtInstance.Text;
                username = txtUsername.Text;
                password = txtPassword.Text;
                database = cmbDatabase.Text;
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                reg.SetValue("server", server);
                reg.SetValue("instance", instance);
                reg.SetValue("userID", username);
                reg.SetValue("password", password);
                reg.SetValue("database", database);
                MessageBox.Show("Tampilan berhasil disimpan");
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
