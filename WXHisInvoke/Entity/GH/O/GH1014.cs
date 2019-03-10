using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.8.	(GH1014) 取病人信息（多行）
    /// </summary>
    class GH1014 : BASE_O
    {
        string RET_ROW { get; set; }//		4	交易成功时返回的行数	
        string ZT { get; set; }//		1	0门诊1住院	GH1014_TAB1
        string ZYH { get; set; }//		10	状态为1时有效	GH1014_TAB1
        string JZKH { get; set; }//		30	就诊卡号	GH1014_TAB1
        string BRXM { get; set; }//		10	姓名	GH1014_TAB1
        string FBLX { get; set; }//		10	病人性质	GH1014_TAB1
        string BRBH { get; set; }//		10	病人编号	GH1014_TAB1
        string XB { get; set; }//		10	病人性别(F/M/N 女/男/其他)	GH1014_TAB1
        string CSRQ { get; set; }//		10	出生日期	GH1014_TAB1
        string TELE { get; set; }//		20	联系电话	GH1014_TAB1
        string BRDZ { get; set; }//		60	 病人地址	GH1014_TAB1
    }
}
