using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.14.	(GH1102)(100102)挂号查询
    /// </summary>
    public class GH1102 : BASE_I
    {
        public string CXFS { get; set; }//		6	查询方式 JZKH = 就诊卡号查MZH = 门诊号查	BRBH = 病人编号查	 KMM = 卡明码		INPARA 
        public string CXDM { get; set; }//		30	查询代码 查询方式 JZKH = 就诊卡号查	MZH = 门诊号查	BRBH = 病人编号查	 KMM = 卡明码		INPARA 
    }
}
