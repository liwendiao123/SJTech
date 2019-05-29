using SJTech.Core.Models;

namespace SJTech.Repository
{
    public interface IPointsLogRepository : IClientRepositoryBase<PointsLog>
    {
    }

    public class PointsLogRepository : ClientRepositoryBase<PointsLog>, IPointsLogRepository
    {

    }
}

