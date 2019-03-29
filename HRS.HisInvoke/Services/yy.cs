using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS.Interface.Entity;

namespace HRS.Interface.Services
{
    public interface yy
    {

        /// <summary>
        /// 获取所有可预约科室列表及医生排班信息 温岭:YY01   建德:GUAHAOKSXX
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="ksdm">科室代码</param>
        /// <param name="zjmz">专家门诊* 0:普通  1:专家</param>
        /// <param name="ysdm">医生代码 为空，则查询所有，否则查询对应医生的排班情况</param>
        /// <param name="gzrq">工作日期  YYYY-MM-DD 就诊日期为NULL，则查询最近7天该科室医生排班列表</param>
        /// <param name="sxw">上下午 -1:所有    1:上午   2:下午</param>
        /// <returns>resultList为ValidSche数组</returns>
        ResultPojo yyValidSche(string zdbh, string jydm, string ksdm, int zjmz, string ysdm, string gzrq, int sxw);

        /// <summary>
        /// 获取所有可预约科室列表及医生排班信息 北仑  SG0003  SG0005
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="ksdm">科室代码</param>
        /// <param name="zjmz">专家门诊* 0:普通  1:专家</param>
        /// <param name="ysdm">医生代码 为空，则查询所有，否则查询对应医生的排班情况</param>
        /// <param name="gzrq">工作日期  YYYY-MM-DD 就诊日期为NULL，则查询最近7天该科室医生排班列表</param>
        /// <param name="sxw">上下午 -1:所有    1:上午   2:下午</param>
        /// <param name="hid">医院代码*</param>
        /// <returns>resultList为ValidSche数组</returns>
        ResultPojo yyValidScheHos(string zdbh, string jydm, string ksdm, int zjmz, string ysdm, string gzrq, string sxw, string hid);

        /// <summary>
        /// 查询号源  温岭：YY02  建德：GUAHAOHYXX  北仑：SG0021
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="ksdm">科室代码*</param>
        /// <param name="ysdm">医生代码*</param>
        /// <param name="gzrq">工作日期* YYYY-MM-DD</param>
        /// <param name="sxw">上下午* 1:上午   2:下午</param>
        /// <param name="pbsb">排班识别*</param>
        /// <param name="cxfs">查询方式* 0:全部  1:未取走号源</param>
        /// <returns>resultList为ValidPool数组</returns>
        ResultPojo yyValidPool(string zdbh, string jydm, string ksdm, string ysdm, string gzrq, int sxw, string pbsb, int cxfs);

        /// <summary>
        /// 预约处理 温岭：YY03  建德：GUAHAOYY
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="brid">病人 ID*</param>
        /// <param name="ksdm">挂号科室代码*</param>
        /// <param name="ysdm">医生代码*</param>
        /// <param name="jzrq">就诊日期* YYYY-MM-DD</param>
        /// <param name="sxw">上下午*	1:上午  2:下午</param>
        /// <param name="pdhm">排队号码*</param>
        /// <param name="pbsb">排班识别*</param>
        /// <returns>resultList为OrderInfo对象</returns>
        ResultPojo yyOrder(string zdbh, string jydm, string brid, string ksdm, string ysdm, string jzrq, int sxw, string pdhm, string pbsb);

        /// <summary>
        /// 预约处理。 北仑
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="brxm">病人姓名*</param>
        /// <param name="sfzh">身份证号*</param>
        /// <param name="ksdm">挂号科室代码*</param>
        /// <param name="ysdm">医生代码*</param>
        /// <param name="jzrq">就诊日期*	YYYY-MM-DD</param>
        /// <param name="kssj">开始时间*	HH:MM   号子的开始时间</param>
        /// <param name="pdhm">排队号码*</param>
        /// <param name="pbsb">排班识别*</param>
        /// <param name="zffs">支付方式	0：短信支付</param>
        /// <returns>resultList为OrderInfo对象</returns>
        ResultPojo yyOrderZf(string zdbh, string jydm, string brxm, string sfzh, string ksdm, string ysdm, string jzrq, string kssj, string pdhm, string pbsb, int zffs);

