using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.guahao
{
    /// <summary>
    /// 病人ID信息响应参数
    /// </summary>
    class GuahaoBingrenResponse : CommonResponse
    {
        string BINGRENIDMZ{ get; set; }//	门诊病人ID	String (20)		可空	0000064980
        string BINGRENIDZY { get; set; }//	住院病人ID	String (20)		可空	0000064980
    }
}
