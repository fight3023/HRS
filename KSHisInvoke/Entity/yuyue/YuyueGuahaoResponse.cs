using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.yuyue
{
    /// <summary>
    /// 预约挂号响应参数
    /// </summary>
    class YuyueGuahaoResponse : CommonResponse
    {
        string YUYUEHAO { get; set; }//	预约号	String(20)		不可空	20332001021
    }
}
