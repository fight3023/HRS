using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.4.	(GH1002)(100002)取挂号科室
    /// </summary>
    public class GH1002 : BASE_I
    {
        /// <summary>
        /// 6	查询代码 ALL= 全部科室	ZDH=本终端使用的科室	ZTDM=诊台的科室	GHKS =指定科室代码	KSLB =科室门诊类型	ZDHKSLB=终端号与科室类别	KSFL=科室分类		INPARA
        /// </summary>
        public string CXFS { get; set; }//		
        /// <summary>
        /// 10	查询方式= ALL 时本参数可以为空 查询方式= ZDH时本参数为本机终端号	查询方式= ZTDM时本参数为诊台代码	查询方式= GHKS时本参数为挂号科室代码	查询方式= KSLB时本参数为挂号科室门诊类型	 对应MZGHLXB.BH	查询方式=ZDHKSLB时本参数为终端号号与科室类别	 如 12345,1 (终端号,科室类别)	查询方式= KSFL时本参数为挂号科室分类		INPARA
        /// </summary>
        public string CXDM { get; set; }//	
	    /// <summary>
        /// 1	挂号标志0/1，1返回有效的挂号科室，例如去掉停诊的，限号已满的	
	    /// </summary>
        public string GHBZ { get; set; }//		
        /// <summary>
        /// 2	排班时间限制=Y限制排班时间	排班时间限制=N或空不限制排班时间	
        /// </summary>
        public string PBSJXZ { get; set; }//		
    }
}
