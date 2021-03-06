﻿using Senparc.CO2NET;
using SJTech.Core.Enums;

namespace SJTech.Core.Models
{
    /// <summary>
    /// 全局可调整配置的设置
    /// </summary>
    public partial class SenparcCoreSetting
    {
        public bool IsDebug { get; set; }
        public bool IsTestSite { get; set; }

        public CacheType CacheType { get; set; }

        public string MemcachedAddresses { get; set; }
    }
}
