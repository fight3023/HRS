using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    /// <summary>
    /// 预约号序号
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// #	排队号码
        /// </summary>
        public string pdhm;
        /// <summary>
        /// #	预约序号  （建德：取号密码）
        /// </summary>
        public string yyxh;
        /// <summary>
        /// 北仑：支付流水号
        /// </summary>
        public string pay_num;
        /// <summary>
        /// 北仑：短信支付时支付的手机号
        /// </summary>
        public string phone;
    }
}
