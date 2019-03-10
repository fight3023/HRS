using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.guahao
{
    /// <summary>
    /// 挂号收费响应参数
    /// </summary>
    class GuahaoShoufeiResponse : CommonResponse
    {
        string GUAHAOXH { get; set; }//	挂号序号	String (20)		不可空	5
        string JIUZHENDD { get; set; }//	就诊地点	String (200)		可空	
        string HOUZHENSJ { get; set; }//	候诊时间	String (20)		可空	
        string TIAOXINGM { get; set; }//	条形码	String (20)		可空	
        string YUSHOUQJE { get; set; }//	预授权金额	Number (18,4)		可空	
        string YIJIID { get; set; }//	医技ID	String (50)	返回以^隔开的yijiid1^yijiid2，个别情况下yijiid2为空，只返回yijiid1	可空	
        string JIUZHENID { get; set; }//	就诊ID	String (50)	标识每次挂号的唯一值	可空	
    }
}
