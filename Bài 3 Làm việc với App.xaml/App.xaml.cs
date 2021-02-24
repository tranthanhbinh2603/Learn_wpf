using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bài_3_Làm_việc_với_App.xaml
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e) //Hàm cần tạo. Làm bất cú thứ gì trong đây
        {
            try
            {
                MessageBox.Show("Đây là một MessageBox");
                MainWindow wnd = new MainWindow();
                wnd.Title = "Something else";
                wnd.Show();
            }
            finally
            {
                MessageBox.Show("Bạn đã đóng");
            }
           
        }
    }
}
