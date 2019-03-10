using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.dangan
{
    /// <summary>
    /// 病人主索引请求参数
    /// </summary>
    class DanganBingrenRequest
    {
        string SHENFENZH { get; set; }//	身份证号	String(20)		不可空	3.42321E+17	12001
        string BINGRENID { get; set; }//	病人Id	String(10)		可空	10015745	
        string JIUZHENKH { get; set; }//	就诊卡号	String(20)		可空	1986927	
        string YIBAOKH { get; set; }//	医保卡号	String(50)		可空	Z01437510	
        string SEX { get; set; }//	性别	String(1)	1：男/2：女		1	
        string BIRTHDAY { get; set; }//	出生日期	String(8)				
        string YINGERBZ { get; set; }//	婴儿标志	String(2)	1:是,0.否		0/1	
        string MUQINXM { get; set; }//	母亲姓名	String(20)		无身份证新生儿必填		
        string MUQINSFZH { get; set; }//	母亲身份证号码	String(20)		无身份证新生儿必填		
        string TAICI { get; set; }//	产次	String(2)		无身份证新生儿必填		
        string CHANCI { get; set; }//	胎次	String(2)	新生儿多胞胎出生的次序 	无身份证新生儿必填		
        string CREATEID { get; set; }//	请求来源ID	String(50)		不可空		
        string PTJGDM { get; set; }//	平台机构代码	String(50)	联调阶段使用固定值 320583000000 ，上线前由平台发放各机构代码	不可空		
        string PTJGMC { get; set; }//	平台机构名称	String(50)	联调阶段使用固定值 “昆山市卫生局”，上线前由平台发放各机构名称	不可空		
    }
}
