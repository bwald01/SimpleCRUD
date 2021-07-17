using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApi.Repository
{
    public class Repository<T>  where T : class 
    {
        private readonly string _connectionString;

        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection SqlConnection()
        {
            return new SqlConnection(_connectionString);
        }

        private IDbConnection CreateConnection()
        {
            var conn = SqlConnection();

            return conn;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.GetListAsync<T>();
            }
        }   

        public async Task<IEnumerable<T>> GetAllAsync(object where)
        {
            using (var connection = CreateConnection())
            {
                return await connection.GetListAsync<T>(where);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(string conditions, object param)
        {
            using (var connection = CreateConnection())
            {
                return await connection.GetListAsync<T>(conditions, param);
            }
        }
    }
}
