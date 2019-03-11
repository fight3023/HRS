using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.2.	(GH1011)(100101)取门诊病人信息
    /// </summary>
    class GH1011 : BASE_I
    {
        /// <summary>
        /// 6	查询方式 JZKH = 就诊卡号查 MZH = 门诊号查;BRBH = 病人编号查;KMM = 卡明码;ICK = 读IC卡 ;SFZH = 身份证号查	INPARA
        /// </summary>
        string CXFS { get; set; }
        /// <summary>
        /// 30	查询代码 当查询方式为ICK时,传入ICK的类型(对应FBLXB.BZ) 其它的查询方式为要查询的值	INPARA
        /// </summary>
        string CXDM { get; set; }
    }
}
