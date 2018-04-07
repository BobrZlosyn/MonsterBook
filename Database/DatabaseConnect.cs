using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class DatabaseConnect
    {
        private SQLiteConnection dbConnection;

        public void Connect()
        {
            dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dbConnection.Open();
        }

        public void CreateDatabase()
        {
            string sql = "";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

        }

    }
}
