using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.guahao
{
    /// <summary>
    /// 挂号收费请求参数
    /// </summary>
    class GuahaoShoufeiRequest
    {
        string BINGRENID	{get;set;}//	病人ID	String(20)		不可空	5676
        string SHENFENZH { get; set; }//	身份证号	String(20)		不可空	5676
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string YINGERBZ { get; set; }//	婴儿标志	String(1)	1：是；0：否	不可空	
        string CHANCI { get; set; }//	产次	String(2)		无身份证新生儿必填	
        string TAICI { get; set; }//	胎次	String(2)	新生儿多胞胎出生的次序 	无身份证新生儿必填	
        string JIESUANLB { get; set; }//	结算类别	String(20)	001：自费/003：医保（东软使用）	不可空	
        string PAIBANID { get; set; }//	排班ID	String (20)		不可空	30211201
        string GUAHAOREN { get; set; }//	终端用户ID	String (20)		不可空	DBA
        string GUAHAORXM { get; set; }//	终端用户名	String (20)		不可空	超级用户
        string SHANGXIAWBZ { get; set; }//	上下午标志 	Number(1)	0上午,1下午,2.晚上	不可空	0
        string JIAOYIRQ { get; set; }//	交易日期	String (20)		不可空	
        string YINHANGJYLSH { get; set; }//	银行交易流水号	String (20)		不可空	
        string KAHAO { get; set; }//	卡号	String (20)		不可空	
        string JIAOYILX { get; set; }//	交易类型	String (10)		不可空	
        string SHIFUJE { get; set; }//	实付金额	Number（18,4）		不可空	
        string YUYUEID { get; set; }//	预约ID	String (10)	新加入参：1.普通挂号预约id传空；2.预约取号支付预约id传相应的预约id		101086
        string YUANQUID { get; set; }//	院区ID	String(20)	用于标识同一家医院的不同院区	不可空	1
        string ZHENJIANDKKTBZ { get; set; }//	诊间代扣开通标志	String(1)	1.开通	不可空	0.不开通		
    }
}
