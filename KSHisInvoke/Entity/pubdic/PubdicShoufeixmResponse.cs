using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 收费项目响应参数
    /// </summary>
    class PubdicShoufeixmResponse : CommonResponse
    {
        string SHOUFEIXMID { get; set; }//	收费项目ID	String(36)		不可空	100211
        string SHOUFEIXMMC { get; set; }//	收费项目名称	String (120)		不可空	
        string XIANGMULX { get; set; }//	项目类型	String (4)	1-9代表药品类费用	不可空	
        string XIANGMULXMC { get; set; }//	项目类型名称	String (100)		不可空	
        string TAOCANBZ { get; set; }//	套餐标志	NUMBER(1)		不可空	
        string JIJIADW { get; set; }//	计价单位	String (20)		可空	
        string DANJIA1 { get; set; }//	单价1	NUMBER(18,4)		不可空	
        string BIAOZHUNBM { get; set; }//	标准编码	String (20)		可空	
        string SHURUMA1 { get; set; }//	输入码1	String (10)		可空	
        string SHURUMA2 { get; set; }//	输入码2	String (10)		可空	
        string SHURUMA3 { get; set; }//	输入码3	String (10)		可空	
        string ZUOFEIBZ { get; set; }//	作废标志	NUMBER(1)		不可空	
        string XIUGAIREN { get; set; }//	修改人	String (36)		不可空	
        string XIUGAISJ { get; set; }//修改时间	DATE		不可空	
    }
}
