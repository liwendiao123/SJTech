using System;
using SJTech.Core.Models;
using SJTech.Log;
using SJTech.Repository;
using SJTech.Core.Cache;
using SJTech.Utility;
using Senparc.CO2NET;

namespace SJTech.Service
{
    //public interface ISystemConfigService : IBaseClientService<SystemConfig>
    //{
    //    string GetRuningDatabasePath();
    //    string BackupDatabase();
    //    void RestoreDatabase(string fileName);
    //    void DeleteBackupDatabase(string fileName, bool deleteAllBefore);
    //    void RecycleAppPool();
    //}

    public class SystemConfigService : ClientServiceBase<SystemConfig>/*, ISystemConfigService*/
    {
        public SystemConfigService(SystemConfigRepository systemConfigRepo)
            : base(systemConfigRepo)
        {

        }

        public SystemConfig Init()
        {
           var systemConfig = GetObject(z => true);
            if (systemConfig!=null)
            {
                return null;
            }

            systemConfig = new SystemConfig() {
                SystemName = "SCF - Template Project"
            };

            SaveObject(systemConfig);

            return systemConfig;
        }

        public override void SaveObject(SystemConfig obj)
        {
            LogUtility.SystemLogger.Info("ϵͳ��Ϣ���༭");

            base.SaveObject(obj);

            //ɾ������
            var systemConfigCache = SenparcDI.GetService<FullSystemConfigCache>();
            systemConfigCache.RemoveCache();
        }

        public string GetRuningDatabasePath()
        {
            var dbPath = "~/App_Data/#SenparcCRM.config";
            return dbPath;
        }

        public string BackupDatabase()
        {
            string timeStamp = DateTime.Now.ToString("yyyyMMdd-HH-mm");//����
            return timeStamp;
        }

        public void RecycleAppPool()
        {
            //string webConfigPath = HttpContext.Current.Server.MapPath("~/Web.config");
            //System.IO.File.SetLastWriteTimeUtc(webConfigPath, DateTime.UtcNow);
        }

        public override void DeleteObject(SystemConfig obj)
        {
            throw new Exception("ϵͳ��Ϣ���ܱ�ɾ����");
        }
    }
}

