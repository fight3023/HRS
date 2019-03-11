using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// (GH1003)(100003)取挂号医生信息
    /// </summary>
    class GH1003 : BASE_O
    {
        string RET_ROW { get; set; }//		4	交易成功时返回的行数	
        string ZGGH { get; set; }//		5	职工工号,动态数组	GH1003_TAB1
        string ZGXM { get; set; }//		10	职工姓名,动态数组	GH1003_TAB1
        string GHKSDM { get; set; }//		3	隶属科室,动态数组	GH1003_TAB1
        string GHBZ { get; set; }//		1	是否可挂号(Y/N),动态数组	GH1003_TAB1
        string KSDM { get; set; }//		3	系统科室代码,动态数组	GH1003_TAB1
        string KSMC { get; set; }//		10	系统科室名称,动态数组	GH1003_TAB1
        string ZJDM { get; set; }//		6	诊间代码,动态数组	GH1003_TAB1
        string ZJMC { get; set; }//		10	诊间名称,动态数组	GH1003_TAB1
        string GHSL { get; set; }//		10	总挂号数量,动态数组	GH1003_TAB1
        string YYGHSL { get; set; }//		10	已挂号数量,动态数组	GH1003_TAB1
        string GHF { get; set; }//		10	挂号费,动态数组	GH1003_TAB1
        string ZLH { get; set; }//		10	诊疗费,动态数组	GH1003_TAB1
        string ZC { get; set; }//		10	职称,动态数组	GH1003_TAB1
        string PBKSSJ { get; set; }//		8	排班开始时间,动态数组	GH1003_TAB1
        string PBJSSJ { get; set; }//		8	排班结束时间,动态数组	GH1003_TAB1
        string SJLX { get; set; }//		1	时间标志(A=上午/P=下午/F=全天/N=夜间)	GH1003_TAB1
        string ZFFS { get; set; }//		1	支付方式 (G=挂帐,U=市民民卡)	GH1003_TAB1
    }
}
