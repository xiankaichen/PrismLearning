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
using Prism.Services.Dialogs;

namespace NavigationView.Views
{
    /// <summary>
    /// MsgDialog.xaml 的交互逻辑
    /// </summary>
    public class MsgDialog : IDialogAware
    {
        public string Title { get; set; }

        public MsgDialog()
        {
            Title = "Dialog";
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }
    }
}
