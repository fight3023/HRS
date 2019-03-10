using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.24.	(GH5002)取请假条信息
    /// </summary>
    class GH5002 : BASE_O
    {
        string RET_ROW { get; set; }//		4	交易成功时返回的行数			
        string SQDBH { get; set; }//		20		申请单编号	GH5002_TAB1	
        string BRBH { get; set; }//		10		病人编号	GH5002_TAB1	
        string MZH { get; set; }//		20		门诊号（通过门诊号查询时有效）	GH5002_TAB1	
        string BRXM { get; set; }//		10		姓名	GH5002_TAB1	
        string BRXB { get; set; }//		10		病人性别(F/M/N 女/男/其他)	GH5002_TAB1	
        string CSRQ { get; set; }//		10		出生日期	GH5002_TAB1	
        string BRXZDM { get; set; }//		2		病人性质	GH5002_TAB1	
        string BRXZMC { get; set; }//		20		病人性质名称(自费,医保,农保等)	GH5002_TAB1	
        string GFNO { get; set; }//		20		公费号	GH5002_TAB1	
        string SFZH { get; set; }//		20		身份证号	GH5002_TAB1	
        string BRDZ { get; set; }//		128		 病人地址	GH5002_TAB1	
        string LXDH { get; set; }//		20		联系电话	GH5002_TAB1	
        string HYZK { get; set; }//		1		婚姻状况(1.未 2.已 3.离 4.丧)	GH5002_TAB1	
        string ZT { get; set; }//		1		0门诊1住院	GH5002_TAB1	
        string ZYH { get; set; }//		10		状态为1时有效	GH5002_TAB1	
        string ZDYJ { get; set; }//		500		诊断意见	GH5002_TAB1	
        string JY { get; set; }//		500		建议	GH5002_TAB1	
        string SQYS { get; set; }//		10		申请医师	GH5002_TAB1	
        string SQSJ { get; set; }//		20		申请时间	GH5002_TAB1	
        string DYCS { get; set; }//		10		打印次数	GH5002_TAB1	
    }
}
