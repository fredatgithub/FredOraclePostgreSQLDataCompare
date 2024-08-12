using System;
using Oracle.ManagedDataAccess.Client;

namespace FredOraclePostgreSQLDataCompare.DAL.Oracle
{
  public static class OracleDALHelper
  {
    public static string GetGeneralConnexionString()
    {
      return "Data Source = {serverName}; Initial Catalog = {databaseName}; Persist Security Info = True; User ID = {userName}; Password = {password}";
    }

    public static string TestRequest()
    {
      return "select 1+2 FROM DUAL;";
    }

    public static bool TestOracleDbConnection(string connectionString)
    {
      var result = true;
      using (OracleConnection connection = new OracleConnection(connectionString))
      {
        try
        {
          connection.Open();

          //string query = "SELECT table_name FROM all_tables WHERE owner = 'PP_INTER_REF'";

          //using (OracleCommand command = new OracleCommand(query, connection))
          //{
          //  using (OracleDataReader reader = command.ExecuteReader())
          //  {
          //    Console.WriteLine("Tables in the database:");
          //    while (reader.Read())
          //    {
          //      Console.WriteLine(reader.GetString(0));
          //    }
          //  }
          //}
        }
        catch (Exception)
        {
          result = false;
        }
      }

      return result;
    }
  }
}
