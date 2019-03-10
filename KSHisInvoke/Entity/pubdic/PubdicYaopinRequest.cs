using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 药品请求参数
    /// </summary>
    class PubdicYaopinRequest
    {
        string JIAGEID { get; set; }//		价格ID	String(36)		可空	4609
        string YILIAOJGID { get; set; }//		医疗机构ID	String(20)	医疗机构ID	不可空	
    }
}
