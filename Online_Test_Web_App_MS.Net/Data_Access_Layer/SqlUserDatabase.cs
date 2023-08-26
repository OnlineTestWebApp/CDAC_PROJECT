using Business_Object_Layer;
using System;
using System.Data.SqlClient;


namespace Data_Access_Layer
{
    public class SqlUserDatabase
    {
        String query;
        User user = new User();

        SqlConnection con = new SqlConnection($"data source=RAMENDRA\\SQLEXPRESS; Initial Catalog = user; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();

        public String login(String username, String password)
        {

            cmd.Connection = con;
            con.Open();

            query = $"Select privilege from usertable where user_name='{username}' and password= '{password}'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String privilege = reader.GetString(0);
            con.Close();

            return privilege;
        }

        public void regestration(String username, String password, String privilege)
        {
            cmd.Connection = con;

            con.Open();
            query = $"insert into usertable values('{username}','{password}','{privilege}')";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            con.Close();
        }
    }
}
