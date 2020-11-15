using System;
using Npgsql;

namespace BloomFilter
{
    class Postgres
    {
        private String connString = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=initdb";

        public void addData(String key, String value)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO table testDb VALUES (@p)", conn))
            {
                    cmd.Parameters.AddWithValue("p", value);
                    cmd.ExecuteNonQuery();
            }
        }
    }
}