using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.guahao
{
    /// <summary>
    /// 当日排班请求参数
    /// </summary>
    class GuahaoPaibanRequest
    {
        string RIQI { get; set; }//	日期	String(20)	yyyy-MM-dd	不可空	2013/11/15
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string KESHIID { get; set; }//	科室Id	String(10)		可空	5672
        string YISHENGID { get; set; }//	医生Id	String(10)		可空	1012
        string PAIBANID { get; set; }//	排班Id	String(10)		可空	100212
        string GUAHAOLB { get; set; }//	挂号类别	String(10)	1.普通,2.急诊,4.专家	可空	4
        string YUANQUID { get; set; }//	院区ID	String(20)	用于标识同一家医院的不同院区	不可空	1
    }
}
