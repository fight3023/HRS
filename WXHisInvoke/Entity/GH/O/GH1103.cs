using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.18.	(GH1103)(100103)挂号状态查询处理
    /// </summary>
    class GH1103 : BASE_O
    {
        string GHZT { get; set; }//		1	挂号状态 0=挂新号 1=补打 2=转科 3=有未结算挂号	GH1103_TAB1
        string TSXX { get; set; }//		50	提示信息 GHZT=0时 信息为 挂新号 GHZT=1时 信息为 门诊号 GHZT=2 时 信息为 原科室名称 GHZT=3 时 信息为 未结算的挂号日期与科室 如 您还有以下挂号没结算,现在不能挂号!	2009年01月01日 挂过 内科	2009年01月01日 挂过 外科	GH1103_TAB1	
    }
}
