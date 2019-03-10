using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 证件类型请求参数
    /// </summary>
    class PubdicZhengjianlxRequest
    {
        string ZHENGJIANLXMC { get; set; }//	证件类型名称	String(50)	支持模糊查询	可空	身份证
    }
}
