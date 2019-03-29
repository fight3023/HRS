using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Interface.Entity
{
    [Serializable]
    public class ResultPojo
    {
        public string appCode = "0";
        public string dataBuffer = "成功";
        public object resultList;
    }
}
