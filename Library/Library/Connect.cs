using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class Connect
    {
        DataSet ds;
        public MySqlConnection con;
        public string connectStringg;
        public MySqlDataAdapter adapter;
        public MySqlDataReader dr;
        MySqlCommand cmd;
        public Connect()
        {
            foreach (string sr in File.ReadAllLines("init.txt"))
            {
                connectStringg = sr;
            }
        }

        public DataSet CO(string query)
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            adapter = new MySqlDataAdapter(query, con);
            ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            return ds;
        }
        public void SIDU(string sql)
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandText = sql;
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int ExecuteScalarInt(string sql)
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            MySqlCommand mycommand = con.CreateCommand();
            mycommand.CommandText = sql;
            int value = Convert.ToInt32(mycommand.ExecuteScalar());
            con.Close();
            return value;
        }

        public string ExecuteScalar(string sql)
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            MySqlCommand mycommand = con.CreateCommand();
            mycommand.CommandText = sql;
            object value = mycommand.ExecuteScalar();
            con.Close();
            return value.ToString();
        }

        public DataTable ConDT(string sql)
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            DataTable dt = new DataTable();
            cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


    }
}
