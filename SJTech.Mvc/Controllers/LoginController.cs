using SJTech.Core.Cache;
using SJTech.Service;
using SJTech.Service.Weixin;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Mvc.Controllers
{
    public class LoginController : BaseController
    {
        private AccountService _accountService;
        private WeixinService _weixinService;
        private IQrCodeLoginCache _qrCodeLoginCache;
        public LoginController(WeixinService weixinService, IQrCodeLoginCache qrCodeLoginCache, AccountService accountService)
        {
            _weixinService = weixinService;
            _qrCodeLoginCache = qrCodeLoginCache;
            this._accountService = accountService;
        }
    }
}
