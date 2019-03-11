using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.23.	(GH5001)取历史挂号信息
    /// </summary>
    class GH5001 : BASE_I
    {
        string CXFS { get; set; }//		6	查询方式 JZKH = 就诊卡号查 MZH = 门诊号查	  BRBH = 病人编号查	  KMM = 卡明码  ICK = 读IC卡		INPARA 
        string CXDM { get; set; }//		30	查询代码 当查询方式为ICK时,传入ICK的类型(对应FBLXB.BZ)	 其它的查询方式为要查询的值		INPARA
        string QSRQ { get; set; }//		10	起始日期	INPARA
        string JSRQ { get; set; }//		10	结束日期	INPARA
    }
}
