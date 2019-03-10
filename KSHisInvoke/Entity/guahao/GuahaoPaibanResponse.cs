using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.guahao
{
    /// <summary>
    /// 当日排班响应参数
    /// </summary>
    class GuahaoPaibanResponse : CommonResponse
    {
        string PAIBANID { get; set; }//	排班ID 	String (10)		不可空	10015745
        string KESHIID { get; set; }//	科室ID	String (10)	关联科室	不可空	5672
        string YISHENGID { get; set; }//	医生ID	String (10)	关联职工	可空	
        string GUAHAOLB { get; set; }//	挂号类别	String (10)	1.普通,2.急诊,4.专家	不可空	4
        string XINGQI { get; set; }//	星期	NUMBER(6)	周日到周六分别是1-7	不可空	7
        string RIQI { get; set; }//	日期	DATE	yyyy-MM-dd	不可空	2013/11/15
        string SHANGWUZGXH { get; set; }//	上午最高限号	NUMBER(6)		可空	
        string SHANGWUYGH { get; set; }//	上午已挂号	NUMBER(6)		可空	
        string XIAWUZGXH { get; set; }//	下午最高限号	NUMBER(6)		可空	
        string XIAWUYGH { get; set; }//	下午已挂号	NUMBER(6)		可空	
        string WANSHANGZGXH { get; set; }//	晚上最高限号	NUMBER(6)		可空	
        string WANSHANGYGH { get; set; }//	晚上已挂号	NUMBER(6)		可空	
        string ZHENLIAOFXM { get; set; }//	诊疗费项目	String (10)	关联收费项目	不可空	1102
        string GUAHAOFXM { get; set; }//	挂号费项目	String (10)	关联收费项目	可空	
        string WANSHANGZLFXM { get; set; }//	晚上诊疗费项目	String (10)	关联收费项目	可空	
        string WANSHANGGHFXM { get; set; }//	晚上挂号费项目	String (10)	关联收费项目	可空	
        string WEIZHI { get; set; }//	位置	String (100)		可空	
        string FAPIAODYBZ { get; set; }//	发票打印标志	NUMBER(1)		可空	
        string YISHENGXB { get; set; }//	医生性别	String (4)		可空	
        string SHANGWUKZSJ { get; set; }//	上午开诊时间	DATE	yyyy-MM-dd HH:mm:ss	可空	2013/11/15 10:10
        string SHANGWUBZSJ { get; set; }//	上午闭诊时间	DATE		可空	
        string XIAWUKZSJ { get; set; }//	下午开诊时间	DATE		可空	
        string XIAWUBZSJ { get; set; }//	下午闭诊时间	DATE		可空	
        string WANSHANGKZSJ { get; set; }//	晚上开诊时间 	DATE		可空	
        string WANSHANGBZSJ { get; set; }//	晚上闭诊时间	DATE		可空	
        string XIUGAISJ { get; set; }//	修改时间	DATE		可空	
        string XIUGAIREN { get; set; }//	修改人	String(10)		可空	
        string KESHIMC { get; set; }//	科室名称	String（100）		可空	骨科
        string YISHENGXM { get; set; }//	医生姓名	String（20）		可空	吴柏年
        string ZHENLIAOFJE { get; set; }//	诊疗费金额	NUMBER(18,4)		可空	40
        string GUAHAOFJE { get; set; }//	挂号费金额	NUMBER(18,4)		可空	40
        string WANSHANGZLFJE { get; set; }//	晚上诊疗费金额	NUMBER(18,4)		可空	40
        string WANSHANGGHFJE { get; set; }//	晚上挂号费金额	NUMBER(18,4)		可空	40
        string GUAHAOLBMC { get; set; }//	挂号类别名称	String（100）			专家
        string YUANQUID { get; set; }//	院区ID	String(20)	用于标识同一家医院的不同院区	不可空	1
    }
}
