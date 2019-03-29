using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS.Interface.Entity;
using HRS.Interface.Services;
using HRS.Interface.WS.HISWSServer;
using HRS.Util;

namespace HRS.Interface.WS.Services
{
    [Export(typeof(yy))]
    public class yyWS : yy
    {
        HISWSServerClient client;

        public yyWS()
        {
            client = new HISWSServerClient();
        }
        public ResultPojo yyValidSche(string zdbh, string jydm, string ksdm, int zjmz, string ysdm, string gzrq, int sxw)
        {
            string strResult = client.yyValidSche(zdbh, jydm, ksdm, zjmz, ysdm, gzrq, sxw);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

       
        public ResultPojo yyValidScheHos(string zdbh, string jydm, string ksdm, int zjmz, string ysdm, string gzrq, string sxw, string hid)
        {
            //string strResult = client.yyValidSche(zdbh, jydm, ksdm, zjmz, ysdm, gzrq, sxw, hid);
            return null;
        }

        public ResultPojo yyValidPool(string zdbh, string jydm, string ksdm, string ysdm, string gzrq, int sxw, string pbsb, int cxfs)
        {
            string strResult = client.yyValidPool(zdbh, jydm, ksdm, ysdm, gzrq, sxw, pbsb, cxfs);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

        
        public ResultPojo yyOrder(string zdbh, string jydm, string brid, string ksdm, string ysdm, string jzrq, int sxw, string pdhm, string pbsb)
        {
            string strResult = client.yyOrder(zdbh, jydm, brid, ksdm, ysdm, jzrq, sxw, pdhm, pbsb);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

      
        public ResultPojo yyOrderZf(string zdbh, string jydm, string brxm, string sfzh, string ksdm, string ysdm, string jzrq, string kssj, string pdhm, string pbsb, int zffs)
        {
            
            return null;
        }

       
        public ResultPojo yyOrderQuery(string zdbh, string jydm, string brid, string jzrq)
        {
            string strResult = client.yyOrderQuery(zdbh, jydm, brid, jzrq);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

        
        public ResultPojo yyOrderQueryRq(string zdbh, string jydm, string brxm, string sfzh, string pbsb, string pdhm, string status, string begrq, string endrq)
        {
            return null;
        }

       
        public ResultPojo yyOrderTake(string zdbh, string jydm, string brid, string yyxh, string ysdm, string ksdm)
        {
            string strResult = client.yyOrderTake(zdbh, jydm, brid, yyxh, ysdm, ksdm);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

      
        public ResultPojo yyOrderCancel(string zdbh, string jydm, string yyxh)
        {
            string strResult = client.yyOrderCancel(zdbh, jydm, yyxh);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

       
        public ResultPojo yyOrderCancelBr(string zdbh, string jydm, string brxm, string sfzh, string jzrq, string yyxh)
        {
            return null;
        }

       
        public ResultPojo mzValidSche(string zdbh, string jydm, int zjmz)
        {
            string strResult = client.mzValidSche(zdbh, jydm, zjmz);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

        
        public ResultPojo mzValid(string zdbh, string jydm, string brid, string ksdm, string ysdm, string ybkmm, string ybkxx, string pbsb)
        {
            string strResult = client.mzValid(zdbh, jydm, brid, ksdm, ysdm, ybkmm, ybkxx, pbsb);
            ResultPojo pojo = JSONHelper.FromJSON<ResultPojo>(strResult);
            return pojo;
        }

       
        public ResultPojo yyHos(string zdbh, string jydm, string rtype, string hname, string acode)
        {
            //string strResult = client.yyHos(zdbh, jydm, rtype, hname, acode);
            return null;
        }
    }
}
