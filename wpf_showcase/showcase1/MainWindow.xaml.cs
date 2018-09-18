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

namespace showcase1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string context = tBoxName.Text;
            string showMsg = string.Format("添加的内容:{0}", context);
            MessageBox.Show(showMsg);
        }

        private void tBoxName_MouseEnter(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("鼠标移入");
            tBoxName.Focus();
        }

        public void Close_clickHandler(Object sender, RoutedEventArgs e)
         {
             this.Close();
         }
 
         private void Mouse_moveHandler(object sender, MouseEventArgs e)
         {
             if (e.LeftButton == MouseButtonState.Pressed&& e.Source == this) this.DragMove();
         }
}
}
