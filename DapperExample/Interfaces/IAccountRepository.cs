using DapperExample.Models;

namespace DapperExample.Interfaces
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetAllAsync();
    }
}
