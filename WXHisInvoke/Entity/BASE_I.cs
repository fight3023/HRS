using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity
{
    class BASE_I
    {
        /// <summary>
        /// 10	交易代码, 参数值固定为本交易代码编号	HEADER
        /// </summary>
        string TRANS_NO { get; set; }
        /// <summary>
        /// 5	交易终端号	HEADER
        /// </summary>
        string ZDH { get; set; }
        /// <summary>
        /// 2	分院编号(可为空，当分院交易时才指定)	HEADER
        /// </summary>
        string FYBH { get; set; }
        /// <summary>
        /// 20	医院代码(可为空)	HEADER
        /// </summary>
        string ORG_CODE { get; set; }
        /// <summary>
        /// 20	验证密码(可为空)	HEADER
        /// </summary>
        string PASSWORD { get; set; }
    }
}
