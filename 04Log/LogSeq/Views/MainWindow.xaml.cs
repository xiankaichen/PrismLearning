using System.Windows;
using Microsoft.Extensions.Logging;
using NLog;

namespace LogSeq.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Logger<MainWindow> _logger;

        public MainWindow(Logger<MainWindow> logger)
        {
            InitializeComponent();
            this._logger = logger;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _logger.LogInformation("这是测试的写入日志");
            _logger.LogError("这是错误日志测试");
            _logger.LogWarning("这是警告测试");
        }
    }
}
