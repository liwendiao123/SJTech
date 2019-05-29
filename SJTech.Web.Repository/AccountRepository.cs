using SJTech.Core.Models;

namespace SJTech.Repository
{
    public interface IAccountRepository : IClientRepositoryBase<Account>
    {
    }

    public class AccountRepository : ClientRepositoryBase<Account>, IAccountRepository
    {

    }
}

