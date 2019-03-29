using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    /// <summary>
    /// 医生排班信息
    /// </summary>
    public class ScheInfo
    {
        /// <summary>
        /// 医生代码
        /// </summary>
        public string ysdm;
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string ysxm;
        /// <summary>
        /// 工作日期
        /// </summary>
        public string gzrq;
        /// <summary>
        /// 上下午
        /// </summary>
        public int sxw;
        /// <summary>
        /// 挂号限额
        /// </summary>
        public int ghxe;
        /// <summary>
        /// 已挂人数
        /// </summary>
        public int ygrs;
        /// <summary>
        /// 预约人数
        /// </summary>
        public int yyrs;
        /// <summary>
        /// 挂号代码（预约时无此代码）
        /// </summary>
        public string ghdm;
        /// <summary>
        /// 剩余号源
        /// </summary>
        public int syhy;
        /// <summary>
        /// 挂号费
        /// </summary>
        public float ghf;
        /// <summary>
        /// 排班识别
        /// </summary>
        public string pbsb;
        /// <summary>
        /// 挂号验证标志（Y=需验证码，N=无需验证码）
        /// </summary>
        public string ghyzbz;
    }
}
