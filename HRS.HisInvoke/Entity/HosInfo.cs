using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    /// <summary>
    /// 医院查询结果 北仑
    /// </summary>
    public class HosInfo
    {
        /// <summary>
        /// 医院编号
        /// </summary>
        public string hid;
        /// <summary>
        /// 医院名称
        /// </summary>
        public string hname;
        /// <summary>
        /// 医院地址
        /// </summary>
        public string address;
        /// <summary>
        /// 医院照片（图片提供URL方式调用，中心）
        /// </summary>
        public string picture;
        /// <summary>
        /// 挂号服务状态，Y=正常，N=维护中
        /// </summary>
        public string status;
        /// <summary>
        /// 医院ID
        /// </summary>
        public string oid;
    }
}
