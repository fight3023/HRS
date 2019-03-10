using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.shoufei
{
    class ShoufeiJiesuanResponse
    {
        string SHIFUJE { get; set; }//	实付金额	Number(18,4)	用于验证交易金额两边是否一致	不可空	289.5
        string TIAOXINGM { get; set; }//	条形码	VARCHAR2(20)		不可空	
        string QUYAOCK { get; set; }//	取药窗口	VARCHAR2(200)			
    }
}
