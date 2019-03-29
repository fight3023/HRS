using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    /// <summary>
    /// 科室可用排班信息
    /// </summary>
    public class ValidSche
    {
        /// <summary>
        /// 科室代码
        /// </summary>
        public string ksdm;
        /// <summary>
        /// 科室名称
        /// </summary>
        public string ksmc;
        /// <summary>
        /// 医生列表
        /// </summary>
        public List<ScheInfo> ys;
    }
}
