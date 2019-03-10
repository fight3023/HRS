using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.dangan
{
    /// <summary>
    /// 病人建档响应参数
    /// </summary>
    class DanganJiandangResponse : CommonResponse
    {
        string SHENFENZH{ get; set; }//	身份证号码	String (20)		不可空	330238199001252321
    }
}
