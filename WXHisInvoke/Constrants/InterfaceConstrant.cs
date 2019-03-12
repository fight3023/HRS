using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Constrants
{
    class InterfaceConstrant
    {
        //--------------------------公共交易---------------------
        /// <summary>
        /// 取系统参数
        /// </summary>
        public static string GY_XTCS = "GY0003";
        /// <summary>
        /// 取IC卡读卡类型
        /// </summary>
        public static string GY_ICCARD = "GY1021";
        /// <summary>
        /// 取多媒体功能划分
        /// </summary>
        public static string GY_MEDIA = "GY1022";
        /// <summary>
        /// 取数据字典
        /// </summary>
        public static string GY_DIC = "GY1023";
        /// <summary>
        /// 取终端信息
        /// </summary>
        public static string GY_ZDXX = "GY1001";
        /// <summary>
        /// 取终端参数
        /// </summary>
        public static string GY_ZDCS = "GY1002";
        /// <summary>
        /// 终端登录
        /// </summary>
        public static string GY_ZDDL = "GY2001";
        /// <summary>
        /// 终端退出
        /// </summary>
        public static string GY_ZDTC = "GY2002";
        /// <summary>
        /// 获取HIS系统时间
        /// </summary>
        public static string GY_HISSJ = "GY3001";
        /// <summary>
        /// 获取HIS门诊系统日期
        /// </summary>
        public static string GY_HISRQ = "GY3002";
        /// <summary>
        /// 获取挂号科室简介
        /// </summary>
        public static string GY_GHKSJJ = "GY3005";
        /// <summary>
        /// 获取挂号医生简介
        /// </summary>
        public static string GY_GHYSJJ = "GY3007";
        /// <summary>
        /// 获取挂号医生信息
        /// </summary>
        public static string GY_GHYS = "GY3008";
        /// <summary>
        /// 取药品价格信息
        /// </summary>
        public static string GY_YPJG = "GY3009";
        /// <summary>
        /// 取费用价格信息
        /// </summary>
        public static string GY_FYJG = "GY3010";
        /// <summary>
        /// 签约信息控制
        /// </summary>
        public static string GY_QYKZ = "GY3011";
        /// <summary>
        /// 取门诊挂号、就诊时间
        /// </summary>
        public static string GY_MZGHSJ = "GY1024";
        /// <summary>
        /// 取自助可补收费用目录
        /// </summary>
        public static string GY_ZZKBSF = "GY3012";
        /// <summary>
        /// 获取电子病历信息
        /// </summary>
        public static string GY_DZBL = "GY3013";
        /// <summary>
        /// 获取检验条码号
        /// </summary>
        public static string GY_JYTM = "GY3014";
        /// <summary>
        /// 检验申请信息
        /// </summary>
        public static string GY_JYSQ = "GY3030";
        /// <summary>
        /// 检验结果信息
        /// </summary>
        public static string GY_JYJG = "GY3031";
        /// <summary>
        /// 检查申请信息
        /// </summary>
        public static string GY_JCSQ = "GY3032";
        /// <summary>
        /// 病人信息获取
        /// </summary>
        public static string GY_BRXX = "GY8001";


        //---------------------挂号--------------
        /// <summary>
        /// 自助挂号重置
        /// </summary>
        public static string GH_GHCZ = "GH1001";
        /// <summary>
        /// 取门诊病人信息
        /// </summary>
        public static string GH_MZBR = "GH1011";
        /// <summary>
        /// 门诊病人信息录入
        /// </summary>
        public static string GH_BRLR = "GH2011";
        /// <summary>
        /// 取挂号科室
        /// </summary>
        public static string GH_GHKS = "GH1002";
        /// <summary>
        /// 取挂号医生信息
        /// </summary>
        public static string GH_GHYSXX = "GH1003";
        /// <summary>
        /// 取挂号科室号子信息
        /// </summary>
        public static string GH_GYKSHZ = "GH1004";
        /// <summary>
        /// 取医保特病
        /// </summary>
        public static string GH_YBTB = "GH1013";
        /// <summary>
        /// 取病人信息（多行）
        /// </summary>
        public static string GH_BRXXDH = "GH1014";
        /// <summary>
        /// 挂号凭证补打
        /// </summary>
        public static string GH_GHBZBD = "GH1007";
        /// <summary>
        /// 挂号预算
        /// </summary>
        public static string GH_GHYS = "GH2104";
        /// <summary>
        /// 挂号处理
        /// </summary>
        public static string GH_GHCL = "GH2101";
        /// <summary>
        /// 退号处理
        /// </summary>
        public static string GH_THCL = "GH2102";
        /// <summary>
        /// 请假单打印
        /// </summary>
        public static string GH_QJDDY = "GH2103";
        /// <summary>
        /// 挂号查询
        /// </summary>
        public static string GH_GHCX = "GH1102";
        /// <summary>
        /// 获取科室介绍信息
        /// </summary>
        public static string GH_KEJS = "GH1501";
        /// <summary>
        /// 获取医生介绍信息
        /// </summary>
        public static string GH_YSJS = "GH1601";
        /// <summary>
        /// 获取挂号打印信息
        /// </summary>
        public static string GH_GHDY = "GH2501";
        /// <summary>
        /// 挂号状态查询处理
        /// </summary>
        public static string GH_GHZT = "GH1103";
        /// <summary>
        /// 挂号就诊开单查询
        /// </summary>
        public static string GH_JZKD = "GH2001";
        /// <summary>
        /// 预算支付预存
        /// </summary>
        public static string GH_YSZF = "GH3001";
        /// <summary>
        /// 挂号类别获取
        /// </summary>
        public static string GH_GHLB = "GH1302";
        /// <summary>
        /// 网上预约信息获取
        /// </summary>
        public static string GH_YYXX = "GH2201";
        /// <summary>
        /// 取历史挂号信息
        /// </summary>
        public static string GH_LSGH = "GH5001";
        /// <summary>
        /// 取请假条信息
        /// </summary>
        public static string GH_QJT = "GH5002";
        /// <summary>
        /// 读社保卡
        /// </summary>
        public static string GH_SBK = "GH1012";

        //----------------网上挂号---------------
        /// <summary>
        /// 科室与医生排班查询
        /// </summary>
        public static string WG_KSPB = "WG2001";
        /// <summary>
        /// 网上挂号科室排班查询
        /// </summary>
        public static string WG_WSKEPB = "WG2003";
        /// <summary>
        /// 可用预约号获取(废弃)
        /// </summary>
        public static string WG_KYYYH = "WG2011";
        /// <summary>
        /// 预约处理
        /// </summary>
        public static string WG_YYCL = "WG2002";
        /// <summary>
        /// 预约成功确认
        /// </summary>
        public static string WG_YYCG = "WG2008";
        /// <summary>
        /// 预约日期查询
        /// </summary>
        public static string WG_YYRQ = "WG2012";
        /// <summary>
        /// 预约查询
        /// </summary>
        public static string WG_YYCX = "WG2013";
        /// <summary>
        /// (WG2009)预约撤销处理（旧）
        /// </summary>
        public static string WG_YYCXJ = "WG2010";
        /// <summary>
        /// 预约撤销处理（新）
        /// </summary>
        public static string WG_YYCXCL = "WG2019";
        /// <summary>
        /// 停诊科室查询
        /// </summary>
        public static string WG_TZKS = "WG2014";
        /// <summary>
        /// 科室未取单预约号查询
        /// </summary>
        public static string WG_KSWQD = "WG2015";
        /// <summary>
        /// 停诊科室未取单预约号查询
        /// </summary>
        public static string WG_ZDDL = "WG2016";
        /// <summary>
        /// 网上挂号未签到确认挂号信息查询
        /// </summary>
        public static string WG_WQD = "WG2017";
        /// <summary>
        /// 网上挂号排班时间段查询
        /// </summary>
        public static string WG_PBSJ = "WG2018";
        /// <summary>
        /// 预约取号确认请求
        /// </summary>
        public static string WG_QHQR = "WG2020";
    }
}
