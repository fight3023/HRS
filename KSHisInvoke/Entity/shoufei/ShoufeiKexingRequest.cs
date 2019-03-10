using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.shoufei
{
    class ShoufeiKexingRequest
    {
        string BINGREID { get; set; }//	病人ID	VARCHAR2(10)		不为空	13080636
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
    }
}
