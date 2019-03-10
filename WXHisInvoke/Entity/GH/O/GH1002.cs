﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.O
{
    /// <summary>
    /// (GH1002)(100002)取挂号科室
    /// </summary>
    class GH1002 : BASE_O
    {
        string JZKH { get; set; } //30	就诊卡号	GH1011_TAB1
        string BRBH { get; set; } //	10	病人编号	GH1011_TAB1
        string MZH { get; set; } //20	门诊号（通过门诊号查询时有效）	GH1011_TAB1
        string KMM { get; set; } //20	卡明码	GH1011_TAB1
        string BRXM { get; set; } //10	姓名	GH1011_TAB1
        string BRXB { get; set; } //10	病人性别(F/M/N 女/男/其他)	GH1011_TAB1
        string CSRQ { get; set; } //	10	出生日期	GH1011_TAB1
        string NL { get; set; } //10	年龄(字符表示 如1岁3月,2月12天,21岁)	GH1011_TAB1
        string BRXZDM { get; set; } //	2	病人性质	GH1011_TAB1
        string BRXZMC { get; set; } //	20	病人性质名称(自费,医保,农保等)	GH1011_TAB1
        string GFNO { get; set; } //20	公费号	GH1011_TAB1
        string SFZH { get; set; } //20	身份证号	GH1011_TAB1
        string BRDZ { get; set; } //60	 病人地址	GH1011_TAB1
        string LXDH { get; set; } //20	联系电话	GH1011_TAB1
        string HYZK { get; set; } //1	婚姻状况(1.未 2.已 3.离 4.丧)	GH1011_TAB1
        string YHLXDM { get; set; } //1	优惠类型代码	GH1011_TAB1
        string YHLXMC { get; set; } //20	优惠类型名称	GH1011_TAB1
        string YHHM { get; set; } //20	优惠号码	GH1011_TAB1
        string KZT { get; set; } //1	状态(1 正常,0注销,2停用)	GH1011_TAB1
        string GHSL { get; set; } //2	当天已挂号数	GH1011_TAB1
        string YBDQYE { get; set; } //16	医保当年余额	GH1011_TAB1
        string YBLNYE { get; set; } //16	医保历年余额	GH1011_TAB1
        string ZJLX { get; set; } //1	证件类型 I 身份证	GH1011_TAB1
        string ZT { get; set; } //1	0门诊1住院	GH1011_TAB1
        string ZYH { get; set; } //10	状态为1时有效	GH1011_TAB1
        string SFYSQ { get; set; } //1	是否预授权(Y/N)	GH1011_TAB1
        string YSQYE { get; set; } //16	预授权余额,SFYSQ=Y时有效	GH1011_TAB1
        string JSXM { get; set; } //10	家属姓名	GH1011_TAB1
        string JSSFZ { get; set; } //18	家属身份证	GH1011_TAB1
        string RYLB { get; set; } //10	人员类别	GH1011_TAB1
        string RYZLB { get; set; } //10	人员子类别	GH1011_TAB1
        string TSJSBS { get; set; } //10	特殊结算标识	GH1011_TAB1
        string FPYBXX { get; set; } //--	医保信息,见子数据包 FPYBJSXX	FPYBJSXX
    }
}
