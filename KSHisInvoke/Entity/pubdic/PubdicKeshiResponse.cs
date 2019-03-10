using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 科室响应参数
    /// </summary>
    class PubdicKeshiResponse : CommonResponse
    {
        string KESHIID { get; set; }//	科室ID	String (10)		不可空	2526
        string KESHIMC { get; set; }//	科室名称	String (100)		不可空	耳鼻喉科
        string KESHIBM { get; set; }//	科室别名	String (100)		可空	
        string WEIZHISM { get; set; }//	位置说明	String (100)		可空	
        string SHURUMA1 { get; set; }//	输入码1	String (10)		不可空	ebh
        string SHURUMA2 { get; set; }//	输入码2	String (10)		可空	
        string SHURUMA3 { get; set; }//	输入码3	String (10)		可空	
        string XIUGAIREN { get; set; }//	修改人	String (10)		可空	
        string XIUGAISJ { get; set; }//	修改时间	Date		可空	
        string KESHIZL { get; set; }//	科室资料	String(500)		可空	
    }
}
