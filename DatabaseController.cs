using Microsoft.Data.Sqlite;

namespace CodingTracker
{
    public class DatabaseController
    {
        private string connectionString;
        private SqliteConnection connection;

        public DatabaseController(string connectionString)
        {
            this.connectionString = connectionString;
            this.connection = new SqliteConnection(connectionString);
        }

        public void InitializeDatabase()
        {
            var createSql = @"CREATE TABLE IF NOT EXISTS SessionsTable ( Id INTEGER PRIMARY KEY, Start TEXT, End TEXT, Duration TEXT) ";
        }

        public void InsertSession()
        {

        }

        public void ViewSessions()
        {

        }

        public void UpdateSession()
        {

        }

        public void DeleteSession()
        {

        }


    }
}
