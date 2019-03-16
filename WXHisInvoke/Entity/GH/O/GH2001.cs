using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.19.	(GH2001)(210001)挂号就诊开单查询
    /// </summary>
    public class GH2001 : BASE_O
    {
        public string RET_ROW { get; set; }//		4	返回行数	
        public string JZKH { get; set; }//		30	就诊卡号,动态数组	GH2001_TAB1
        public string MZH { get; set; }//		20	门诊号 ,动态数组	GH2001_TAB1
        public string GHKSDM { get; set; }//		3	挂号科室代码, 动态数组	GH2001_TAB1
        public string GHKSMC { get; set; }//		20	挂号科室名称, 动态数组	GH2001_TAB1
        public string GHSJ { get; set; }//		20	YYYY-MM-DD HH:MM:SS, 动态数组	GH2001_TAB1
        public string JZYSGH { get; set; }//		5	接诊医生工号, 动态数组	GH2001_TAB1
        public string JZYSXM { get; set; }//		5	接诊医生姓名, 动态数组	GH2001_TAB1
        public string CFSL { get; set; }//		2	处方数量, 动态数组	GH2001_TAB1
        public string CFJE { get; set; }//		8	处方金额, 动态数组	GH2001_TAB1
        public string HYDSL { get; set; }//		2	化验单数量, 动态数组	GH2001_TAB1
        public string HYDJE { get; set; }//		8	化验单金额, 动态数组	GH2001_TAB1
        public string JCDSL { get; set; }//		2	检查单数量, 动态数组	GH2001_TAB1
        public string JCDJE { get; set; }//		8	检查单金额, 动态数组	GH2001_TAB1
        public string ZLDSL { get; set; }//		8	治疗单数量, 动态数组	GH2001_TAB1
        public string ZLDJE { get; set; }//		8	治疗单金额, 动态数组	GH2001_TAB1
        public string QTJE { get; set; }//		8	其它金额, 动态数组	GH2001_TAB1
        public string FYZE { get; set; }//		8	费用总额, 动态数组	GH2001_TAB1
    }
}
