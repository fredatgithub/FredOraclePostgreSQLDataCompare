namespace FredOraclePostgreSQLDataCompare.DAL.PostgreSql
{
  public class PostgreSqlDatabaseAuthentication
  {
    public string DatabaseName { get; set; }
    public string ServerName { get; set; }
    public string UserName { get; set; }
    public string UserPassword { get; set; }
    public int Port { get; set; }
    public string Schema { get; set; }

    public void DatabaseAuthentication(string dbName, string serverName, string user, string pass, int port = 5432, string schema = "public")
    {
      DatabaseName = dbName;
      ServerName = serverName;
      UserName = user;
      UserPassword = pass;
      Port = port;
      Schema = schema;
    }

    public void DatabaseAuthentication()
    {
      DatabaseName = "postgres";
      ServerName = string.Empty;
      UserName = "postgres";
      UserPassword = string.Empty;
      Port = 5432;
      Schema = "public";
    }

    public override string ToString()
    {
      return $"host={ServerName};Port={Port};Database={DatabaseName};Username={UserName};Password={UserPassword};CommandTimeout=0";
    }
  }
}
