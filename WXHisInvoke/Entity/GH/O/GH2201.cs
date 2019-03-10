using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.22.	(GH2201)(220001)网上预约信息获取
    /// </summary>
    class GH2201
    {
        string BRXM { get; set; }//		20	病人姓名	GH2201_TAB1
        string BRXB { get; set; }//		1	病人性别(M 男，F女)	GH2201_TAB1
        string CSRQ { get; set; }//		10	出生日期(YYYY-MM-DD)	GH2201_TAB1
        string DJSJ { get; set; }//		20	预约时间(YYYY-MM-DD HH:MM:SS)	GH2201_TAB1
        string GHKSDM { get; set; }//		3	挂号科室代码	GH2201_TAB1
        string GHYSBH { get; set; }//		5	挂号医生编号	GH2201_TAB1
        string SJLX { get; set; }//		1	门诊时间(A上午/P下午/F全部)	GH2201_TAB1
        string GHXH { get; set; }//		4	挂号号数	GH2201_TAB1
        string PBKSSJ { get; set; }//		8	排班开始时间(hh:mm:ss)	GH2201_TAB1
        string PBJSSJ { get; set; }//		8	排班结束时间(hh:mm:ss)	GH2201_TAB1
        string YYHM { get; set; }//		13	预约登记号	
    }
}
