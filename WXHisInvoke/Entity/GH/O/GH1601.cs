using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.16.	(GH1601)(100601)获取医生介绍信息
    /// </summary>
    public class GH1601 : BASE_O
    {
        public string RET_ROW { get; set; }//		4	交易成功时返回的行数	
        public string ZGGH { get; set; }//		5	医生工号, 动态数组	GH1601_TAB1
        public string ZGXM { get; set; }//		10	医生姓名, 动态数组	GH1601_TAB1
        public string ZC { get; set; }//		32	职称，动态数组	GH1601_TAB1
        public string JSXX { get; set; }//		2048	介绍信息, 动态数组	GH1601_TAB1
        public string FILENAME { get; set; }//		50	照片存放路径及名称, 动态数组	GH1601_TAB1
        public string PBKSSJ { get; set; }//		8	排班开始时间	GH1601_TAB1
        public string PBJSSJ { get; set; }//		8	排班结束时间	GH1601_TAB1
        public string GHBZ { get; set; }//		1	是否可挂号(Y/N),动态数组	GH1601_TAB1
        public string XB { get; set; }//		2	医生性别	GH1601_TAB1
        public string CSRQ { get; set; }//		10	医生出生日期 格式：YYYY-MM-DD	GH1601_TAB1
        public string KSBH { get; set; }//		3	科室编号	GH1601_TAB1
        public string KSMC { get; set; }//		12	科室名称	GH1601_TAB1
    }
}
