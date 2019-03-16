using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.21.	(GH1302)(100302)挂号类别获取
    /// </summary>
    public class GH1302 : BASE_O
    {
        public string RET_ROW { get; set; }//		5	返回行数	
        public string LBDM { get; set; }//		5	类别代码	GH1302_TAB1
        public string LBMC { get; set; }//		20	类别名称	GH1302_TAB1
        public string DYKSLB { get; set; }//		10	对应的科室门诊类型,多个用逗号隔开 如   1,2	GH1302_TAB1
    }
}
