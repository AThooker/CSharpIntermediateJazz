using System;

namespace PolymorphismExercise
{
    public class OracleConneciton : DbConnection
    {
        public OracleConneciton(string connectionString)
            :base(connectionString)
        {

        }
        public override void CloseConnection()
        {
            Console.WriteLine("Close Oracle Database");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Oracle Database");
        }
    }
}
