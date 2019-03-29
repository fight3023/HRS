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
    /// TimeCountdown.xaml 的交互逻辑
    /// </summary>
    public partial class TimeCountdown : Label
    {
        Timer tmr = new Timer();
        private int countdown = 120;
        public delegate void TimeOutEvent(object sender);
        public event TimeOutEvent TimeOut;

        public int CountDownTime
        {
            get
            {
                return this.countdown;
            }
            set
            {
                this.countdown = value;
            }
        }
        public TimeCountdown()
        {
            InitializeComponent();
            tmr.Interval = 1000;
            tmr.Elapsed += tmr_Elapsed;
        }

        void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(delegate
            {
                int tm = int.Parse(this.Content.ToString());
                int tmNow = tm - 1;
                if (tmNow <= 0)
                {
                    if (this.TimeOut != null)
                    {
                        TimeOut(this);
                        Stop();
                    }
                }
                else
                {
                    this.Content = tm - 1;
                }

            }));
        }
        public void StartTimeOut()
        {
            this.Content = countdown;
            this.tmr.Start();
        }

        public void Stop()
        {
            this.tmr.Stop();
        }
    }
}
