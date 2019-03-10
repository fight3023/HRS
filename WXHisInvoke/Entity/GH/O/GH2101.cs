using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.11.	(GH2101)(200101)挂号处理
    /// </summary>
    class GH2101 : BASE_O
    {
        string MZH { get; set; }//		20	门诊号(唯一号)	GH2101_TAB1
        string GHXH { get; set; }//		5	挂号序号(科室序号)	GH2101_TAB1
        string ZFEWM { get; set; }//		512	支付二维码	GH2101_TAB1
        string SFBH { get; set; }//		13	收费编号	GH2101_TAB1
        string GHFPDYXX { get; set; }//		--	挂号发票打印信息	GHFPDYXX
        string FPYBXX { get; set; }//		--	发票打印医保信息,见子数据包 FPYBJSXX	FPYBJSXX
    }
}
