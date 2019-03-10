using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.guahao
{
    /// <summary>
    /// 取消挂号请求参数
    /// </summary>
    class GuahaoQuxiaoRequest
    {
        string YIJIID { get; set; }//	医技ID	String(50)	挂号收费接口返回的医技ID 东软系统中是病人ID	Yijiid1不可空， yijiid2可空	10119060^10119086
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
    }
}
