using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.18.	(GH1103)(100103)挂号状态查询处理
    /// </summary>
    public class GH1103 : BASE_I
    {
        public string JZKH { get; set; }//		30	就诊卡号	INPARA
        public string BRXM { get; set; }//		20	病人姓名	INPARA
        public string GHKSDM { get; set; }//		3	挂号科室代码	INPARA
        public string GHYSGH { get; set; }//		5	挂号医生工号 (如挂号科室一定要指定医生时,需要写)	INPARA
        public string SJLX { get; set; }//		1	时间类型(A=上午/P=下午/F=全天/N=夜间)	INPARA
    }
}
