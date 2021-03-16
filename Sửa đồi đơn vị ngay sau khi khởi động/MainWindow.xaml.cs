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

namespace Sửa_đồi_đơn_vị_ngay_sau_khi_khởi_động
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double largeNumber = 123456789.42;
            lblNumberUs.Content = largeNumber.ToString("N2");
            lblNumberDe.Content = largeNumber.ToString("N2");
            lblNumberSe.Content = largeNumber.ToString("N2");
        }
    }
}
