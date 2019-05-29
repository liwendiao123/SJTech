﻿using Microsoft.AspNetCore.Authorization;

namespace SJTech.Core.Extensions
{

    //TODO： 独立到各个模块中

    public class UserAuthorizeAttribute : AuthorizeAttribute
    {
        public const string AuthenticationScheme = "ScfUserAuthorizeScheme";
        public UserAuthorizeAttribute(string policy) : this()
        {
            this.Policy = policy;
        }
        public UserAuthorizeAttribute()
        {
            base.AuthenticationSchemes = AuthenticationScheme;
        }
    }
}
