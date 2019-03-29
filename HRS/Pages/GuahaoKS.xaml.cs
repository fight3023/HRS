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

namespace HRS.Pages
{
    /// <summary>
    /// GuahaoKS.xaml 的交互逻辑
    /// </summary>
    public partial class GuahaoKS : Page
    {
        public GuahaoKS()
        {
            InitializeComponent();
            this.lblTimeOut.StartTimeOut();
        }

        private void TimeCountdown_TimeOut_1(object sender)
        {
            MainWindow window = (MainWindow)Window.GetWindow(this);
            window.BackToMain();
        }

        private void EButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
