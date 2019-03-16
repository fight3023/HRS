using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.22.	(GH2201)(220001)网上预约信息获取
    /// </summary>
    public class GH2201 : BASE_I
    {
        public string SJH { get; set; }//		20	手机号 CXFS = YYHM时传入预约登记号		INPARA 
        public string YZM { get; set; }//		10	验证码	INPARA
        public string CXFS { get; set; }//		6	查询方式 默认手机号验证码查 YYHM = 预约登记号		INPARA
    }
}
