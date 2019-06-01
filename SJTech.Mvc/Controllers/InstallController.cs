using Microsoft.AspNetCore.Mvc;
using SJTech.Core.Models.VD;
using SJTech.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Mvc.Controllers
{
    public class InstallController : Controller
    {
        private readonly AdminUserInfoService _accountInfoService;
        private readonly SystemConfigService _systemConfigService;
        public InstallController(AdminUserInfoService accountService, SystemConfigService systemConfigService)
        {
            _accountInfoService = accountService;
            _systemConfigService = systemConfigService;
        }
        public IActionResult Index()
        {
            var adminUserInfo = _accountInfoService.Init(out string userName, out string password);

            _systemConfigService.Init();

            if (adminUserInfo == null)
            {
                return new StatusCodeResult(404);
            }

            var vd = new Install_IndexVD()
            {
                AdminUserName = userName,
                AdminPassword = password
            };
            return View(vd);
        }
    }
}
