using System;
using Oracle.ManagedDataAccess.Client;

namespace FredOraclePostgreSQLDataCompare.DAL.Oracle
{
  public static class OracleConnection
  {
    public static string GetGeneralConnexionString()
    {
      return "Data Source = {serverName}; Initial Catalog = {databaseName}; Persist Security Info = True; User ID = {userName}; Password = {password}";
    }

    public static string TestRequest()
    {
      return "select 1+2 FROM DUAL;";
    }
  }
}
