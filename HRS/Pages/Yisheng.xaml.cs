using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
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
using HRS.Interface.Services;

namespace HRS.Pages
{
    /// <summary>
    /// Yisheng.xaml 的交互逻辑
    /// </summary>
    public partial class Yisheng : Page
    {
        [Import(typeof(yy))]
        public yy yyService { set; get; }

        public Yisheng()
        {
            InitializeComponent();
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
