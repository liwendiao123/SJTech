using SJTech.Core.Models.VD;
using System;
using System.Collections.Generic;
using System.Text;

namespace SJTech.Mvc.Models
{
    public class Home_IndexVD : Home_BaseVD
    {

    }

    public class Home_AboutVD : Home_BaseVD
    {
        public string Version { get; set; }
    }

    public class Home_RegAgreementVD : Home_BaseVD
    {

    }
    public class Home_DetailVD : BaseVD
    {
    }
}
