using AutoMapper;
using SJTech.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Core.AutoMapper
{
    /// <summary>
    /// AutoMapp 的 Profile
    /// </summary>
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            //CreateMap<CreateOrUpdate_AdminUserInfoDto, AdminUserInfo>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
