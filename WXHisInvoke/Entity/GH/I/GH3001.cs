﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.20.	(GH3001)(230001)预算支付预存
    /// </summary>
    public class GH3001 : BASE_I
    {
        public string ZFFS { get; set; }//		1	支付方式 N=挂帐, J=建行市民卡付,其它=挂帐	INPARA
        public string ZFLSH { get; set; }//		30	支付流水号	INPARA
        public string ZFZDH { get; set; }//		5	支付终端号(银行)	INPARA
        public string JZKH { get; set; }//		30	病人就诊卡号	INPARA
        public string GHKSDM { get; set; }//		3	挂号科室代码	INPARA
        public string GHYSGH { get; set; }//		5	挂号医生工号 (如挂号科室一定要指定医生时,需要写)	INPARA
        public string YCLY { get; set; }//		1	预分类(G=挂号,M=收费)	INPARA
        public string FYZE { get; set; }//		8	费用总额	INPARA
        public string ZFJE { get; set; }//		8	支付金额	INPARA
        public string JZJE { get; set; }//		8	记帐金额	INPARA
        public string JMJE { get; set; }//		8	减免金额	INPARA
    }
}