        /// <summary>
        /// 预约查询。 温岭YY04  建德：GUAHAOXXCX
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码</param>
        /// <param name="brid">病人 ID*</param>
        /// <param name="jzrq">就诊日期*	固定为：当日</param>
        /// <returns>resultList为OrderDetial数组</returns>
        ResultPojo yyOrderQuery(string zdbh, string jydm, string brid, string jzrq);

        /// <summary>
        /// 预约查询。 北仑
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码</param>
        /// <param name="brxm">病人姓名*</param>
        /// <param name="sfzh">身份证号*</param>
        /// <param name="pbsb">排班识别	空时为全部</param>
        /// <param name="pdhm">排队号码	空时为全部</param>
        /// <param name="status">预约状态	空时为全部 1：全部记录 2：未支付 3：预约失败 4：已退号 5：预约成功</param>
        /// <param name="begrq">开始日期	YYYY-MM-DD	查询时间范围，可为空（查询当天及之后的预约），查询指定日期则begrq,endrq都设该日期</param>
        /// <param name="endrq">结束日期 YYYY-MM-DD</param>
        /// <returns>resultList为OrderDetialBr数组</returns>
        ResultPojo yyOrderQueryRq(string zdbh, string jydm, string brxm, string sfzh, string pbsb, string pdhm, string status, string begrq, string endrq);

        /// <summary>
        /// 预约取号。  温岭YY05   建德GUAHAOYYQH
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码</param>
        /// <param name="brid">病人 ID*</param>
        /// <param name="yyxh">预约序号*	预约取号需要传入   </param>
        /// <param name="ysdm">医生代码 </param>
        /// <param name="ksdm">科室代码</param>
        /// <returns>resultList为OrderDetial对象</returns>
        ResultPojo yyOrderTake(string zdbh, string jydm, string brid, string yyxh, string ysdm, string ksdm);

        /// <summary>
        /// 预约取消。  温岭YY07  建德：GUAHAOYYTH
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="yyxh">预约序号*</param>
        /// <returns>resultList为空</returns>
        ResultPojo yyOrderCancel(string zdbh, string jydm, string yyxh);

        /// <summary>
        /// 预约取消。  北仑
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="brxm">病人姓名*</param>
        /// <param name="sfzh">身份证号*</param>
        /// <param name="jzrq">就诊时间*	YYYY-MM-DD</param>
        /// <param name="yyxh">预约序号*</param>
        /// <returns>resultList为空</returns>
        ResultPojo yyOrderCancelBr(string zdbh, string jydm, string brxm, string sfzh, string jzrq, string yyxh);

        /// <summary>
        /// 获取当前所有可挂号科室列表， 温岭MZ13  建德GUAHAOYSXX
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="zjmz">专家门诊*	0:普通  1:专家</param>
        /// <returns>resultList为ValidSche数组</returns>
        ResultPojo mzValidSche(string zdbh, string jydm, int zjmz);

        /// <summary>
        /// 挂号处理。 建德：GUAHAOYY
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="brid">病人 ID*</param>
        /// <param name="ksdm">挂号科室代码*</param>
        /// <param name="ysdm">医生代码*</param>
        /// <param name="ybkmm">医保卡密码	为空，除部分杭州市医保卡设有密码</param>
        /// <param name="ybkxx">医保卡信息	通过社保提供的 DLL 读取的卡内信息</param>
        /// <param name="pbsb">排班识别*</param>
        /// <returns>resultList为GhResult对象</returns>
        ResultPojo mzValid(string zdbh, string jydm, string brid, string ksdm, string ysdm, string ybkmm, string ybkxx, string pbsb);

        /// <summary>
        /// 医院查询。 北仑：SG0001
        /// </summary>
        /// <param name="zdbh">终端编号*</param>
        /// <param name="jydm">校验代码*</param>
        /// <param name="rtype">资源类型	A:所有 Y:所有可预约医院列表（为空时默认选项）D:当天有导诊信息的医院列表</param>
        /// <param name="hname">医院名称	医院模糊查询</param>
        /// <param name="acode">所属区域编号	为空时默认北仑 All:查询所有</param>
        /// <returns>resultList为HosInfo数组</returns>
        ResultPojo yyHos(string zdbh, string jydm, string rtype, string hname, string acode);
    }
}
