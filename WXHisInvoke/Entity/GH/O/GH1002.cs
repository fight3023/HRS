using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// (GH1002)(100002)取挂号科室
    /// </summary>
    public class GH1002 : BASE_O
    {
        public string RET_ROW { get; set; }//		4	交易成功时返回的行数	
        public string GHKSDM { get; set; }//		3	挂号科室代码	GH1002_TAB1
        public string GHKSMC { get; set; }//		10	挂号科室名称	GH1002_TAB1
        public string GHKSLB { get; set; }//		1	科室门诊类型，对应MZGHLXB.BH	GH1002_TAB1
        public string ZTDM { get; set; }//		2	诊台代码	GH1002_TAB1
        public string ZTMC { get; set; }//		30	诊台名称	GH1002_TAB1
        public string ZGGH { get; set; }//		5	如有指定医生,则ZGGH为指定的医生工号	GH1002_TAB1
        public string ZGXM { get; set; }//		10	如有指定医生,则ZGXM为指定的医生医生	GH1002_TAB1
        public string GHF { get; set; }//		10	挂号费	GH1002_TAB1
        public string ZLF { get; set; }//		10	诊疗费	GH1002_TAB1
        public string GHSL { get; set; }//		10	总挂号数量	GH1002_TAB1
        public string YYGHSL { get; set; }//		10	已挂号数量	GH1002_TAB1
        public string KZDYS { get; set; }//		1	可指定医生	GH1002_TAB1
        public string GHBZ { get; set; }//		1	当前可挂号标志 (Y/N)	GH1002_TAB1
        public string PBKSSJ { get; set; }//		8	排班开始时间	GH1002_TAB1
        public string PBJSSJ { get; set; }//		8	排班结束时间	GH1002_TAB1
        public string SJLX { get; set; }//		1	时间标志(A=上午/P=下午/F=全天/N=夜间)	GH1002_TAB1
        public string PHOTONAME { get; set; }//		50	指定医生照片	GH1002_TAB1
        public string ZFFS { get; set; }//		1	支付方式 (G=挂帐,U=市民民卡)	GH1002_TAB1
        public string KSFL { get; set; }//		4	挂号科室分类	GH1002_TAB1
        public string KSFLMC { get; set; }//		128	挂号科室分类名称	GH1002_TAB1
    }
}
