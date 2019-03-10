using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.dangan
{
    /// <summary>
    /// 病人建档请求参数
    /// </summary>
    class DanganJiandangRequest
    {
        string JIUZHENKH { get; set; }//	银行卡号	String(20)		不可空	1986927
        string FEIYONGLB { get; set; }//	费用类别	String (20)	自费病人是01,医保病人参见医保读卡返回	不可空	1
        string FEIYONGXZ { get; set; }//	费用性质	String (20)	自费病人是XJ01,医保病人参见医保读卡返回	不可空	XJ01
        string CHUSHENGRQ { get; set; }//	出生日期	DATE		不可空	1990/1/25
        string ZHENGJIANLX { get; set; }//	证件类型	String (20)	关联证件类型	不可空	10112
        string SHENFENZH { get; set; }//	证件号码	String (20)		不可空	3.30238E+17
        string JIATINGDZ { get; set; }//	家庭住址	String (100)		可空	杭州市
        string JIANDANGREN { get; set; }//	终端用户ID	String (20)		不可空	2.20002E+12
        string XINGMING { get; set; }//	姓名	String (20)		不可空	张三
        string DIANHUA { get; set; }//	手机号码	String (20)		不可空	1389897678
        string XINGBIE { get; set; }//	性别	String(1)	1：男/2：女	不可空	1
        string SHEBAOBH { get; set; }//	社保编号	String (50)		不可同时为空	6809910
        string YIBAOKH { get; set; }//	医保卡号	String(50)			Z01437510
        string XUNIBH { get; set; }//	虚拟账户号	String(50)	在银行分配的虚拟账户号码		
        string YINGERBZ { get; set; }//	新生儿标示	String(2)	新生儿标识 【规则】0否  1是	不可空	0/1
        string MUQINXM { get; set; }//	母亲姓名	String(20)		无身份证新生儿必填	
        string MUQINSFZH { get; set; }//	母亲身份证号码	String(20)		无身份证新生儿必填	
        string CHANCI { get; set; }//	产次	String(2)		无身份证新生儿必填	
        string TAICI { get; set; }//	胎次	String(2)	新生儿多胞胎出生的次序 	无身份证新生儿必填	
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string QUYUGRBH { get; set; }//	区域个人编号	String(50)		不可空	
        string CREATEID { get; set; }//	请求来源ID	String(50)		不可空	
        string GERENBH { get; set; }//	个人编号	String(50)	病人在医保系统的编号	可空	
    }
}
