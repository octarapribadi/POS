using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class Konfigurasi
    {
        private String connectionString = POS.Properties.Settings.Default.DB_POSConnectionString;
        private String user="admin";
        private Orientation splitContainerOrientation = Orientation.Vertical;
        public int splitterDistance = 400;
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
