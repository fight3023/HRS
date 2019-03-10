using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 证件类型响应参数
    /// </summary>
    class PubdicZhengjianlxResponse : CommonResponse
    {
        string ZHENGJIANLXID { get; set; }//	证件类型ID	String (36)
        string ZHENGJIANLXZHI { get; set; }//	证件类型类型值	
    }
}
