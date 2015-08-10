using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace cyberman_msa
{
    class MSAConnection
    {
        public static OleDbConnection conexion = null;
        public static OleDbConnection getCon()
        {
            if (conexion == null)
            {
                OleDbConnectionStringBuilder b = new OleDbConnectionStringBuilder();
                b.Provider = "Microsoft.ACE.OLEDB.12.0";
                b.DataSource = "cyberman.accdb";
                conexion = new OleDbConnection(b.ToString());
                conexion.Open();
            }
            return conexion;
        }

        public static void execute(String sql) {
            OleDbCommand cmd = new OleDbCommand(sql, getCon());
            cmd.ExecuteNonQuery();
        }

        public static OleDbDataReader read(String sql) {
            OleDbCommand cmd = new OleDbCommand(sql, getCon());
            return cmd.ExecuteReader();
        }
    }
}
