using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 职工响应参数
    /// </summary>
    class PubdicZhigongResponse : CommonResponse
    {
        string ZHIGONGID { get; set; }//职工ID	String(10)		不可空	1968
        string ZHIGONGGH { get; set; }//	职工工号	String(10)		不可空	300
        string ZHIGONGXM { get; set; }//	职工姓名	String(20)		不可空	张三
        string XINGBIE { get; set; }//	性别	String(4)		不可空	男
        string SHURUMA1 { get; set; }//	输入码1	String(10)		不可空	zs
        string SHURUMA2 { get; set; }//	输入码2	String(10)		可空	
        string SHURUMA3 { get; set; }//	输入码3	String(10)		可空	
    }
}
