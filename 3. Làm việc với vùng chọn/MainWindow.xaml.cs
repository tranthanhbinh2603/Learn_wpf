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

namespace _3.Làm_việc_với_vùng_chọn
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

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e) //Khi chọn vào textbox sẽ kích hoạt event này
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Bạn đang để con trỏ chuột ở kí tự thứ " + textBox.SelectionStart + Environment.NewLine; //Lấy kí tự mà con trỏ đang trỏ vào
            txtStatus.Text += "Độ dài của chuỗi đã chọn " + textBox.SelectionLength + Environment.NewLine; //Số lượng kí tự đang chọn
            txtStatus.Text += "Các kí tự đang chọn: '" + textBox.SelectedText + "'"; //Các kí tự đang chọn
        }
    }
}
