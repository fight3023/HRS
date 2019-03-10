using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 科室请求参数
    /// </summary>
    class PubdicKeshiRequest
    {
        string KESHIID { get; set; }//	科室ID	String(20)	可以传递多个科室ID，模式如下	可空	2526
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
    }
}
