using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.17.	(GH2501)(200501)获取挂号打印信息
    /// </summary>
    public class GH2501
    {
        public string GHKSMC { get; set; }//		30	挂号科室名称	GH2501_TAB1
        public string GHYSXM { get; set; }//		30	挂号科室姓名	GH2501_TAB1
        public string KSWZ { get; set; }//		30	科室位置	GH2501_TAB1
        public string GHLB { get; set; }//		30	挂号类别	GH2501_TAB1
        public string GHXH { get; set; }//		30	挂号序号	GH2501_TAB1
        public string SJLX { get; set; }//		1	时间分类 A=上午/P=下午/F=全天/N=晚上	GH2501_TAB1
        public string GHSJ { get; set; }//		20	挂号时间 返回日期时间 yyyy-mm-dd hh:mm:ss	GH2501_TAB1
        public string ZLF { get; set; }//		10	诊疗费	GH2501_TAB1
        public string GHF { get; set; }//		10	挂号费	GH2501_TAB1
        public string ZJMC { get; set; }//		30	诊间名称	GH2501_TAB1
        public string FYZE { get; set; }//		8	费用总额	GH2501_TAB1
        public string ZFJE { get; set; }//		8	支付金额	GH2501_TAB1
        public string JZJE { get; set; }//		8	记帐金额	GH2501_TAB1
        public string JMJE { get; set; }//		8	减免金额	GH2501_TAB1
        public string GZJE { get; set; }//		8	挂帐金额	GH2501_TAB1
        public string SJKK { get; set; }//		8	手机扣款金额	GH2501_TAB1
        public string SRJE { get; set; }//		8	舍入金额	GH2501_TAB1
        public string BLH { get; set; }//		20	病历号	GH2501_TAB1
        public string BRXM { get; set; }//		20	病人姓名	GH2501_TAB1
        public string JZKH { get; set; }//		30	就诊卡号	GH2501_TAB1
        public string FPH { get; set; }//		20	发票号	GH2501_TAB1
        public string BRXB { get; set; }//		1	病人性别 (F/M/N 女/男/其他)	GH2501_TAB1
        public string BRNL { get; set; }//		10	病人年龄 (字符表示 如1岁3月,2月12天,21岁)	GH2501_TAB1
        public string FBBZ { get; set; }//		1	病人性质	GH2501_TAB1
        public string FBBZMC { get; set; }//		20	病人性质名称 (自费,医保,农保等)	GH2501_TAB1
    }
}
