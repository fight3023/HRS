using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    /// <summary>
    /// 预约号源信息
    /// </summary>
    public class ValidPool
    {
        /// <summary>
        /// 排队号码
        /// </summary>
        public string pdhm;
        /// <summary>
        /// 医生代码 北仑：无
        /// </summary>
        public string ysdm;
        /// <summary>
        /// 就诊日期，YYYY-MM-DD 北仑：无
        /// </summary>
        public string jzrq;
        /// <summary>
        /// 上下午，1:上午;2:下午 北仑：无
        /// </summary>
        public int sxw;
        /// <summary>
        /// 开始时间 HH:MM:SS 北仑：HH:MM
        /// </summary>
        public string kssj;
        /// <summary>
        /// 结束时间 HH:MM:SS 北仑：无
        /// </summary>
        public string jssj;
        /// <summary>
        /// 号源状态 0:未使用; 1:锁定; 2:已经取号
        /// </summary>
        public int hyzt;
        /// <summary>
        /// 预约类型  1:共享类型; 2:电话预约; 3:现场预约; 4:省平台预约; 北仑：无
        /// </summary>
        public int yylx;

    }
}
