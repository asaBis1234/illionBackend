using System.Data;
using System.Data.SqlClient;

namespace Illion0.Context
{
    public class dapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
    

        public dapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("sqlConn");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }

}
