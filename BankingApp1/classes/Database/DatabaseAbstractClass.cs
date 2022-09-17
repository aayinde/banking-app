using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace BankingApp1
{
    /*
     * This class serves as the database Abstract Layer for all database dependend class.
     */
    abstract class DatabaseAbstractClass
    {
        public enum DatabaseTableName {bank_accounts,bank_admins,bank_users,bank_deposits,bank_withdrawers};

        private readonly String DatabaseConnect = @"Data Source=Database\BankingApp.db;Pooling=true;FailIfMissing=false";

        public int numberOfRowsAffected;
        public int lastInsertId;
        public int id;
        public int querySuccess;
        private readonly string filePath = @"Database\BankingApp.db";
        private SQLiteConnection con;
        private SQLiteCommand cmd;

        /*
         * This method will perform related database query.
         */
        public int Query(string query, Dictionary<string, object> args)
        {
           
                if (File.Exists(filePath))
                {
                    try
                    {
                        using (con = new SQLiteConnection(DatabaseConnect))
                        {
                            con.Open();

                            using (cmd = new SQLiteCommand(query, con))
                            {
                                foreach (var pairs in args)
                                {
                                    cmd.Parameters.AddWithValue(pairs.Key, pairs.Value);
                                }

                            this.numberOfRowsAffected = cmd.ExecuteNonQuery();
                            }
                        this.lastInsertId = Convert.ToInt32(con.LastInsertRowId);

                            return numberOfRowsAffected;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new SQLiteException("Problem with"+ex);
                    }
            }
            else
            {
                throw new IOException("file not found");
            }






        }

        /*
         * This method is use to select perform a SELECT query from the database
         */
            public DataTable SelectQuery(string query, Dictionary<string, object> args)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return null;

            using (con = new SQLiteConnection(DatabaseConnect))
            {
                con.Open();

                using (cmd = new SQLiteCommand(query, con))
                {
                    foreach(KeyValuePair<string, object> entry in args)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }

                    
                    var da = new SQLiteDataAdapter(cmd);
                    var dt = new DataTable();

                    da.Fill(dt);

                    da.Dispose();
                    this.querySuccess = cmd.ExecuteNonQuery();
                    return dt;
                }
            }
        }

        /*
         * This method is use to PERFORM a SELECT QUERY without parameters
         */
        public DataTable FetchAll(string query)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return null;

            using (con = new SQLiteConnection(DatabaseConnect))
            {
                con.Open();

                using (cmd = new SQLiteCommand(query, con))
                {
                    
                    var da = new SQLiteDataAdapter(cmd);
                    var dt = new DataTable();

                    da.Fill(dt);

                    da.Dispose();
                    this.querySuccess = cmd.ExecuteNonQuery();
                    return dt;
                }
            }
        }

        /*
         * This method will Counts rows in a given table and return the result
         */
        public int CountRecords(string query)
        {
            if (string.IsNullOrEmpty(query.Trim()))
                return 0;

            using (con = new SQLiteConnection(DatabaseConnect))
            {
                con.Open();

                using (cmd = new SQLiteCommand(query, con))
                {
                   
                    int RowCounts = 0;
                    RowCounts = Convert.ToInt32(cmd.ExecuteScalar());

                    return RowCounts;
                  
                }
            }
        }


    }
}
