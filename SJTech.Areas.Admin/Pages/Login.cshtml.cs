using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Senparc.CO2NET.Extensions;
using Senparc.CO2NET.Trace;
using SJTech.Areas.Admin;
using SJTech.Areas.Admin.Filters;
using SJTech.Core.Models;
using SJTech.Service;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Senparc.Areas.Admin.Areas.Admin.Pages
{
    [AllowAnonymous]
    public class LoginModel : BaseAdminPageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "�������û���")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "����������")]
        public string Password { get; set; }

        //�󶨲���
        [BindProperty]
        public string ReturnUrl { get; set; }



        private readonly AdminUserInfoService _userInfoService;
        public LoginModel(AdminUserInfoService userInfoService)
        {
            this._userInfoService = userInfoService;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            //�Ƿ��Ѿ���¼
            var logined = await base.CheckLoginedAsync(AdminAuthorizeAttribute.AuthenticationScheme);//�жϵ�¼

            if (logined)
            {
                if (ReturnUrl.IsNullOrEmpty())
                {
                    return RedirectToPage("/Index");
                }
                return Redirect(ReturnUrl.UrlDecode());
            }

            return null;
        }

        public async Task<IActionResult> OnPostAsync(/*[Required]string name,string password*/)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            string errorMsg = null;

            var userInfo = await _userInfoService.GetUserInfo(this.Name);
            if (userInfo == null)
            {
                errorMsg = "�˺Ż�������󣡴�����룺101��";
            }
            else if (_userInfoService.TryLogin(this.Name, this.Password, true) == null)
            {
                errorMsg = "�˺Ż�������󣡴�����룺102��";
            }

            if (!errorMsg.IsNullOrEmpty() || !ModelState.IsValid)
            {
                this.MessagerList = new List<Messager>
                {
                    new Messager(SJTech.Core.Enums.MessageType.danger, errorMsg)
                };
                return null;
            }

            if (this.ReturnUrl.IsNullOrEmpty())
            {
                return RedirectToPage("/Index");
            }
            return Redirect(this.ReturnUrl.UrlDecode());
        }

        public async Task<IActionResult> OnGetLogoutAsync()
        {
            SenparcTrace.SendCustomLog("����Ա�˳���¼", $"�û�����{base.UserName}");
            await _userInfoService.Logout();
            return RedirectToPage("Index");
        }
    }
}