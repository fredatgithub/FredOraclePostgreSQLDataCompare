using System.IO;

namespace FredOraclePostgreSQLDataCompare.DAL.Oracle
{
  public class OracleDatabaseAuthentication
  {
    private string tnsNamesOraFile = "tnsnames.ora";

    public string DataSource { get; set; }
    public string UserName { get; set; }
    public string UserPassword { get; set; }
    public int Port { get; set; }
    public bool TnsNamesOraFilePresent { get; set; }

    public void DatabaseAuthentication(string dataSource, string user, string pass, int port = 1521)
    {
      DataSource = dataSource;
      UserName = user;
      UserPassword = pass;
      Port = port;
      TnsNamesOraFilePresent = CheckTnsNameFile();
    }

    public void DatabaseAuthentication()
    {
      DataSource = "DEV";
      UserName = "USER1";
      UserPassword = string.Empty;
      Port = 1521;
      TnsNamesOraFilePresent = CheckTnsNameFile();
    }

    public override string ToString()
    {
      return $"User ID={UserName};Password={UserPassword};Data Source={DataSource};Pooling=false";
    }

    public bool CheckTnsNameFile()
    {
      var fileExists = File.Exists(tnsNamesOraFile);
      TnsNamesOraFilePresent = fileExists;
      return fileExists;
    }
  }
}
