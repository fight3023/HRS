using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.11.	(GH2101)(200101)挂号处理
    /// </summary>
    public class GH2101 : BASE_I
    {
        public string JZKH { get; set; }//		30	就诊卡号	INPARA	
        public string BRXM { get; set; }//		20	病人姓名	INPARA	
        public string GHKSDM { get; set; }//		3	挂号科室代码	INPARA	
        public string GHYSGH { get; set; }//		5	挂号医生工号 (如挂号科室一定要指定医生时,需要写)	INPARA	
        public string SJLX { get; set; }//		1	时间标志(A=上午/P=下午/F=全天/N=夜间)	INPARA	
        public string FYZE { get; set; }//		8	费用总额	INPARA	
        public string ZFJE { get; set; }//		8	支付金额	INPARA	
        public string JZJE { get; set; }//		8	记帐金额	INPARA	
        public string JMJE { get; set; }//		8	减免金额	INPARA	
        public string GHQD { get; set; }//		1	挂号渠道 Y =医生,Z=自助机 (传空默认为自助机), 原GHLY	INPARA	
        public string ZFFS { get; set; }//		1	支付方式 见值域说明 支付方式(ZFFS)	INPARA	
        public string YBYWJC { get; set; }//		1	院外检查 Y/N（宁波医保病人有效）	INPARA	
        public string YBTBDM { get; set; }//		4	特病代码（宁波医保病人有效）	INPARA	
        public string WGZFJG { get; set; }//		--	网上挂号支付结果		
        public string ZFJG { get; set; }//		--	支付结果 根据不同的支付方式,传入不同结果数据包,支付方式为挂帐时,该值可以为空见值域说明 支付方式(ZFFS)		 	JHZFJG	
        public string ZKJE { get; set; }//		8	折扣金额	INPARA	
        public string ZKFS { get; set; }//		1	折扣方式M医院减免 T平台补助	INPARA	
        public string ZKMC { get; set; }//		14	折扣名称	INPARA	
        public string JZYSBH { get; set; }//		5	接诊医生编号	INPARA	
        public string KSXH { get; set; }//		5	科室序号	INPARA	
    }
}
