using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppSoftWares
{
    public class AccessDataBase
    {
        public static SqlConnection sqlcon;
        public static SqlCommand sqlcom;
        public static DataTable dataTable;
        public static SqlDataAdapter sqldataAdapter;
        public static SqlDataReader sqldataReader;

        public void ConnectionData()
        {
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = @"Data Source = . ; Initial Catalog = SoftWareDatabase ; Integrated Security = true;";
            sqlcon.Open();
        }

        public void DisConnectData()
        {
            sqlcon.Close();
        }

        public int NonQuery(string sql)
        {
            ConnectionData();
            sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.Connection = sqlcon;
            return sqlcom.ExecuteNonQuery();
        }

        public int SclarQuery(string sql)
        {
            ConnectionData();
            sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.Connection = sqlcon;
            int c = Convert.ToInt32(sqlcom.ExecuteScalar().ToString());
            return c;
        }
        public decimal SelectdecimalQuery(string sql)
        {

            ConnectionData();
            sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.Connection = sqlcon;
            decimal dc=decimal.Parse(sqlcom.ExecuteScalar().ToString());
            sqlcon.Close();
            return dc;
            
        }
        public string SelectQuery(string sql)
        {
            ConnectionData();
            sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.Connection = sqlcon;
            return sqlcom.ExecuteScalar().ToString();
        }

        public DataTable SelectLike(string sql)
        {
            ConnectionData();
            sqldataAdapter = new SqlDataAdapter(sql, sqlcon);
            dataTable = new DataTable();
            sqldataAdapter.Fill(dataTable);
            return dataTable;
        }

        public int SelectQuerys(string sql)
        {
            ConnectionData();
            sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.Connection = sqlcon;
            return Convert.ToInt32(sqlcom.ExecuteScalar().ToString());
        }
    }
}
