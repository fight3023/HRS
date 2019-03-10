using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.shoufei
{
    class ShoufeiYijiRequest
    {
        string BINGRENID { get; set; }//	病人Id	String(15)		不可空	20101
        string SHENFENZH { get; set; }//	身份证号	String(20)	东软用	不可空	
        string YINGERBZ { get; set; }//	婴儿标志	String(1)	1：是；0：否	不可空	
        string CHANCI { get; set; }//	产次	String(2)		无身份证新生儿必填	
        string TAICI { get; set; }//	胎次	String(2)	新生儿多胞胎出生的次序 	无身份证新生儿必填	
        string JIESUANLB { get; set; }//	结算类别	String(20)	001：自费/003：医保（东软使用）	不可空	
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string CAOZUOREN { get; set; }//	终端用户ID	String(20)		不为空	
        string YUANQUID { get; set; }//	院区ID	String(20)	用于标识同一家医院的不同院区	不可空	1
    }
}
