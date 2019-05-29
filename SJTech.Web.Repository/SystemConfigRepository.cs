using SJTech.Core.Models;

namespace SJTech.Repository
{
    public interface ISystemConfigRepository : IClientRepositoryBase<SystemConfig>
    {
    }

    public class SystemConfigRepository : ClientRepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        
    }
}

