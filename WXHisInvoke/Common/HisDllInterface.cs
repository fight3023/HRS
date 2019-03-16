using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WXHisInvoke.Common
{
    public class HisDllInterface
    {
        /// <summary>
        /// 该函数是设置服务的地址与端口,如该函数未调用,而直接调用 KTSendRcv 函数,将从配置文件 KTInterface.Ini文件中读配置来定位服务的地址与端口
        /// </summary>
        /// <param name="serveraddr"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern int KTSet_ServerAddr(string serveraddr, int port);

        /// <summary>
        /// 该函数是向前置服务器发送一个数据请求包，发送交易成功后，前置服务器通讯交易服务客户端程序同时返回相应数据包给工作站
        /// </summary>
        /// <param name="sendbuf">要发送的数据包，字符串型, 长度必须在65535以内</param>
        /// <param name="sendlen">要发送的数据包长度，取sendbuf的长度，长整型</param>
        /// <param name="recvbuf">要接收的数据包，字符串长度必须在65535以内，必须预先分配地址空间</param>
        /// <param name="recvlen">要接收的数据包长度，取recvbuf的长度，长整形</param>
        /// <returns>返回值数据长度：long（长整型）0：成功1：连接前置机服务器失败2：向前置机服务器发送数据失败3：接收返回结果失败</returns>
        [DllImport("kernel32.dll")]
        public static extern int KTSendRcv(string sendbuf, long sendlen, string recvbuf, long recvlen);

        /// <summary>
        /// 结合了前两者的功能,每次交易时都要指定地址,参数含义与前两者一样
        /// </summary>
        /// <param name="serveraddr"></param>
        /// <param name="port"></param>
        /// <param name="sendbuf"></param>
        /// <param name="sendlen"></param>
        /// <param name="recvbuf"></param>
        /// <param name="recvlen"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern int KTTrading(string serveraddr, int port, string sendbuf, long sendlen, string recvbuf, long recvlen);

        /// <summary>
        /// 该函数是初始化指定分院的业务库
        /// </summary>
        /// <param name="branch_code">分院代码</param>
        /// <param name="biztype_list">业务代码，可以有多个,如"业务代码1,业务代码2..."ZZGH=自助挂号 ZZSF=自助收费 WSGH=网上挂号 HYTM=化验条码</param>
        /// <returns>返回值数据长度：long（长整型）1：初始化成功0：初始化失败</returns>
        [DllImport("kernel32.dll")]
        public static extern int KTPBNI_Init(string branch_code, string biztype_list);

        /// <summary>
        /// 该函数是向本地业务库发送一个数据请求包，交易成功后返回相应数据包
        /// </summary>
        /// <param name="sendbuf">要发送的数据包，字符串型, 长度必须在65535以内</param>
        /// <param name="sendlen">要发送的数据包长度，取sendbuf的长度，长整型</param>
        /// <param name="recvbuf">要接收的数据包，字符串长度必须在65535以内，必须预先分配地址空间</param>
        /// <param name="recvlen">要接收的数据包长度，取recvbuf的长度，长整形</param>
        /// <returns>long（长整型）0：业务未初始化1：交易成功其它：交易系统错误</returns>
        [DllImport("kernel32.dll")]
        public static extern int KTPBNI_Trading(string sendbuf, long sendlen, ref string recvbuf, long recvlen);

        /// <summary>
        /// 该函数是释放动态库初始化内容
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern void KTPBNI_Destroy();
    }
}
