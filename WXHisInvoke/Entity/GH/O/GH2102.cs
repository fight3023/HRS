using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.12.	(GH2102)(200102)退号处理
    /// </summary>
    public class GH2102 : BASE_O
    {
        public string JZKH { get; set; }//		30	就诊卡号如果是社保卡传入SBK>社保卡类型 (对应IC_CARD.DM)		INPARA
        public string MZH { get; set; }//		20	门诊号	INPARA
    }
}
