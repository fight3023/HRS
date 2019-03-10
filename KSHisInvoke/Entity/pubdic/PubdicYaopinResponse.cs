using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.pubdic
{
    /// <summary>
    /// 药品响应参数
    /// </summary>
    class PubdicYaopinResponse : CommonResponse
    {
        string JIAGEID { get; set; }//		价格ID	String(36)		不可空	4609
        string GUIGEID { get; set; }//		规格ID	String (50)		不可空	
        string BIANMAID { get; set; }//		药品编码	String (12)			
        string YAOPINSPMC { get; set; }//		药品商品名	String (120)			
        string YAOPINTYMC { get; set; }//		药品通用名	String (120)			
        string ZHANGBULB { get; set; }//		帐簿类别	String (6)		不可空	
        string SHOUFEIXM { get; set; }//		收费项目	String (36)		可空	
        string YAOPINMC { get; set; }//		药品名称	String (120)		不可空	
        string CHANDI { get; set; }//		产地	String (36)		不可空	
        string CHANDIMC { get; set; }//		产地名称	String (150)		不可空	
        string JIXING { get; set; }//		剂型	String (36)		可空	
        string YAOPINLX { get; set; }//		药品类型	String (4)	1.西药,2.成药,3.草药	不可空	
        string DANJIA1 { get; set; }//		单价1	NUMBER(18,4)		不可空	
        string TINGYONGBZ { get; set; }//		停用标志	NUMBER(1)	0.正常,1.停用	不可空	
        string SHURUMA1 { get; set; }//		输入码1	String (10)		可空	
        string SHURUMA2 { get; set; }//		输入码2	String (10)		可空	
        string SHURUMA3 { get; set; }//		输入码3	String (10)		可空	
        string XIUGAIREN { get; set; }//		修改人	String (10)		可空	
        string XIUGAISJ { get; set; }//		修改时间	DATE		可空	
        string YAOPINGG { get; set; }//		药品规格	String (50)		不可空	
        string BAOZHUANGDW { get; set; }//		包装单位	String (20)		不可空	
        string BAOZHUANGLIANG { get; set; }//		包装量	NUMBER(18,4)		不可空	
        string PISHIBZ { get; set; }//		皮试标志	String (4)	0.普通药品,1.皮试药品	不可空	
        string YAOPINID { get; set; }//		药品ID	String (36)		可空	
    }
}
