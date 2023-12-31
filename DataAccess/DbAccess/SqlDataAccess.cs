﻿using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(
            string storedProcedure,
            U parameters,
            string conncectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(conncectionId));

            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task SaveData<T>(
            string storedProcedure,
            T parameters,
            string conncectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(conncectionId));

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
