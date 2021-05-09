using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class ID
    {
        public ID()
        {
            String x = "BEGIN TRAN T1" +
                        "USE DB_POS; " +
                        "UPDATE TBL_IDX_BARANG SET IDX = (SELECT MAX(idx) FROM TBL_IDX_BARANG) +1" +
                        "SELECT* FROM TBL_IDX_BARANG WITH(UPDLOCK);" +
                        "WAITFOR DELAY '00:00:05'" +
                        "COMMIT";
        }
    }
}
