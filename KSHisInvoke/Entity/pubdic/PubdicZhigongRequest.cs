using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    class PubdicZhigongRequest
    {
        string ZHIGONGID{ get; set; }//	职工ID	String(10)	可以传递多个职工ID，模式如下	可空	1968
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
    }
}
