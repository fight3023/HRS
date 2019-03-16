using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity
{
    public class BASE_O
    {
        /// <summary>
        /// 4	交易返回值，为0时表示成功，其它表示交易失败。	RESULTS
        /// </summary>
       string RET_CODE	{ get; set; }
        /// <summary>
       /// 100	交易错误内容，当RET_CODE不等于0时返回错误消息内容。	RESULTS
       /// </summary>
       string RET_INFO { get; set; }
    }
}
