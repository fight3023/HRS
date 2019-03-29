using System;
using System.Collections.Generic;
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

namespace HRS.Controls
{
    /// <summary>
    /// TimeControl.xaml 的交互逻辑
    /// </summary>
    public partial class TimeControl : UserControl
    {
        Timer tmr = new Timer();
        public TimeControl()
        {
            InitializeComponent();
            tmr.Interval = 2000;
            tmr.Elapsed += tmr_Elapsed;
            tmr_Elapsed(tmr, null);
            tmr.Start();
        }

        private void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(delegate
            {
                DateTime dt = DateTime.Now;
                lblDate.Content = dt.ToString("yyyy/MM/dd");
                lblTime.Content = dt.ToString("HH:mm");
                lblWeek.Content = dt.ToString("dddd");

            }));
        }
    }
}
