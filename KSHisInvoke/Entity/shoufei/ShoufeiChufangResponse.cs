using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSHISInvoke.Entity.shoufei
{
    /// <summary>
    /// 处方信息响应参数
    /// </summary>
    class ShoufeiChufangResponse
    {
        string CHUFANGID { get; set; }//	处方ID	String(36)		不可空	53210	
        string CHUFANGHM { get; set; }//	处方号码	String (10)	无	不可空	10015745	
        string KAIDANYS { get; set; }//	开单医生	String (10)		不可空	10012	
        string KAIDANRQ { get; set; }//	开单日期	DATE		不可空	2013/11/15	
        string KAIDANKS { get; set; }//	开单科室	String (20)		不可空	5672	
        string ZHIXINGKS { get; set; }//	执行科室	String (20)		不可空	5672	
        string BINGRENID { get; set; }//	病人ID	String (15)		不可空	10782	
        string BINGRENXM { get; set; }//	病人姓名	String (50)		不可空	张三	
        string XINGBIE { get; set; }//	性别	String (4)		可空		
        string NIANLING { get; set; }//	生日	DATE		可空		
        string NIANLINGDW { get; set; }//	年龄单位	String (4)		可空		
        string TIZHONG { get; set; }//	体重	NUMBER(18,4)		可空		
        string CHUFANGLX { get; set; }//	处方类型	String (4)	无	不可空	1	
        string FEIYONGLB { get; set; }//	费用类别	String (10)		不可空	1	
        string FEIYONGLBMC { get; set; }//	费用类别名称	String (100)		不可空	其他	
        string FEIYONGXZ { get; set; }//	费用性质	String (10)		不可空	其他	
        string FEIYONGXZMC { get; set; }//	费用性质名称	String (100)		不可空	其他	
        string CHUFANGTS { get; set; }//	处方贴数	NUMBER(6)		可空		
        string CHUFANGMXID { get; set; }//	处方明细ID	String (36)		不可空	1021	
        string SHUNXUHAO { get; set; }//	顺序号	NUMBER(6)		可空	1	
        string JIAGEID { get; set; }//	价格ID	String (36)		不可空	3212	
        string GEIYAOFS { get; set; }//	给药方式	String (10)		可空		
        string GEIYAOFSMC { get; set; }//	给药方式名称	String (100)		可空		
        string HESUANXM { get; set; }//	核算项目	String (10)		不可空	1001	
        string HESUANXMMC { get; set; }//	核算项目名称	String (100)		不可空	其他项目	
        string SHOUFEIXM { get; set; }//	收费项目	String (10)		不可空	1002	
        string SHOUFEIXMMC { get; set; }//	收费项目名称	String (100)		不可空	其他项目1	
        string ZUHAO { get; set; }//	组号	NUMBER(6)	显示成组医嘱使用	可空		
        string ZHUYAOBZ { get; set; }//	主药标志	NUMBER(1)	显示成组医嘱使用	不可空	1	
        string YAOPINLX { get; set; }//	药品类型	String (4)	1.西药,2.成药,3.草药	不可空	1	
        string YAOPINMC { get; set; }//	药品名称	String (100)		不可空	阿莫西林	
        string JIESUANJIA { get; set; }//	结算价	NUMBER(18,4)		不可空	32	
        string SHULIANG { get; set; }//	数量	NUMBER(18,4)	草药需要再乘以帖数	不可空	3	
        string JIESUANJE { get; set; }//	结算金额	NUMBER(18,4)	草药需要再乘以帖数	不可空	96	
        string ZIFUBL { get; set; }//	自付比例	NUMBER(8,4)		不可空	0.5	
        string PINCI { get; set; }//	频次	String (10)		可空	QOD	
        string YICIJL { get; set; }//	一次剂量	NUMBER(18,4)		可空		
        string JILIANGDW { get; set; }//	剂量单位	String (50)		可空		
        string YONGYAOTS { get; set; }//	用药天数	NUMBER(6)		可空		
        string YIBAODJ { get; set; }//	医保等级	String (4)		可空		
        string ZIFEIBZ { get; set; }//	自费标志	NUMBER(1)		不可空	0	
        string ZIBEIBZ { get; set; }//	自备标志	NUMBER(1)	1.自备药	不可空	1	
        string YISHENGZT { get; set; }//	医生嘱托	String (200)		可空		
        string PISHIBZ { get; set; }//	皮试标志	NUMBER(1)		可空		
        string PISHIJG { get; set; }//	皮试结果	String (10)		可空		
        string ZHUSHECS { get; set; }//	注射次数	NUMBER(4)		可空		
        string BENYUANZSCS { get; set; }//	本院注射次数	NUMBER(4)		可空		
        string BAOZHUANGDW { get; set; }//	包装单位	String (20)		可空		
        string YAOPINGG { get; set; }//	药品规格	String (50)		不可空	12*3ml	
        string BAOZHUANGLIANG { get; set; }//	包装量	NUMBER(18,4)		不可空	12	
        string JILIANG { get; set; }//	剂量	NUMBER(18,4)		可空		
        string ZIFEIJE { get; set; }//	自费金额	NUMBER(18,4)		可空		
        string ZILIJE { get; set; }//	自理金额	NUMBER(18,4)		可空		
        string KAIDANYSXM { get; set; }//	开单医生姓名	String (30)		不为空	刘岳英	
        string KAIDANKSMC { get; set; }//	开单科室名称	String (100)		不为空	手外科	
        string SUODINGBZ { get; set; }//	锁定标志	String (1)			1.已锁定,0.未锁定	
        string SUODINGSJ { get; set; }//	锁定时间	String (50)				
        string SUODINGYY { get; set; }//	锁定应用	String (20)				
        string SUODINGREN { get; set; }//	锁定人	String (20)				
        string JIUZHENID { get; set; }//	就诊ID	String (50)	标识每次挂号的唯一值	可空		
    }
}
