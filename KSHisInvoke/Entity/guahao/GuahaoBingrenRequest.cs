using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.guahao
{
    /// <summary>
    /// 病人ID信息请求参数
    /// </summary>
    class GuahaoBingrenRequest
    {
        string SHENFENZH { get; set; }//	身份证号	String(20)		不可空	5676
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
    }
}
