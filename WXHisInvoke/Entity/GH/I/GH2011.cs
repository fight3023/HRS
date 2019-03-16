using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.3.	(GH2011)(200103)门诊病人信息录入
    /// </summary>
    public class GH2011 : BASE_I
    {
        public string JZKH { get; set; }//		30	就诊卡号 (必填)	INPARA
        public string BRXM { get; set; }//		20	病人姓名 (必填)	INPARA
        public string BRXB { get; set; }//		10	病人性别(F/M/N 女/男/其他) (必填)	INPARA
        public string CSRQ { get; set; }//		10	病人出生日期格式 YYYY-MM-DD  (必填)	INPARA
        public string FBLX { get; set; }//		2	费别类型	INPARA
        public string HYZK { get; set; }//		1	婚姻婚否：1.未 2.已 3.离 4.丧	INPARA
        public string GMFY { get; set; }//		32	过敏反应	INPARA
        public string YHLX { get; set; }//		1	优惠类型	INPARA
        public string YHHM { get; set; }//		10	优惠号码	INPARA
        public string BRXX { get; set; }//		5	病人血型	INPARA
        public string BRDZ { get; set; }//		128	联系地址	INPARA
        public string TELE { get; set; }//		20	联系电话	INPARA
        public string SFZH { get; set; }//		18	身份证号	INPARA
        public string GZDW { get; set; }//		100	工作单位	INPARA
        public string DWDZ { get; set; }//		100	单位地址	INPARA
        public string DWDH { get; set; }//		20	单位电话	INPARA
        public string BRZY { get; set; }//		10	病人职业	INPARA
        public string JSXM { get; set; }//		10	家属姓名	INPARA
        public string JSGX { get; set; }//		4	家属关系	INPARA
        public string JSSFZ { get; set; }//		18	家属身份证	INPARA
        public string JSDZ { get; set; }//		60	家属地址	INPARA
        public string CLBZ { get; set; }//		1	处理标志 0：只更新 1：新增、更新 3：特殊更新 4：网诊 5：只新增不更新		INPARA
        public string ZFFS { get; set; }//		1	支付方式 见值域说明 支付方式(ZFFS)	INPARA
        public string ZFJG { get; set; }//		--	支付结果 根据不同的支付方式,传入不同结果数据包,支付方式为挂帐时,该值可以为空见值域说明 支付方式(ZFFS)		YYZFJG 

    }
}
