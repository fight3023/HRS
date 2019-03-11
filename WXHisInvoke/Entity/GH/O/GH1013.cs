using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.7.	(GH1013) 取医保特病
    /// </summary>
    class GH1013 : BASE_O
    {
        string RET_ROW { get; set; }//		4	交易成功时返回的行数	
        string TBDM { get; set; }//		10	特病代码	GH1013_TAB1
        string TBMC { get; set; }//		100	特病名称	GH1013_TAB1
    }
}
