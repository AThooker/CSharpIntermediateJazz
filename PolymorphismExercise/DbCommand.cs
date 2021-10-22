using System;

namespace PolymorphismExercise
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;
        public DbCommand(DbConnection connection, string instruction)
        {
            if(connection != null && !string.IsNullOrEmpty(instruction))
            {
                _connection = connection;
                _instruction = instruction;
            }
            else if(connection == null)
            {
                throw new ArgumentException("DbConnection cannot be null");
            }
            else
            {
                throw new ArgumentException("Instructions cannot be null or empty");
            }
        }
        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine(_instruction);
            Console.WriteLine("Press any key to close the connection");
            Console.ReadKey();
            _connection.CloseConnection();
        }
    }
}
