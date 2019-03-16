using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.10.	(GH2104)(200104)挂号预算
    /// </summary>
    public class GH2104 : BASE_I
    {
        public string JZKH { get; set; }//		30	就诊卡号如果是社保卡传入SBK>社保卡类型 (对应IC_CARD.DM)		INPARA
        public string BRXM { get; set; }//		20	病人姓名	INPARA
        public string GHKSDM { get; set; }//		3	挂号科室代码	INPARA
        public string GHYSGH { get; set; }//		5	挂号医生工号 (如挂号科室一定要指定医生时,需要写)	INPARA
        public string SJLX { get; set; }//		1	时间标志(A=上午/P=下午/F=全天/N=夜间)	INPARA
        public string ZFFS { get; set; }//		1	支付方式  见值域说明 支付方式(ZFFS)	INPARA
        public string SJH { get; set; }//		20	手机号 (ZFFS=W时需传入)	INPARA
        public string YZM { get; set; }//		10	验证码 (ZFFS=W时需传入)	INPARA
        public string YYHM { get; set; }//		13	预约登记号 (ZFFS=WZ时需传入)	INPARA
        public string YBYWJC { get; set; }//		1	院外检查 Y/N（宁波医保病人有效）	INPARA
        public string YBTBDM { get; set; }//		4	特病代码（宁波医保病人有效）	INPARA
        public string ZKJE { get; set; }//		8	折扣金额	INPARA
        public string ZKFS { get; set; }//		1	折扣方式M医院减免 T平台补助	INPARA
        public string ZKMC { get; set; }//		14	折扣名称	INPARA
        public string JZYSBH { get; set; }//		5	接诊医生编号	INPARA
        public string KSXH { get; set; }//		5	科室序号	INPARA
    }
}
