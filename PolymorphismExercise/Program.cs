using System;

namespace PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("");
            DbCommand dbCommand = new DbCommand(sqlConnection, "Create SQL database");
            dbCommand.Execute();
            Console.WriteLine("\n");
            OracleConneciton oracleConnection = new OracleConneciton("345connectToOracle");
            DbCommand dbCommandOne = new DbCommand(oracleConnection, "Create Oracle database");
            dbCommandOne.Execute();
            Console.ReadKey();
        }
    }
}
