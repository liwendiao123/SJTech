using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SJTech.Core.Models;

namespace SJTech.Repository
{
    public interface IAccountPayLogRepository : IClientRepositoryBase<AccountPayLog>
    {
    }

    public class AccountPayLogRepository : ClientRepositoryBase<AccountPayLog>, IAccountPayLogRepository
    {

    }
}

