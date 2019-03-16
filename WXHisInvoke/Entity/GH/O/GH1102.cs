using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.14.	(GH1102)(100102)挂号查询
    /// </summary>
    public class GH1102 : BASE_O
    {
        public string RET_ROW { get; set; }//		4	返回行数	
        public string JZKH { get; set; }//		30	就诊卡号,动态数组	GH1102_TAB1
        public string MZH { get; set; }//		20	门诊号 ,动态数组	GH1102_TAB1
        public string SJLX { get; set; }//		1	时间标志(A=上午/P=下午/F=全天/N=夜间)	GH1102_TAB1
        public string GHKSDM { get; set; }//		3	挂号科室代码, 动态数组	GH1102_TAB1
        public string GHKSMC { get; set; }//		20	挂号科室名称, 动态数组	GH1102_TAB1
        public string ZJDM { get; set; }//		6	诊间代码, 动态数组	GH1102_TAB1
        public string ZJMC { get; set; }//		20	诊间名称, 动态数组	GH1102_TAB1
        public string YSGH { get; set; }//		5	医生工号, 动态数组	GH1102_TAB1
        public string YSXM { get; set; }//		10	医生姓名, 动态数组	GH1102_TAB1
        public string GHZT { get; set; }//		1	挂号状态(1/2/3  待诊/接诊//诊完) , 动态数组	GH1102_TAB1
        public string SFFYZT { get; set; }//		1	收费发药状态(0/1/2/3/4  未收费/收费中/检验收费/已收费/已发药) , 动态数组	GH1102_TAB1
    }
}
