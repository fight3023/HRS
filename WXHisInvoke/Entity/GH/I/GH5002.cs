using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.24.	(GH5002)取请假条信息
    /// </summary>
    class GH5002 : BASE_I
    {
        string CXFS { get; set; }//		6	查询方式 JZKH = 就诊卡号查 MZH = 门诊号查  BRBH = 病人编号查 KMM = 卡明码 ICK = 读IC卡 SFZHM身份证号  FPHM发票号码		INPARA
        string CXDM { get; set; }//		30	查询代码 当查询方式为ICK时,请先读卡传卡号（不要传SBK>1）	 其它的查询方式为要查询的值		INPARA
    }
}
