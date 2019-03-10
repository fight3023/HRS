using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.dangan
{
    /// <summary>
    /// 档案修改请求参数
    /// </summary>
    class DanganXiugaiRequest
    {
        string BINGRENID { get; set; }//	病人Id	String(10)		不可空	10015745
        string JIATINGDH { get; set; }//	家庭电话	String (20)		不可空	
        string DIANHUA { get; set; }//	手机号码	String (20)		不可空	1389897678
        string SHENFENZH { get; set; }//	身份证号码	String (20)		不可空	3.30238E+17
        string SEX { get; set; }//	性别	String(1)	1：男/2：女		1
        string BIRTHDAY { get; set; }//	出生日期	String(8)			
        string SHEBAOBH { get; set; }//	社保编号	String (50)		可空	6809910
        string YIBAOKH { get; set; }//	医保卡号	String(50)		可空	Z01437510
        string YINHANGKH { get; set; }//	银行卡号	String(50)		可空	
        string XUNIBH { get; set; }//	虚拟账户号	String(50)	在银行分配的虚拟账户号码	可空	
        string YINGERBZ { get; set; }//	新生儿标示	String(2)	新生儿标识 【规则】0否  1是	不可空	0/1
        string MUQINXM { get; set; }//	母亲姓名	String(20)		无身份证新生儿必填	
        string MUQINSFZH { get; set; }//	母亲身份证号码	String(20)		无身份证新生儿必填	
        string CHANCI { get; set; }//	产次	String(2)		无身份证新生儿必填	
        string TAICI { get; set; }//	胎次	String(2)	新生儿多胞胎出生的次序 	无身份证新生儿必填	
        string CREATEID { get; set; }//	请求来源ID	String(50)		不可空	
        string PTJGDM { get; set; }//	平台机构代码	String(50)	联调阶段使用固定值 320583000000 ，上线前由平台发放各机构代码	不可空	
        string PTJGMC { get; set; }//	平台机构名称	String(50)	联调阶段使用固定值 “昆山市卫生局”，上线前由平台发放各机构名称	不可空	
    }
}
