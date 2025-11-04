using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassesShop
{
    class DBobj
    {
        public DBobj(){ }

        private static OleDbConnection MakeConnection()
        {
            OleDbConnection c = new OleDbConnection();
            String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\glasses1.accdb;Persist Security Info=false";
            c.ConnectionString = connection;
            c.Open();
            return c;
        }
        public static DataTable fill_grid(string strSql)
        {
            OleDbConnection c = MakeConnection();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSql;
            comm.Connection = c;
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(strSql, c);
            da.Fill(dt);
            c.Close();
            return dt;
        }
        public static void ChangeTable(string strSql)
        {
            OleDbConnection c = MakeConnection();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSql;
            comm.Connection = c;
            comm.ExecuteNonQuery();
            c.Close();

        }

    }
}
