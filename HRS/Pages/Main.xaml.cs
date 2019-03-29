using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HRS.Pages
{
    /// <summary>
    /// Main.xaml 的交互逻辑
    /// </summary>
    public partial class Main : Page
    {
        public Main()
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
