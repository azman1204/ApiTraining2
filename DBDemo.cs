using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    // this is sample using ADO.net / ActiveX Data Object
    internal class DBDemo
    {
        const string connectionString = "Server=AZMAN-ASUSG713Q;Database=api_demo;Trusted_Connection=true";
        public void retrieve()
        {
            using (SqlConnection conn = new(connectionString))
            {
                String sql = "SELECT * FROM person";
                SqlCommand cmd = new(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read()) 
                    {
                        Console.WriteLine($"{reader[0]} \t {reader[1]} \t {reader[2]}");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void insert()
        {
            string sql = "INSERT INTO person(id, name,age) VALUES(4, 'Henrry Kessenger', 80)";
            using(SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                } 
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void update()
        {
            string sql = "UPDATE person SET age = 79 WHERE id = 4";
            using (SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void delete()
        {
            string sql = "DELETE FROM person WHERE id = 4";
            using (SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
