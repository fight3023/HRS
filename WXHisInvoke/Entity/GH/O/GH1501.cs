using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.15.	(GH1501)(100501)获取科室介绍信息
    /// </summary>
    public class GH1501 : BASE_O
    {
        public string RET_ROW { get; set; }//		4	交易成功时返回的行数	
        public string GHKSDM { get; set; }//		3	科室代码, 动态数组	GH1501_TAB1
        public string GHKSMC { get; set; }//		20	科室名称, 动态数组	GH1501_TAB1
        public string JSXX { get; set; }//		2048	介绍信息, 动态数组	GH1501_TAB1
        public string KSWZ { get; set; }//		50	科室位置, 动态数组	GH1501_TAB1
        public string PBKSSJ { get; set; }//		8	排班开始时间	GH1501_TAB1
        public string PBJSSJ { get; set; }//		8	排班结束时间	GH1501_TAB1
        public string GHBZ { get; set; }//		1	是否可挂号(Y/N),动态数组	GH1501_TAB1
    }
}
