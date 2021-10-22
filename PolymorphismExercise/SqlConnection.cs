using System;

namespace PolymorphismExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString){ }
        public override void CloseConnection()
        {
            Console.WriteLine("Close SQL connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open SQL connection");
        }
    }
}
