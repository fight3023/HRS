using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WXHisInvoke.Entity;

namespace WXHisInvoke.Common
{
    public class RequestHelper
    {
        public BASE_O doRequestSingle(BASE_I i)
        {
            string iStr = XmlPackageHelper.SerializeToXml(i);
            long ll_recvlen = 65535;
            string ls_recvbuf = new StringBuilder(65535).ToString();
            long ll_sendlen = Encoding.Default.GetBytes(iStr).Length;
            int ll_result = HisDllInterface.KTPBNI_Trading(iStr, ll_sendlen, ref ls_recvbuf, ll_recvlen);
            return XmlPackageHelper.DeserializeToObject<BASE_O>(ls_recvbuf);
        }

        //public List<BASE_O> doRequestMulti(BASE_I i)
        //{

        //}
    }
}
