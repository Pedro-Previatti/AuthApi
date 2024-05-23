using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AuthApi.DataContext
{
  public class DapperDataContext
  {
    // private IConfiguration _config;
    private string _connectionString;
    
    public DapperDataContext(IConfiguration config)
    {
      // _config = config;
      _connectionString = config.GetConnectionString("Db");
    }
  }
}
