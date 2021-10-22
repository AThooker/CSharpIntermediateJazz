using System;

namespace PolymorphismExercise
{
    public abstract class DbConnection
    {
        protected string _connectionString;
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            try
            {
                if(!String.IsNullOrEmpty(connectionString))
                {
                    _connectionString = connectionString;
                }
                else
                {
                    throw new ArgumentException("Connection string invalid");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"You have hit a {ex}, \n" +
                    $"Please provide a valid connection string");
            }
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
