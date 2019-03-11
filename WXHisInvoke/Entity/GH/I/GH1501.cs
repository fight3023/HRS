using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.15.	(GH1501)(100501)获取科室介绍信息
    /// </summary>
    class GH1501 : BASE_I
    {
        string CXFS { get; set; }//		6	查询代码	INPARA ALL= 全部科室	ZDH=本终端使用的科室	ZTDM=诊台的科室	GHKS =指定科室代码	KSLB =科室门诊类型	
        string CXDM { get; set; }//		10	查询方式= ALL 时本参数可以为空 查询方式= ZDH时本参数为本机终端号 查询方式= ZTDM时本参数为诊台代码 查询方式= GHKS时本参数为挂号科室代码 查询方式= KSLB时本参数为挂号科室门诊类型	对应MZGHLXB.BH		INPARA
    }
}
