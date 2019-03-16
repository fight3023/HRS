using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.6.	(GH1004)(100004)取挂号科室号子信息
    /// </summary>
    public class GH1004 : BASE_I
    {
        public string GHKSDM { get; set; }//		3	挂号科室代码	INPARA
        public string ZGGH { get; set; }//		5	如果如果获取科室有指定医生需要传医生工号	INPARA
    }
}
