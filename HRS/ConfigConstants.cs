using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS
{
    /// <summary>
    /// 配置常量
    /// </summary>
    public class ConfigConstants
    {
        /// <summary>
        /// 终端编号
        /// </summary>
        public static string ZDBH = ConfigurationManager.AppSettings["ZDBH"];
        /// <summary>
        /// 校验代码
        /// </summary>
        public static string JYDM = ConfigurationManager.AppSettings["JYDM"];
        /// <summary>
        /// 接口DLL
        /// </summary>
        public static string INTERFACE_DLL = ConfigurationManager.AppSettings["INTERFACE_DLL"];
    }
}
