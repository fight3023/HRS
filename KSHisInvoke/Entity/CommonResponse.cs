using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity
{
    /// <summary>
    /// 通用响应信息
    /// </summary>
    class CommonResponse
    {
        int RESPONSECODE { get; set; } //返回值	=0:成功；<>0:失败
        string MESSAGE { get; set; }		//错误返回信息	
    }
}
