using System;
using System.Windows;

namespace WpfTutorialSamples.WPF_Application
{
    public partial class ExceptionHandlingSample : Window
    {
        public ExceptionHandlingSample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            s.Trim();
        }
    }
}