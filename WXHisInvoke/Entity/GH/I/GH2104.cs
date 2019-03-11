﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.10.	(GH2104)(200104)挂号预算
    /// </summary>
    class GH2104 : BASE_I
    {
        string JZKH { get; set; }//		30	就诊卡号如果是社保卡传入SBK>社保卡类型 (对应IC_CARD.DM)		INPARA
        string BRXM { get; set; }//		20	病人姓名	INPARA
        string GHKSDM { get; set; }//		3	挂号科室代码	INPARA
        string GHYSGH { get; set; }//		5	挂号医生工号 (如挂号科室一定要指定医生时,需要写)	INPARA
        string SJLX { get; set; }//		1	时间标志(A=上午/P=下午/F=全天/N=夜间)	INPARA
        string ZFFS { get; set; }//		1	支付方式  见值域说明 支付方式(ZFFS)	INPARA
        string SJH { get; set; }//		20	手机号 (ZFFS=W时需传入)	INPARA
        string YZM { get; set; }//		10	验证码 (ZFFS=W时需传入)	INPARA
        string YYHM { get; set; }//		13	预约登记号 (ZFFS=WZ时需传入)	INPARA
        string YBYWJC { get; set; }//		1	院外检查 Y/N（宁波医保病人有效）	INPARA
        string YBTBDM { get; set; }//		4	特病代码（宁波医保病人有效）	INPARA
        string ZKJE { get; set; }//		8	折扣金额	INPARA
        string ZKFS { get; set; }//		1	折扣方式M医院减免 T平台补助	INPARA
        string ZKMC { get; set; }//		14	折扣名称	INPARA
        string JZYSBH { get; set; }//		5	接诊医生编号	INPARA
        string KSXH { get; set; }//		5	科室序号	INPARA
    }
}
