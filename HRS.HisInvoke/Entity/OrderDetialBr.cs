using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    /// <summary>
    /// 预约详情（北仑）
    /// </summary>
    public class OrderDetialBr
    {
        /// <summary>
        /// 排班识别
        /// </summary>
        public string bpsb;
        /// <summary>
        /// 预约序号
        /// </summary>
        public string yyxh;
        /// <summary>
        /// 预约时段的开始时间HH:mm
        /// </summary>
        public string kssj;
        /// <summary>
        /// 病人排队号码
        /// </summary>
        public string pdhm;
        /// <summary>
        /// 医院代码
        /// </summary>
        public string hid;
        /// <summary>
        /// 医院名称
        /// </summary>
        public string hname;
        /// <summary>
        /// 科室代码
        /// </summary>
        public string ksdm;
        /// <summary>
        /// 科室名称
        /// </summary>
        public string ksmc;
        /// <summary>
        /// 医生代码
        /// </summary>
        public string ysdm;
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string ysxm;
        /// <summary>
        /// 就诊日期，YYYY-MM-DD
        /// </summary>
        public string jzrq;
        /// <summary>
        /// 上下午，1:上午;2:下午
        /// </summary>
        public int sxw;
        /// <summary>
        /// 2：未支付 3：预约失败 4：已退号 5：预约成功
        /// </summary>
        public string status;
        /// <summary>
        /// 挂号费(包括专家费)
        /// </summary>
        public string reg_fee;
        /// <summary>
        /// 诊疗费
        /// </summary>
        public string clinic_fee;
        /// <summary>
        /// 在线扣费（手续费）
        /// </summary>
        public string online_fee;
        /// <summary>
        /// 医生照片
        /// </summary>
        public string doctor_photo;
        /// <summary>
        /// 平台来源分点
        /// </summary>
        public string ptlyfd;
        /// <summary>
        /// 平台来源分点名称。如：北仑自助机d等
        /// </summary>
        public string ptlyfd_name;
        /// <summary>
        /// 就诊状（Y=已就诊，N=未就诊）
        /// </summary>
        public string jz_status;
        /// <summary>
        /// 支付方式（0=未知，1=短信支付，2=网银支付，3=其他；默认=0）
        /// </summary>
        public string zffs;
        /// <summary>
        /// zffs=3时支付渠道，
        /// </summary>
        public string pay_channel;
        /// <summary>
        /// 停诊标志（Y=已停诊，N=未停诊）
        /// </summary>
        public string tzbz;
    }
}
