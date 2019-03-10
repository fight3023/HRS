using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.dangan
{
    /// <summary>
    ///  病人主索引响应参数
    /// </summary>
    class DanganBingrenResponse : CommonResponse
    {
        string BINGRENID { get; set; }//	病人ID	String (10)	如果返回为空,代表MPI有但HIS没有,需要再调用建档交易	可空	10015745
        string SHEBAOBH { get; set; }//	社保编号	String (50)		可空	
        string YIBAOKH { get; set; }//	医保卡号	String (50)		可空	
        string JIUZHENKH { get; set; }//	就诊卡号	String (20)	如果返回为空,代表MPI有但HIS没有,需要再调用建档交易	可空	
        string SHEQUBH { get; set; }//	社区编号	String (50)		可空	
        string FEIYONGLB { get; set; }//	费用类别	String (10)		可空	
        string FEIYONGLBMC { get; set; }//	费用类别名称	String (100)		可空	
        string FEIYONGXZ { get; set; }//	费用性质	String (10)		可空	
        string FEIYONGXZMC { get; set; }//	费用性质名称	String (100)		可空	
        string YOUHUILB { get; set; }//	优惠类别	String (4)		可空	
        string YOUHUILBMC { get; set; }//	优惠类别名称	String (100)		可空	
        string GONGFEIZH { get; set; }//	公费证号	String (20)		可空	
        string GONGFEIDW { get; set; }//	公费单位	String (20)		可空	
        string GONGFEIDWMC { get; set; }//	公费单位名称	String (100)		可空	
        string XINGMING { get; set; }//	姓名	String (50)		不可空	张三
        string SHURUMA1 { get; set; }//	输入码1	String (10)		可空	
        string SHURUMA3 { get; set; }//	输入码3	String (10)		可空	
        string SHURUMA2 { get; set; }//	输入码2	String (10)		可空	
        string XINGBIE { get; set; }//	性别	String (4)		可空	
        string NIANLINGDW { get; set; }//	年龄单位	String (4)		可空	
        string ZHENGJIANLX { get; set; }//	证件类型	String（20）	关联证件类型	不为空	20221
        string SHENFENZH { get; set; }//	身份证号	String (20)		可空	
        string CHUSHENGRQ { get; set; }//	出生日期	DATE		可空	
        string GONGZUODW { get; set; }//	工作单位	String (100)		可空	
        string DANWEIDH { get; set; }//	单位电话	String (50)		可空	
        string DANWEIYB { get; set; }//	单位邮编	String (10)		可空	
        string JIATINGDZ { get; set; }//	家庭地址	String (100)		可空	
        string JIATINGDH { get; set; }//	家庭电话	String (50)		可空	
        string JIATINGYB { get; set; }//	家庭邮编	String (10)		可空	
        string DIANHUA { get; set; }//	电话	String (50)		可空	
        string XIANZHIKSLB { get; set; }//	限制科室列表	String (500)	英文逗号隔开,由HIS返回给自助机该病人不能在自助机挂号的科室列表	可空	
        string XIANZHIYLXMLB { get; set; }//	限制医疗项目列表	String (500)	英文逗号隔开, 由HIS返回给自助机该病人不能在自助机使用的医疗项目列表	可空	
        string YINGERBZ { get; set; }//	婴儿标志	String(2)	1:是,0.否		0/1
        string MUQINXM { get; set; }//	母亲姓名	String(20)		无身份证新生儿必填	
        string MUQINSFZH { get; set; }//	母亲身份证号码	String(20)		无身份证新生儿必填	
        string TAICI { get; set; }//	产次	String(2)		无身份证新生儿必填	
        string CHANCI { get; set; }//	胎次	String(2)	新生儿多胞胎出生的次序 	无身份证新生儿必填	
    }
}
