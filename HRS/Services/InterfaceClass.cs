using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HRS.Interface.Services;

namespace HRS.Services
{
    public class InterfaceClass
    {
        [Import(typeof(yy))]
        public yy yyService { set; get; }

        private static InterfaceClass _InterfaceClass = null;
        public static InterfaceClass Instance()
        {
            if (_InterfaceClass == null)
            {
                _InterfaceClass = new InterfaceClass();
                _InterfaceClass.Compose();
            }
            return _InterfaceClass;
        }

        /// <summary>
        /// 注入
        /// </summary>
        private void Compose()
        {
            try
            {
                var catalog = new AssemblyCatalog(Assembly.LoadFile(System.Environment.CurrentDirectory + "\\" + ConfigConstants.INTERFACE_DLL));
                CompositionContainer container = new CompositionContainer(catalog);
                container.ComposeParts(_InterfaceClass);
            }
            catch (Exception e)
            {

            }
        }
    }
}
