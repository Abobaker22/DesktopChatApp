using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace CLsChat
{
    internal static class Ado
    {
        private static SqlConnection con = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        public static int SenderID; // gets value when i login
        public static List<int> RecieverIDs = new List<int>(); // could be one or more and gets value when i checkbox all
        //public static DataTable InboxDt = new DataTable();
        
        public static void OpenConnection()
        { 
            con.ConnectionString = "Server=sql1002.site4now.net;Database=db_ab1ea1_abobaker77;User Id=db_ab1ea1_abobaker77_admin;Password=x#Nmw_AQJq8#_p2;";
            con.Open();
            cmd.Connection = con;
        }

        public static void CloseConnection() 
        {
            con.Close();
        }

        public static void ExecuteNonQuery(string command)
        {
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }
        public static string ValidateLogin(string command)
        {
            string result = null;
            cmd.CommandText = command;
            if (cmd.ExecuteScalar() == null)
            {
                return result;
            }
            result = cmd.ExecuteScalar().ToString();
            SenderID = int.Parse(result);
            return result;
        }
        public static SqlDataReader ExecuteQuery(string command)
        {
            cmd.CommandText = command; 
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static List<string> GetUsers(SqlDataReader reader, string SelectedColummn)
        { 
            List<string> Users = new List<string>();
            while (reader.Read()) 
            {
                // to handle DB nulls
                if (reader[$"{SelectedColummn}"] == DBNull.Value)
                {
                    Users.Add("");
                }
                else
                {
                    Users.Add(reader[$"{SelectedColummn}"].ToString());
                }
            }
            reader.Close();
            return Users;
        }
    }
}
