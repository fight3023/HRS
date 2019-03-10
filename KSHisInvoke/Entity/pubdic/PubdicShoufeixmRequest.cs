using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 收费项目请求参数
    /// </summary>
    class PubdicShoufeixmRequest
    {
        string SHOUFEIXMID{ get; set; }//	收费项目ID	String(36)		可空	100211
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
    }
}
