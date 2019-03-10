using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.shoufei
{
    class ShoufeiJiesuanRequest
    {
        string BINGREID { get; set; }//	病人ID	VARCHAR2(10)		不为空	13080636
        string YILIAOJGID { get; set; }//	医疗机构ID	String(20)	医疗机构ID	不可空	
        string SHOUFEIREN { get; set; }//	终端用户ID	VARCHAR2(10)		不为空	2321
        string ZHIFUFS { get; set; }//	支付方式	VARCHAR2(10)	两个取值,具体取值要等上线确定,调试过程传11(自助pos支付)	不为空	微信:31
        string JIESUANIDS { get; set; }//	结算单ID串 	VARCHAR2(2000)	处方(医技)ID^结算单类型^就诊ID	不为空	chufangid1^1^jiuzhenid1@@yijiid1^2^jiuzhenid1@@chufangid2^1^jiuzhenid2@@yijiid2^2^jiuzhenid2
        string SHIFUJE { get; set; }//	实付金额	Number(18,4)		不为空	289.5
        string JIAOYILSH { get; set; }//	交易流水号	VARCHAR2(20)	有医保交易返回,否则为空	可空	
        string FAPIAOID { get; set; }//	发票ID	VARCHAR2(20)	有医保交易返回,否则为空	可空	
        string JIAOYIRQ { get; set; }//	交易日期	VARCHAR2(20)		不为空	
        string KAHAO { get; set; }//	卡号	VARCHAR2(20)		不为空	
        string JIAOYILX { get; set; }//	交易类型	VARCHAR2(10)		不为空	
        string YINHANGJYLSH { get; set; }//	银行交易流水号	VARCHAR2(20)		不为空	
        string JIESUANLB { get; set; }//	结算类别	VARCHAR2(10)	001：自费/003：医保（东软使用）	不为空	
        string YIBAOJSID { get; set; }//	医保结算ID	VARCHAR2(20)	有医保交易返回,否则为空	不为空	
        string JIESUANZJE { get; set; }//	结算总金额	VARCHAR2(20)	取1503返回值	不为空	
        string YUANQUID { get; set; }//	院区ID	String(20)	用于标识同一家医院的不同院区	不可空	1
        string YINHANGJYLSHNEW { get; set; }//	银行交易流水号(新)	VARCHAR2(20)	(微信、支付宝支付情况下传平台订单号)	不为空	
        string YINHANGJYRQ { get; set; }//	银行交易日期	VARCHAR2(8)	YYYYMMDD	不为空	
        string DAIKOUJSBZ { get; set; }//	代扣结算标志	VARCHAR2(1)		不为空	1.代扣结算
        string DAIKOUTHJE { get; set; }//	代扣退回金额	Number(18,4)		代扣结算不可空	代扣结算时传入退回给病人的费用(医保预结算交易返还)
        string SHANGHUDDH { get; set; }//	商户订单号	VARCHAR2(50)			
        string SHANGHUDDSJ { get; set; }//	商户订单交易时间	VARCHAR2(20)			时间戳
    }
}
