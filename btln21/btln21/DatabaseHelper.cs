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

        //ket noi database---------------------------------------------------------------------------------------------------------------------------------------
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        //lay du lieu tu table-----------------------------------------------------------------------------------------------------------------------------------------
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

        //kiem tra tai khoan mat khau dang nhap ------------------------------------------------------------------------------------------------------------------
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
        //kiem tra id trung lap  --------------------------------------------------------------------------------------------------------------------------

        public static bool checkID(string id, string table, string collumn)
        {
            string query = "Select count(*) from " + table + " where " +collumn+ " = @id";

            using (SqlConnection conn = GetConnection())
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@id", id);

                return (int)command.ExecuteScalar() > 0;
            }
        }
        //them admin moi vao database-----------------------------------------------------------------------------------------------------------------------------------
        public static bool AddAdmin(string username, string password)
        {
            string query = "INSERT INTO Admin VALUES (@username, @password)";
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //them hdv vao database------------------------------------------------------


        public static bool AddTourGuide(string id, string name, int year, string phone, string address, string works, decimal salary)
        {
            string query = "INSERT INTO TourGuide VALUES (@id, @name, @year, @phone, @address, @works, @salary)";

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

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //them khac hang vao database-----------------------------------------------
        public static bool AddCustomer(string id, string name, int year, string phone, string address)
        {
            string query = "INSERT INTO Customer VALUES (@id, @name, @year, @phone, @address)";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //them phuong tien vao database--------------------------------------------
        public static bool AddVehicle(string id, string description, string lisenceplate, int capability)
        {
            string query = "INSERT INTO Vehicle VALUES (@id, @description, @lisenceplate, @capability)";
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@lisenceplate", lisenceplate);
                cmd.Parameters.AddWithValue("@capability", capability);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //them tour vao database-----------------------------------------------------
        public static bool AddTour(string id, DateTime date, int duration, int cusnumber, string cusid, string hdvid, string vehid, int revenue)
        {
            string status = "Chưa hoàn thành";
            if(date.AddDays(duration) < DateTime.Now)
            {
                status = "Đã hoàn thành";
            }
            string query = "INSERT INTO Tour VALUES (@id, @date, @duration, @cusnumber, @cusid, @hdvid, @vehid, @revenue, @status)";
            using(SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query,con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date );
                cmd.Parameters.AddWithValue("@duration", duration );
                cmd.Parameters.AddWithValue("@cusnumber", cusnumber );
                cmd.Parameters.AddWithValue("@cusid", cusid );
                cmd.Parameters.AddWithValue("@hdvid", hdvid );
                cmd.Parameters.AddWithValue("@vehid", vehid );
                cmd.Parameters.AddWithValue("@revenue", revenue );
                cmd.Parameters.AddWithValue("@status", status);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //xoa khoi database-------------------------------------------------------------------------------------------------------------------------------
        public static bool Delete(string id, string table, string collumn)
        {
            string query = "DELETE FROM " + table + " WHERE " + collumn + " = @id";
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
