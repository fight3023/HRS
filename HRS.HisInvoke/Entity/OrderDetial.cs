using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    /// <summary>
    /// 预约详情
    /// </summary>
    public class OrderDetial
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
        /// 就诊日期，YYYY-MM-DD
        /// </summary>
        public string jzrq;
        /// <summary>
        /// 上下午，1:上午;2:下午
        /// </summary>
        public int sxw;//	
        /// <summary>
        /// 病人排队号码
        /// </summary>
        public string pdhm;
        /// <summary>
        /// 预约序号(内部码)    
        /// </summary>
        public string yyxh;
        /// <summary>
        /// 科室代码
        /// </summary>
        public string ksdm;
        /// <summary>
        /// 科室名称
        /// </summary>
        public string ksmc;
        /// <summary>
        /// 黑名单， 预约迟到的病人值为 1
        /// </summary>
        public int hmd;//	
        /// <summary>
        /// 数据状态  -1:未取号;2 已取号
        /// </summary>
        public int sjzt;
    }
}
