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

namespace HRS
{
    /// <summary>
    /// MainItem.xaml 的交互逻辑
    /// </summary>
    public partial class MainItem : UserControl
    {
        public MainItem()
        {
            InitializeComponent();
        }
        public string ItemText {
            get{  return lblText.Content.ToString(); }
            set { lblText.Content  = value; }
        }
        public ImageSource ItemImageSource
        {
            get { return imgLogo.Source; }
            set { imgLogo.Source = value; }
        }
        public Brush ItemBackground
        {
            get { return gridMain.Background; }
            set { gridMain.Background = value; }
        }

    }
}
