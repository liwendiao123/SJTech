using Microsoft.AspNetCore.Authorization;
using SJTech.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Mvc.Controllers
{
    [UserAuthorize("UserAnonymous")]
    [AllowAnonymous]
    public class BaseFrontController : BaseController
    {

    }
}
