using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNS_Tap_Test
{
    internal class DataBase
    {
        //DB TABLE CREATE, INSERT, SELECT, LOAD
        //DB OPEN, CLOSE
        //경로 지정 C로
        private static string DBpath = "../../TapTestData.db";
        private static SQLiteConnection mConnectDB = new SQLiteConnection($"Data Source = {DBpath};Version = 3");
        private string mQuery;
        public void OpenDB()
        {
            mConnectDB.Open();
        }
        public void InsertTapData(string Daily, string tap)
        {
            mQuery = "INSERT INTO RECORD(date, dayRecord) VALUES(@Daily, @tap)";
            using (SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                command.Parameters.AddWithValue("@Daily", Daily);
                command.Parameters.AddWithValue(@"tap", tap);
                command.ExecuteNonQuery();
            }
        }
        public void CreateTable()
        {
            mQuery = "CREATE TABLE IF NOT EXISTS RECORD(date STRING, dayRecord STRING)";
            using (SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                command.ExecuteNonQuery();
            }
        }
        public string SelectTapData()
        {
            StringBuilder record = new StringBuilder();
            mQuery = "SELECT dayRecord FROM RECORD";
            using (SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        record.AppendLine($"{reader["dayRecord"]}");
                    }
                }
                return record.ToString();
            }

        }
    }
}
