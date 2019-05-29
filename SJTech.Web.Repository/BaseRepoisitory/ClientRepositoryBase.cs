using Senparc.CO2NET;
using SJTech.Core.Models;
using SJTech.Utility;

namespace SJTech.Repository
{
    public interface IClientRepositoryBase<T> : IRepositoryBase<T> where T : EntityBase // global::System.Data.Objects.DataClasses.EntityObject, new()
    {
        ISqlClientFinanceData DB { get; }
    }

    public class ClientRepositoryBase<T> : RepositoryBase<T>, IClientRepositoryBase<T> where T : EntityBase // global::System.Data.Objects.DataClasses.EntityObject, new()
    {
        public ISqlClientFinanceData DB
        {
            get
            {
                return base.BaseDB as ISqlClientFinanceData;
            }
        }

        public ClientRepositoryBase() : this(null) { }
        public ClientRepositoryBase(ISqlClientFinanceData db)
        {
            //System.Web.HttpContext.Current.Response.Write("-"+this.GetType().Name + "<br />");

            base.BaseDB = db ?? SenparcDI.GetService<ISqlClientFinanceData>();// ObjectFactory.GetInstance<ISqlClientFinanceData>();

            _entitySetName = EntitySetKeys.Keys[typeof(T)];
        }


    }
}
