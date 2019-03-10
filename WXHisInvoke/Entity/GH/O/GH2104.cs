using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.10.	(GH2104)(200104)挂号预算
    /// </summary>
    class GH2104 : BASE_O
    {
        string FYZE { get; set; }//		8	费用总额	GH2014_TAB1
        string ZFJE { get; set; }//		8	支付金额	GH2014_TAB1
        string JZJE { get; set; }//		8	记帐金额	GH2014_TAB1
        string JMJE { get; set; }//		8	减免金额	GH2014_TAB1
        string JEFTXX { get; set; }//		--	金额分推明细,如医保的各项基金 见 金额分推子数据结构 JSFTMX	JSFTMX
        string TSXX { get; set; }//		--	结算提示信息	
    }
}
