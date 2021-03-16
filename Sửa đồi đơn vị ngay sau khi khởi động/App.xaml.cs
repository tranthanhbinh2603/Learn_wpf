using System.Globalization;
using System.Threading;
using System.Windows;

namespace Sửa_đồi_đơn_vị_ngay_sau_khi_khởi_động
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            //Nếu có nhiều luồng, bạn dùng: CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");

            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
