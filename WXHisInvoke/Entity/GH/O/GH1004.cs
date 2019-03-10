﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// (GH1004)(100004)取挂号科室号子信息
    /// </summary>
    class GH1004 : BASE_O
    {
        string CUR_NUM { get; set; }//		8	当前号	GH1004_TAB1
        string GHSL { get; set; }//		8	科室号总数	GH1004_TAB1
        string YYGHSL { get; set; }//		8	已挂号数量	GH1004_TAB1
        string DDRC { get; set; }//		8	等待人数	GH1004_TAB1
    }
}
