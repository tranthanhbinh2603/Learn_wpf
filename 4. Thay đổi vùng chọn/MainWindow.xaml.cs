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

namespace _4.Thay_đổi_vùng_chọn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void btRun_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Select(tb.SelectionStart, tb.SelectionLength);
        }
    }
}
