using Dapper;
using DapperExample.Interfaces;
using DapperExample.Models;
using Microsoft.Data.SqlClient;

namespace DapperExample.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly string _connection;

        public AccountRepository(string connection)
        {
            _connection = connection;
        }

        public async Task<List<Account>> GetAllAsync()
        {
            using var sqlConnection = new SqlConnection(_connection);
            IEnumerable<Account> accounts = await sqlConnection.QueryAsync<Account>("SELECT * FROM Account");
            return accounts.ToList();
        }
    }
}
