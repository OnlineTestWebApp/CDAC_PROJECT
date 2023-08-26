using Business_Object_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class SqlExamDatabase
    {

        String query;
        Exam exam;
        List<Exam> exam_list = new List<Exam>();
        SqlConnection con = new SqlConnection($"data source=RAMENDRA\\SQLEXPRESS; Initial Catalog = user; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();

        public List<Exam> leaderboard()
        {
            cmd.Connection = con;
            con.Open();

            query = "Select * from examtable ";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                while (reader.Read())
                {
                    exam.sessionId = int.Parse(reader[0].ToString());
                    exam.id = reader.GetInt32(1);
                    exam.studentName = reader.GetString(2);
                    exam.subject = reader.GetString(3);
                    exam.marks = reader.GetDecimal(4);
                    exam.percentage = reader.GetDecimal(5);
                    exam_list.Add(exam);
                    Console.WriteLine(exam);
                }
            }
            catch (NullReferenceException) { Console.WriteLine("null@@"); }
            con.Close();

            return exam_list;
        }

        public Exam studentSearch(String name)
        {
            cmd.Connection = con;
            con.Open();

            query = $"Select * from examtable where studentName='{name}'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                exam.sessionId = int.Parse(reader[0].ToString());
                exam.id = reader.GetInt32(1);
                exam.studentName = reader.GetString(2);
                exam.subject = reader.GetString(3);
                exam.marks = reader.GetDecimal(4);
                exam.percentage = reader.GetDecimal(5);
            }

            con.Close();

            return exam;
        }
    }
}
