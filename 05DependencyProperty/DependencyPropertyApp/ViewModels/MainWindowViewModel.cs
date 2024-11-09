using Prism.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace DependencyPropertyApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Password Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string username;
        public string UserName
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        public string password;
        public string Password
        {
            get { return password; }
            set
            {
                SetProperty(ref password, value);
            }
        }

        public MainWindowViewModel()
        {

            UserName = "用户名称";
            Password = "密码";
        }
    }

}
