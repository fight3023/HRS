using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.yuyue
{
    /// <summary>
    /// 预约挂号请求参数
    /// </summary>
    class YuyueGuahaoRequest
    {
        string PAIBANHAO { get; set; }//	排班号	String(20)		不可空	
        string JIUZHENRQ { get; set; }//	就诊日期	String(20)		不可空	
        string YUYUEGHXH { get; set; }//	预约挂号序号	String(10)		可空	
        string SHANGXIAWBZ { get; set; }//	上下午标志	NUMBER(1)		不可空	
        string BINGRENID { get; set; }//	病人ID	String(10)		可空	
        string HUANZHEXM { get; set; }//	患者姓名	String(50)		可空	
        string HUANZHEXB { get; set; }//	患者性别	String(4)		可空	
        string SHENFENZH { get; set; }//	身份证号	String(20)		可空	
        string HUANZHESJH { get; set; }//	患者手机号	String(20)		不可空	
        string KAHAOLX { get; set; }//	卡号类型	String(4)		可空	
        string HUANZHEKH { get; set; }//	患者卡号	String(20)		可空	
        string HUANZHEDZ { get; set; }//	患者地址	String(100)		可空	
        string JILULY { get; set; }//	记录来源	String(10)		可空	自助机传7,微信传17,手机传27
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string YUANQUID { get; set; }//	院区ID	String(20)	用于标识同一家医院的不同院区	不可空	1
    }
}
