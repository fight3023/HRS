using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.shoufei
{
    class ShoufeiYujiesuanRequest
    {
        string BINGREID { get; set; }//	病人ID	VARCHAR2(10)		不为空	13080636
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string JIESUANIDS { get; set; }//	结算单ID串 	VARCHAR2(2000)	处方(医技)ID^结算单类型^就诊ID	为空	chufangid1^1^jiuzhenid1@@yijiid1^2^jiuzhenid1@@chufangid2^1^jiuzhenid2@@yijiid2^2^jiuzhenid2用@@分隔,其中结算单类型(1:处方,2:医技)	(如果为空,默认计算全部费用)	
    }
}
