﻿using SJTech.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Core.DI
{
    /// <summary>
    /// 自动依赖注入特性标签
    /// </summary>
    public class AutoDITypeAttribute : Attribute
    {
        public DILifecycleType DILifecycleType { get; set; } = DILifecycleType.Scoped;

        public AutoDITypeAttribute() { }

        public AutoDITypeAttribute(DILifecycleType diLifecycleType)
        {
            DILifecycleType = diLifecycleType;
        }
    }
}
