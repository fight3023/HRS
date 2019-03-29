using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HRS.Controls;
using HRS.Interface.Entity;
using HRS.Interface.Services;
using HRS.Services;

namespace HRS.Pages
{
    /// <summary>
    /// Keshi.xaml 的交互逻辑
    /// </summary>
    public partial class Keshi : Page
    {

        public Keshi()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            try
            {
                ResultPojo result = InterfaceClass.Instance().yyService.mzValidSche(ConfigConstants.ZDBH, ConfigConstants.JYDM, 0);
                if (result != null && result.appCode == "0")
                {
                    if (!string.IsNullOrEmpty(result.resultList.ToString()))
                    {

                    }
                }
                else
                {
                    Console.WriteLine(result.dataBuffer);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void EButton_Click_1(object sender, RoutedEventArgs e)
        {
            string str = ((EButton)sender).TargetPage;
            if (!string.IsNullOrEmpty(str))
            {
                NavigationService.GetNavigationService(this).Navigate(new Uri(str, UriKind.Relative));
            }
        }
    }
}
