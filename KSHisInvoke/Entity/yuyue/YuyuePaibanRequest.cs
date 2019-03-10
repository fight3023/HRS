using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.yuyue
{
    /// <summary>
    /// 预约排班请求参数
    /// </summary>
    class YuyuePaibanRequest
    {
        string PAIBANID { get; set; }//	排班Id	String(10)		可空	201231
        string KESHIID { get; set; }//	科室Id	String(10)		可空	5672
        string YISHENGID { get; set; }//	医生Id	String(10)		可空	1012
        string GUAHAOLB { get; set; }//	挂号类别	String(10)	1.普通,2.急诊,4.专家	可空	4
        string XINGQI { get; set; }//	星期	NUMBER(6)	周日到周六分别是1-7	可空	6
        string RIQI { get; set; }//	日期	DATE	yyyy-MM-dd	可空	2013/11/15
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string YUANQUID { get; set; }//	院区ID	String(20)	用于标识同一家医院的不同院区,传入空返回所有院区排班	可空	1
    }
}
