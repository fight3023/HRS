using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HRS.Interface.Services;
using HRS.Pages;

namespace HRS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string strStatus = "";

        Page mainPage = new Main();
        public MainWindow()
        {
            InitializeComponent();
            BackToMain();
            strStatus = "机器编号：" + ConfigConstants.ZDBH + "   版本号：1.0.1 技术支持：京威盛智能    服务热线：4008-678-511";
        }

        public void BackToMain()
        {
            this.frmMain.Navigate(mainPage);
        }

        public void ShowPage(Page page)
        {
            this.frmMain.Navigate(page);
        }
    }
}
