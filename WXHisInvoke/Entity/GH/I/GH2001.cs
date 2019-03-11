using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.19.	(GH2001)(210001)挂号就诊开单查询
    /// </summary>
    class GH2001 : BASE_I
    {
        string CXFS { get; set; }//		6	查询方式 JZKH = 就诊卡号查 MZH = 门诊号查		INPARA 
        string CXDM { get; set; }//		30	查询代码 查询方式 JZKH = 就诊卡号查	 MZH = 门诊号查		INPARA
    }
}
