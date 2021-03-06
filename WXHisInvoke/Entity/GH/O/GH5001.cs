﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// 3.23.	(GH5001)取历史挂号信息
    /// </summary>
    public class GH5001
    {
        public string BRBH { get; set; }//		10		病人编号		GH5001_TAB1
        public string BRXM { get; set; }//		10		姓名		GH5001_TAB1
        public string GFNO { get; set; }//		30		医疗证号		GH5001_TAB1
        public string BRXB { get; set; }//		10	病人性别		GH5001_TAB1	
        public string SFZH { get; set; }//		30	身份证号码		GH5001_TAB1	
        public string RET_ROW { get; set; }//		4	交易成功时返回的行数			
        public string MZH { get; set; }//		20		门诊号		GH5001_TAB1
        public string KMM { get; set; }//		20		卡明码		GH5001_TAB1
        public string FBBZ { get; set; }//		2		费别标志		GH5001_TAB1
        public string FBMC { get; set; }//		12		费别名称		GH5001_TAB1
        public string MZLX { get; set; }//		10		门诊类型（普通，专家…）		GH5001_TAB1
        public string KSMC { get; set; }//		60		挂号科室名称		GH5001_TAB1
        public string MZSJ { get; set; }//		10		门诊时间段（上午/下午/全天/夜晚）		GH5001_TAB1
        public string GHFY { get; set; }//		10		挂号费用		GH5001_TAB1
        public string JZZT { get; set; }//		10		就诊状态（未接诊、已收费….）		GH5001_TAB1
        public string JZXH { get; set; }//		10		就诊序号		GH5001_TAB1
        public string YSGH { get; set; }//		10		医生工号		GH5001_TAB1
        public string YSXM { get; set; }//		30		医生姓名		GH5001_TAB1
        public string GHSJ { get; set; }//		30		挂号时间		GH5001_TAB1
    }
}
