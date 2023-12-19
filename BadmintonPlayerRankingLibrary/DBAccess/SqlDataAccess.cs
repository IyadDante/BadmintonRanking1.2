using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        private const string conncectionId = "SqlConnection";

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string conncectionId)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(conncectionId));

            return connection.Query<T>(sqlStatement, parameters, commandType: CommandType.StoredProcedure).ToList();
        }

        public void SaveData<T>(string sqlStatement, T parameters, string conncectionId)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(conncectionId));

            connection.Execute(sqlStatement, parameters, commandType: CommandType.StoredProcedure);
        }

    }
}
