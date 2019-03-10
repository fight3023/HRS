using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.shoufei
{
    class ShoufeiYijiResponse
    {
        string YIJIID { get; set; }//	医技ID	VARCHAR2(36)		不可空	1000230242
        string BINGRENID { get; set; }//	病人ID	VARCHAR2(15)		不可空	13080636
        string FEIYONGXZ { get; set; }//	费用性质	VARCHAR2(10)		不可空	XJ01
        string KAIDANYS { get; set; }//	开单医生	VARCHAR2(20)		可空	DBA
        string KAIDANRQ { get; set; }//	开单日期	DATE	yyyy-MM-dd HH:mm:ss	不可空	2011/11/29 0:01
        string KAIDANKS { get; set; }//	开单科室	VARCHAR2(20)		不可空	50172
        string ZHIXINGKS { get; set; }//	执行科室	VARCHAR2(20)		可空	
        string NIANLINGDW { get; set; }//	年龄单位	VARCHAR2(4)		可空	
        string NIANLING { get; set; }//	生日	DATE		可空	
        string XINGBIE { get; set; }//	性别	VARCHAR2(4)		可空	
        string BINGRENXM { get; set; }//	病人姓名	VARCHAR2(50)		不可空	张三
        string ZHIDANREN { get; set; }//	制单人	VARCHAR2(10)		可空	
        string ZHIDANRQ { get; set; }//	制单日期	DATE		可空	
        string XIUGAIREN { get; set; }//	修改人	VARCHAR2(10)		可空	
        string XIUGAISJ { get; set; }//	修改时间	DATE		可空	
        string XIUGAIYYID { get; set; }//	修改应用ID	VARCHAR2(4)		可空	
        string XIUGAIBZ { get; set; }//	修改标志	VARCHAR2(4)		可空	
        string YIJIMXID { get; set; }//	医技明细ID	VARCHAR2(36)		不可空	1000230242
        string SHUNXUHAO { get; set; }//	顺序号	NUMBER(6)		可空	
        string HESUANXM { get; set; }//	核算项目	VARCHAR2(10)		不可空	8888
        string SHOUFEIXM { get; set; }//	收费项目	VARCHAR2(10)		不可空	8888
        string XIANGMUMC { get; set; }//	项目名称	VARCHAR2(100)		不可空	其他
        string JIESUANJIA { get; set; }//	结算价	NUMBER(18,4)		不可空	1000.5
        string SHULIANG { get; set; }//	数量	NUMBER(18,4)		不可空	12
        string JIESUANJE { get; set; }//	结算金额	NUMBER(18,4)		不可空	2000.56
        string BIAOZHUNJE { get; set; }//	标准金额	NUMBER(18,4)		可空	1500.9
        string ZIFUBL { get; set; }//	自付比例	NUMBER(8,4)		不可空	0.5
        string YIBAODJ { get; set; }//	医保等级	VARCHAR2(4)		可空	
        string JIJIADW { get; set; }//	计价单位	VARCHAR2(10)		可空	
        string ZILIJE { get; set; }//	自理金额	NUMBER(18,4)		可空	
        string ZIFEIJE { get; set; }//	自费金额	NUMBER(18,4)		可空	
        string XIANGMULX { get; set; }//	项目类型	VARCHAR2(4)		可空	
        string KAIDANKS2 { get; set; }//	开单科室	VARCHAR2(10)		可空	
        string ZHIXINGKS2 { get; set; }//	执行科室	VARCHAR2(10)		可空	
        string KAIDANYSXM { get; set; }//	开单医生姓名	String (20)		不为空	刘岳英
        string KAIDANKSMC { get; set; }//	开单科室名称	String (100)		不为空	手外科
        string HESUANXMMC { get; set; }//	核算项目名称	String (100)		不为空	材料费
        string YIZHUMC { get; set; }//	医嘱名称	String (200)			医技1
        string ZHIXINGKSMC { get; set; }//	执行科室名称	String (200)			
        string SUODINGBZ { get; set; }//	锁定标志	String (1)			1.已锁定,0.未锁定
        string SUODINGSJ { get; set; }//	锁定时间	String (50)			
        string SUODINGYY { get; set; }//	锁定应用	String (20)			
        string SUODINGREN { get; set; }//	锁定人	String (20)			
        string DAIKOUBZ { get; set; }//	代扣标志	String (1)			1.已代扣项目
        string JIUZHENID { get; set; }//	就诊ID	String (50)	标识每次挂号的唯一值	可空	
    }
}
