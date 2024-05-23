using AuthApi.DataContext;
using AuthApi.Dtos;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Configuration;

namespace AuthApi 
{
  public class Program
  {
    public static void Main(String[] args)
    {
      IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

      DapperDataContext dapper = new DapperDataContext(config);
    }
  }
}