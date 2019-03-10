using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Constrants
{
    public class InterfaceConstrant
    {
        //----------------------------公共信息----------------------------//
        /// <summary>
        /// 科室信息
        /// </summary>
        public static string PUBDIC_KESHI = "1101";
        /// <summary>
        /// 职工信息
        /// </summary>
        public static string PUBDIC_ZHIGONG = "1102";
        /// <summary>
        /// 收费项目
        /// </summary>
        public static string PUBDIC_SHOUFEIXM = "1103";
        /// <summary>
        /// 药品信息
        /// </summary>
        public static string PUBDIC_YAOPIN = "1104";
        /// <summary>
        /// 证件类型
        /// </summary>
        public static string PUBDIC_ZHENGJIANLX = "1105";

        //----------------------------档案信息----------------------------//
        /// <summary>
        /// 病人主索引
        /// </summary>
        public static string DANGAN_BINGREN = "1201";
        /// <summary>
        /// 病人建档
        /// </summary>
        public static string DANGAN_JIANDANG = "1211";
        /// <summary>
        /// 档案修改
        /// </summary>
        public static string DANGAN_XIUGAI = "1212";

        //----------------------------当日挂号----------------------------//
        /// <summary>
        /// 当日排班
        /// </summary>
        public static string GUAHAO_PAIBAN = "1301";
        /// <summary>
        /// 挂号收费
        /// </summary>
        public static string GUAHAO_SHOUFEI = "1311";
        /// <summary>
        /// 取消挂号
        /// </summary>
        public static string GUAHAO_QUXIAO = "1312";
        /// <summary>
        /// 病人ID信息(新追加是否使用待定)
        /// </summary>
        public static string GUAHAO_BINGREN = "1302";

        //----------------------------预约挂号----------------------------//
        /// <summary>
        /// 预约排班
        /// </summary>
        public static string YUYUE_PAIBAN = "1401";
        /// <summary>
        /// 预约挂号
        /// </summary>
        public static string YUYUE_GUAHAO = "1411";
        /// <summary>
        /// 取消预约
        /// </summary>
        public static string YUYUE_QUXIAO = "1412";
        /// <summary>
        /// 候诊时间
        /// </summary>
        public static string YUYUE_HOUZHENSJ = "1413";
        /// <summary>
        /// 预约取号
        /// </summary>
        public static string YUYUE_QUHAO = "1414";

        //----------------------------收费接口----------------------------//
        /// <summary>
        /// 处方信息
        /// </summary>
        public static string SHOUFEI_CHUFANG = "1501";
        /// <summary>
        /// 医技信息
        /// </summary>
        public static string SHOUFEI_YIJI = "1502";
        /// <summary>
        /// 收费结算
        /// </summary>
        public static string SHOUFEI_JIESUAN = "1511";
        /// <summary>
        /// 缴费可行性
        /// </summary>
        public static string SHOUFEI_KEXING = "1512";
        /// <summary>
        /// 门诊预结算
        /// </summary>
        public static string SHOUFEI_YUJIESUAN = "1503";

        //----------------------------查询接口----------------------------//
        /// <summary>
        /// 病人缴费
        /// </summary>
        public static string CHAXUN_JIAOFEI = "1601";
        /// <summary>
        /// 门诊缴费明细
        /// </summary>
        public static string CHAXUN_MENZHENMX = "1602";
        /// <summary>
        /// 住院消费明细
        /// </summary>
        public static string CHAXUN_ZHUYUANMX = "1603";
        /// <summary>
        /// 药品价格查询
        /// </summary>
        public static string CHAXUN_YAOPINJG = "1604";
        /// <summary>
        /// 诊疗价格查询
        /// </summary>
        public static string CHAXUN_ZHENLIAOJG = "1605";
        /// <summary>
        /// 预约信息查询
        /// </summary>
        public static string CHAXUN_YUYUE = "1606";

        //----------------------------预授权接口----------------------------//
        /// <summary>
        /// 预授权
        /// </summary>
        public static string YUSHOUQUAN = "1711";
        /// <summary>
        /// 查询预授权
        /// </summary>
        public static string YUSHOUQUAN_CHAXUN = "1701";
        /// <summary>
        /// 追加预授权金额
        /// </summary>
        public static string YUSHOUQUAN_ZHUIJIA = "1713";

        //----------------------------医保接口----------------------------//
        /// <summary>
        /// 医保读卡
        /// </summary>
        public static string YIBAO_DUKA = "2101";
        /// <summary>
        /// 门诊医保预结算
        /// </summary>
        public static string YIBAO_YUJIESUAN = "2102";
        /// <summary>
        /// 门诊医保结算
        /// </summary>
        public static string YIBAO_JIESUAN = "2103";
        /// <summary>
        /// 医保交易确认
        /// </summary>
        public static string YIBAO_JIAOYIQR = "2105";

        //----------------------------住院病人接口----------------------------//
        /// <summary>
        /// 住院病人总费用查询
        /// </summary>
        public static string ZHUYUAN_FEIYONGCX = "1801";
        /// <summary>
        /// 补交预交款
        /// </summary>
        public static string ZHUYUAN_BUJIAO = "1811";
    }
}
