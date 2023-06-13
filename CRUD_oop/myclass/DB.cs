using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD_oop.myclass
{
    internal class DB
    {
        public MySqlConnection con;

        public DB()
        {
            string host = "127.0.0.1";
            string db = "personal_schema";
            string port = "3306";
            string user = "root";
            string password = "";
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + "; username =" + user + "; password =" + password + "; SslMode = none";
            con = new MySqlConnection(constring);

        }
    }

    class CRUD : DB
    {
        // Properties 
        public string name { set; get; } 
        public string number  { set; get; }
        public string address { set; get; }
        public string id { set; get; }

      

        // Read Properties
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();



        // Create Function
        public void Create_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `test_c#` (`fullname`,`address`,`mobile_number`) VALUES(@name,@address,@mobile)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@mobile", MySqlDbType.VarChar).Value=number;
                cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }




        // Update Function
        public void Update_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE `test_c#` SET fullname=@name, address=@address, mobile_number=@mobile WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = number;
                cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        // Delete Function 
        public void Delete_data() 
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM `test_c#` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        // Read Function
        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `test_c#`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query,con);
            MDA.Fill(ds);
            dt = ds.Tables[0];  
        }
    }
}
