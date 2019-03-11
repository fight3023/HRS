using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// (GH2011)(200103)门诊病人信息录入
    /// </summary>
    class GH2011 : BASE_O
    {
        string JZKH { get; set; }//		30	就诊卡号	GH1012_TAB1
        string BRBH { get; set; }//		10	病人编号(病历号)	GH1012_TAB1
        string CZSJ { get; set; }//		20	操作时间YYYY-MM-DD HH:MM:SS	GH1012_TAB1
    }
}
