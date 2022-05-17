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
using HandyControl.Tools;

namespace ExcelAddInHCSimple
{
    /// <summary>
    /// Interaction logic for HcTestApp.xaml
    /// </summary>
    public partial class HcTestApp : Application
    {
        public HcTestApp()
        {
            InitializeComponent();

            var hcTestWindow = new HcTest();
            hcTestWindow.ShowDialog();

            //Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            //Application.Current.MainWindow = hcTestWindow;
            //Application.Current.MainWindow.ShowDialog();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ConfigHelper.Instance.SetLang("en");

        }
    }
}