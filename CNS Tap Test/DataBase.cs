﻿using System;
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
        //회원 테이블이 있고 기록 테이블 있고 기록 테이블에 컬럼을 id나 닉네임으로 회원 구분하기


        private static string DBpath = "../../TapTestData.db";
        private static SQLiteConnection mConnectDB = new SQLiteConnection($"Data Source = {DBpath};Version = 3");
        private string mQuery;
        private string mquery;

        public void OpenDB()
        {
            mConnectDB.Open();
        }
        public void InsertTapData(string Daily, string tap)
        {
            //아
            mQuery = "INSERT INTO RECORD(date, dayRecord) VALUES(@Daily, @tap)";
            using (SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                command.Parameters.AddWithValue("@Daily", Daily);
                command.Parameters.AddWithValue(@"tap", tap);
                command.ExecuteNonQuery();
            }
        }
        public void InsertJoinData(string UserID, string UserPW, string NickName)
        {
            mQuery = "INSERT INTO INFORMATION(ID, PW, NICKNAME) VALUES(@UserID, @UserPW, @NickName)";
            using(SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@UserPW", UserPW);
                command.Parameters.AddWithValue("@NickName", NickName);
                command.ExecuteNonQuery();
            }
        }
        public void CreateTable()
        {
            string[] queries = {
        "CREATE TABLE IF NOT EXISTS RECORD(NICKNAME STRING, date STRING, dayRecord STRING)",
        "CREATE TABLE IF NOT EXISTS INFORMATION(ID STRING, PW STRING, NICKNAME STRING)"
            };

            using (var command = new SQLiteCommand(mConnectDB))
            {
                foreach (var query in queries)
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
        }

        //public void CreateTable()
        //{

            //string[] createqry = { "create table if not exists record(nickname string, date string, dayrecord string)",
            //                    "create table if not exists information(id string, pw string, nickname string)"};
            //using (var command = new SQLiteCommand(mconnectdb))
            //{
            //    foreach (var row in command.ExecuteReader())
            //    {
            //        command.ExecuteNonQuery();
            //    }
            //}
            //mquery = "create table if not exists record(nickname string, date string, dayrecord string)";
            //using (SQLiteCommand command = new SQLiteCommandSQLiteC(mquery, mconnectdb))
            //{
            //    command.executenonquery();
            //}
            //mquery = "create table if not exists information(id string, pw string, nickname string)";
            //using (SQLiteCommand command = new SQLiteCommand(mquery, mconnectdb))
            //{
            //    command.executenonquery();
            //}
        //}

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
