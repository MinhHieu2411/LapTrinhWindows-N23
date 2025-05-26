using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace btln21
{
    internal class DatabaseHelper
    {
       static string connectionString = "Data Source=DESKTOP-526I6E5;Initial Catalog=QLDL;Integrated Security=True;TrustServerCertificate=True;";

        //ket noi database
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        //thuc hien query
        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        //kiem tra tai khoan mat khau dang nhap
        public static bool checkLogin(string username, string password) 
        {
            string query = "SELECT COUNT(*) FROM Admin WHERE username = @username AND password = @password";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                int c = (int)command.ExecuteScalar();
                return c > 0;
            }
        }
        //kiem tra id trung lap khi them
        public static bool checkID(string id, string table, string ifOfTable)
        {
            string query = "Select * from @table where @idOfTable = @id";

            using (SqlConnection conn = GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@id", id);

                return (int)command.ExecuteScalar() > 0;
            }
        }
        //them hdv vao database
        public static bool AddTourGuide(string id, string name, int year, string phone, string address, string works, decimal salary)
        {
            string query = @"INSERT INTO TourGuide VALUES (@id, @name, @year, @phone, @address, @works, @salary)";

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@works", works);
                cmd.Parameters.AddWithValue("@salary", salary);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
