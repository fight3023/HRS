using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXHisInvoke.Entity.GH.I
{
    /// <summary>
    /// 3.16.	(GH1601)(100601)获取医生介绍信息
    /// </summary>
    public class GH1601 : BASE_I
    {
        public string CXFS { get; set; }//		4	查询方式 ALL= 全部医生,GHKS=挂号科室查医生	INPARA ZGID = 职工工号, ZDH = 终端号	
        public string CXDM { get; set; }//		10	查询方式= ALL 时本参数可以为空	INPARA 查询方式= GHKS时本参数为挂号科室代码	 查询方式= ZGID时本参数为职工工号	 查询方式= ZDH 时本参数为终端号	
        public string PHOTOPATH { get; set; }//		50	照片存放路径	INPARA
        public string PHOTOSEND { get; set; }//		1	Y需要传照片,N不需要传照片	INPARA
    }
}
