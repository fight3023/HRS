using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// (GH1003)(100003)取挂号医生信息
    /// </summary>
    public class GH1003 : BASE_I
    {
        public string CXFS { get; set; }//		4	查询方式 ALL= 全部医生,GHKS=挂号科室查医生{get;set;}//			ZGID = 职工工号		INPARA
        public string CXDM { get; set; }//		10	查询方式= ALL 时本参数可以为空 查询方式= GHKS时本参数为挂号科室代码	查询方式= ZGID时本参数为职工工号		INPARA 
        public string GHBZ { get; set; }//		1	挂号标志0/1，1返回有效的挂号科室，例如去掉停诊的，限号已满的	
    }
}
